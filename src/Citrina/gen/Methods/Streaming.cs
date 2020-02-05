using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Streaming : IStreaming
    {
        /// <summary>
        /// Allows to receive data for the connection to Streaming API.
        /// </summary>
        public Task<ApiRequest<StreamingGetServerUrlResponse>> GetServerUrlApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<StreamingGetServerUrlResponse>("streaming.getServerUrl", null, request);
        }

        public Task<ApiRequest<bool?>> SetSettingsApi(string monthlyTier = null)
        {
            var request = new Dictionary<string, string>
            {
                ["monthly_tier"] = monthlyTier,
            };

            return RequestManager.CreateRequestAsync<bool?>("streaming.setSettings", null, request);
        }
    }
}
