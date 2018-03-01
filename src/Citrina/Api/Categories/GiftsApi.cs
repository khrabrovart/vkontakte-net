using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class GiftsApi : IGiftsApi
    {
        public Task<ApiRequest<GiftsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GiftsGetResponse>("gifts.get", accessToken, request);
        }

    }
}
