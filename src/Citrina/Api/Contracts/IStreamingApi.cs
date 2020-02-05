using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IStreamingApi
    {
        /// <summary>
        /// Allows to receive data for the connection to Streaming API.
        /// </summary>
        Task<ApiRequest<StreamingGetServerUrlResponse>> GetServerUrl(ServiceAccessToken accessToken);
    }
}
