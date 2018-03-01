using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IGiftsApi
    {
        /// <summary>
        /// Returns a list of user gifts.
        /// </summary>
        Task<ApiRequest<GiftsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, int? count = null, int? offset = null);
    }
}
