using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
    internal class StorageApi : IStorageApi
    {
        public Task<ApiRequest<string>> Get(UserAccessToken accessToken, string key = null, IEnumerable<string> keys = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["keys"] = RequestHelpers.ParseEnumerable(keys),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<string>("storage.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string key = null, string value = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["value"] = value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("storage.set", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<string>>> GetKeys(UserAccessToken accessToken, int? userId = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<string>>("storage.getKeys", accessToken, request);
        }

    }
}
