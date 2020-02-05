using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Gifts : IGifts
    {
        /// <summary>
        /// Returns a list of user gifts.
        /// </summary>
        public Task<ApiRequest<GiftsGetResponse>> GetApi(int? userId = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GiftsGetResponse>("gifts.get", null, request);
        }
    }
}
