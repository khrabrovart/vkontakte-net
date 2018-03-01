using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class StreamingApi : IStreamingApi
    {
        public Task<ApiRequest<StreamingGetServerUrlResponse>> GetServerUrl(ServiceAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<StreamingGetServerUrlResponse>("streaming.getServerUrl", accessToken, request);
        }
    }
}
