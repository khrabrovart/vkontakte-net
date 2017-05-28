using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Citrina.StandardApi.Models;
using Newtonsoft.Json.Linq;

namespace Citrina.StandardApi.Core
{
    internal static class RequestManager
    {
        private const int RequestLimit = 9;
        private const double MeasureTime = RequestLimit/3.0;

        private static readonly ConcurrentDictionary<string, SemaphoreSlim> Semaphores;

        static RequestManager()
        {
            Semaphores = new ConcurrentDictionary<string, SemaphoreSlim>();
        }

        public static async Task<ApiCall<TRequest, TResponse>> CreateRequestAsync<TRequest, TResponse>(string method, TRequest request, bool isCustom = false)
            where TRequest : IRequestModel
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (string.IsNullOrWhiteSpace(method))
            {
                throw new ArgumentException("Invalid VK API method name.", nameof(method));
            }

            var call = new InternalApiCall<TRequest, TResponse>
            {
                Method = isCustom ? $"execute.{method}" : method,
                Request = request,
                RequestType = typeof (TRequest),
                ResponseType = typeof (TResponse),
                IsCustom = isCustom,
                Parameters = isCustom ?
                    ((ExecuteRequest) (IRequestModel) request).Parameters :
                    JsonCore.Serialize<Dictionary<string, string>>(request)
            };

            var version = ((ApiVersionAttribute) request.GetType().GetTypeInfo().GetCustomAttributes(typeof (ApiVersionAttribute)).FirstOrDefault())?.Value ??
                CitrinaGlobalSettings.ApiVersion;

            if (call.Parameters.ContainsKey("v"))
            {
                call.Parameters["v"] = version;
            }
            else
            {
                call.Parameters.Add("v", version);
            }
            
            if (call.Request.AccessToken is UserAccessToken || call.Request.AccessToken is CommunityAccessToken)
            {
                await EnqueueAsync(call.Request.AccessToken, call).ConfigureAwait(false);
            }
            else
            {
                await InstantAsync(call).ConfigureAwait(false);
            }

            return new ApiCall<TRequest, TResponse>(call.Method, call.Parameters, call.CreatedOn, call.ExecutionTime, call.IsCustom, call.IsError, call.Error, call.Request, call.Response);
        }

        private static async Task<string> StartProcessingAsync<TRequest, TResponse>(InternalApiCall<TRequest, TResponse> request)
            where TRequest : IRequestModel
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var response = await HttpCore.ProcessRequestAsync(request).ConfigureAwait(false);
            sw.Stop();
            request.ExecutionTime = sw.Elapsed;

            return response;
        }

        private static void DeserializeResponse<TRequest, TResponse>(InternalApiCall<TRequest, TResponse> request, string response)
            where TRequest : IRequestModel
        {
            try
            {
                dynamic jobj = JObject.Parse(response);

                if (jobj.error != null)
                {
                    var internalError = (InternalApiCallError) JsonCore.Deserialize<InternalApiCallError>(jobj.error.ToString());
                    request.Error = new ApiCallError(internalError.Code, internalError.Message, internalError.RequestParameters.ToDictionary(k => k.Key, v => v.Value));
                    request.IsError = true;
                }
                else if (jobj.response != null)
                {
                    request.Response = JsonCore.Deserialize(jobj.response.ToString(), request.ResponseType);
                }
            }
            catch (Exception e)
            {
                request.Error = new ApiCallError(null, $"Error occured in method {nameof(DeserializeResponse)}, Type={e.GetType()}, Message={e.Message}", null);
                request.IsError = true;
            }
        }

        private static async Task EnqueueAsync<TRequest, TResponse>(IAccessToken accessToken, InternalApiCall<TRequest, TResponse> request)
            where TRequest : IRequestModel
        {
            var semaphore = Semaphores.GetOrAdd(accessToken.Value, new SemaphoreSlim(RequestLimit));
            await semaphore.WaitAsync().ConfigureAwait(false);

            Task.Delay(TimeSpan.FromSeconds(MeasureTime))
                .ConfigureAwait(false).GetAwaiter()
                .OnCompleted(() => semaphore.Release());

            var response = await StartProcessingAsync(request).ConfigureAwait(false);

            if (!request.IsError)
            {
                DeserializeResponse(request, response);
            }

            if (request.Error?.Code == 6)
            {
                request.IsError = false;
                request.Error = null;
                await EnqueueAsync(accessToken, request).ConfigureAwait(false);
            }
        }

        private static async Task InstantAsync<TRequest, TResponse>(InternalApiCall<TRequest, TResponse> request)
            where TRequest : IRequestModel
        {
            var response = await StartProcessingAsync(request).ConfigureAwait(false);

            if (!request.IsError)
            {
                DeserializeResponse(request, response);
            }
        }
    }
}