using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Citrina.StandardApi.Models;

namespace Citrina.StandardApi.Core
{
    internal static class HttpCore
    {
        public static async Task<string> ProcessRequestAsync<TRequest, TResponse>(InternalApiCall<TRequest, TResponse> request)
            where TRequest : IRequestModel
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            try
            {
                return await SendAsync(request.Method, request.Parameters).ConfigureAwait(false);
            }
            catch (TaskCanceledException)
            {
                request.Error = new ApiCallError(null, "Request has reached its timeout.", null);
                request.IsError = true;
            }
            catch (Exception e)
            {
                request.Error = new ApiCallError(null, $"Error occured while sending request: Type={e.GetType()}, Message={e.Message}", null);
                request.IsError = true;
            }

            return null;
        }

        private static async Task<string> SendAsync(string method, Dictionary<string, string> parameters)
        {
            try
            {
                using (var client = new HttpClient
                {
                    Timeout = TimeSpan.FromSeconds(10)
                })
                {
                    using (var response = await client.PostAsync("https://api.vk.com/method/" + method, new FormUrlEncodedContent(parameters)).ConfigureAwait(false))
                    {
                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }
                }
            }
            catch (HttpRequestException)
            {
                return await SendAsync(method, parameters).ConfigureAwait(false);
            }
        }
    }
}