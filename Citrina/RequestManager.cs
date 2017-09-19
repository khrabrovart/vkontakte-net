using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Citrina.Json;
using Citrina.Models;
using Newtonsoft.Json.Linq;

namespace Citrina
{
    internal static class RequestManager
    {
        #region Errors

        private const string TimeoutErrorText = "Request has reached its timeout.";
        private const string InvalidMethodErrorText = "Invalid VK API method name.";
        private const string EmptyResponseErrorText = "Response is empty.";

        #endregion

        private const string VkApiPath = "https://api.vk.com/method/";
        private const int RequestsLimit = 9;
        private const double MeasurePeriodSeconds = 3;
        private const double QueueDelaySeconds = RequestsLimit / MeasurePeriodSeconds;

        private static HttpClient _client;
        private static readonly ConcurrentDictionary<string, SemaphoreSlim> Queues = new ConcurrentDictionary<string, SemaphoreSlim>();

        public static async Task<ApiRequest<TResponse>> CreateRequestAsync<TResponse>(string method, IAccessToken accessToken, object parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            if (string.IsNullOrWhiteSpace(method))
            {
                throw new ArgumentException(InvalidMethodErrorText, nameof(method));
            }

            var internalRequest = new InternalApiRequest<TResponse>
            {
                Method = method,
                AccessToken = accessToken,
                Parameters = CitrinaJsonConverter.Serialize<Dictionary<string, string>>(parameters)
            };

            internalRequest.Parameters.Add("v", RequestSettings.ApiVersion);

            await ProcessAsync(internalRequest).ConfigureAwait(false);

            return new ApiRequest<TResponse>(internalRequest.Method, internalRequest.Parameters, internalRequest.CreatedOn, internalRequest.Error, internalRequest.Response);
        }

        public static async Task<ApiRequest<TResponse>> CreateExecuteRequestAsync<TResponse>(string method, IAccessToken accessToken, Dictionary<string, string> parameters)
        {
            if (accessToken == null)
            {
                throw new ArgumentNullException(nameof(accessToken));
            }

            if (string.IsNullOrWhiteSpace(method))
            {
                throw new ArgumentException(InvalidMethodErrorText, nameof(method));
            }

            var internalRequest = new InternalApiRequest<TResponse>
            {
                Method = method.StartsWith("execute.") ? method : $"execute.{method}",
                AccessToken = accessToken,
                Parameters = parameters
            };

            if (!parameters.ContainsKey("access_token"))
            {
                internalRequest.Parameters.Add("access_token", accessToken.Value);
            }

            internalRequest.Parameters.Add("v", RequestSettings.ApiVersion);

            await ProcessAsync(internalRequest).ConfigureAwait(false);

            return new ApiRequest<TResponse>(internalRequest.Method, internalRequest.Parameters, internalRequest.CreatedOn, internalRequest.Error, internalRequest.Response);
        }

        private static async Task ProcessAsync<TResponse>(InternalApiRequest<TResponse> request)
        {
            try
            {
                SemaphoreSlim queue = null;

                if (request.AccessToken != null && request.AccessToken.IsLimited)
                {
                    queue = Queues.GetOrAdd(request.AccessToken.Value, new SemaphoreSlim(RequestsLimit));
                    await queue.WaitAsync().ConfigureAwait(false);
                }

                var response = await SendAsync(request).ConfigureAwait(false);

                if (queue != null)
                {
                    Task.Delay(TimeSpan.FromSeconds(QueueDelaySeconds))
                        .ConfigureAwait(false)
                        .GetAwaiter()
                        .OnCompleted(() => queue.Release());
                }
                
                ObtainDeserializedResponse(request, response);
            }
            catch (TaskCanceledException)
            {
                request.Error = new ApiError(TimeoutErrorText);
            }
            catch (Exception e)
            {
                request.Error = new ApiError(e.ToString());
            }
        }

        private static async Task<string> SendAsync<TResponse>(InternalApiRequest<TResponse> request)
        {
            if (_client == null)
            {
                _client = new HttpClient
                {
                    Timeout = RequestSettings.Timeout
                };
            }

            using (var responseMessage = await _client.PostAsync(VkApiPath + request.Method, new FormUrlEncodedContent(request.Parameters)).ConfigureAwait(false))
            {
                return await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }

        private static void ObtainDeserializedResponse<TResponse>(InternalApiRequest<TResponse> request, string response)
        {
            if (string.IsNullOrWhiteSpace(response))
            {
                request.Error = new ApiError(EmptyResponseErrorText);
            }

            var parsedResponse = JObject.Parse(response);
            JToken errorToken, responseToken;

            if ((errorToken = parsedResponse["error"]) != null)
            {
                var error = (ErrorResponse)CitrinaJsonConverter.Deserialize(errorToken.ToString(), typeof(ErrorResponse));
                request.Error = new ApiError(error.Code, error.Message, error.RequestParameters?.ToDictionary(k => k.Key, v => v.Value));
            }
            else if ((responseToken = parsedResponse["response"]) != null)
            {
                request.Response = (TResponse)CitrinaJsonConverter.Deserialize(responseToken.ToString(), typeof(TResponse));
            }
        }
    }
}