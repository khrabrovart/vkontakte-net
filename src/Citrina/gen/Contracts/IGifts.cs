using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IGiftsApi
    {
        /// <summary>
        /// Returns a list of user gifts.
        /// </summary>
        Task<ApiRequest<GiftsGetResponse>> GetApi(int? userId = null, int? count = null, int? offset = null);
    }
}
