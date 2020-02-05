using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IStreamingApi
    {
        /// <summary>
        /// Allows to receive data for the connection to Streaming API.
        /// </summary>
        Task<ApiRequest<StreamingGetServerUrlResponse>> GetServerUrlApi();

        Task<ApiRequest<bool?>> SetSettingsApi(string monthlyTier = null);
    }
}
