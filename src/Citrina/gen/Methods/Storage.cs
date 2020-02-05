using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Storage : IStorage
    {
        /// <summary>
        /// Returns a value of variable with the name set by key parameter.
        /// </summary>
        public Task<ApiRequest<string>> GetApi(string key = null, IEnumerable<string> keys = null, int? userId = null, bool? global = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
                ["keys"] = RequestHelpers.ParseEnumerable(keys),
                ["user_id"] = userId?.ToString(),
                ["global"] = RequestHelpers.ParseBoolean(global),
            };

            return RequestManager.CreateRequestAsync<string>("storage.get", null, request);
        }

        /// <summary>
        /// Returns a value of variable with the name set by key parameter.
        /// </summary>
        public Task<ApiRequest<IEnumerable<StorageValue>>> GetApi(string key = null, IEnumerable<string> keys = null, int? userId = null, bool? global = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
                ["keys"] = RequestHelpers.ParseEnumerable(keys),
                ["user_id"] = userId?.ToString(),
                ["global"] = RequestHelpers.ParseBoolean(global),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<StorageValue>>("storage.get", null, request);
        }

        /// <summary>
        /// Returns the names of all variables.
        /// </summary>
        public Task<ApiRequest<IEnumerable<string>>> GetKeysApi(int? userId = null, bool? global = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["global"] = RequestHelpers.ParseBoolean(global),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<string>>("storage.getKeys", null, request);
        }

        /// <summary>
        /// Saves a value of variable with the name set by 'key' parameter.
        /// </summary>
        public Task<ApiRequest<bool?>> SetApi(string key = null, string value = null, int? userId = null, bool? global = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
                ["value"] = value,
                ["user_id"] = userId?.ToString(),
                ["global"] = RequestHelpers.ParseBoolean(global),
            };

            return RequestManager.CreateRequestAsync<bool?>("storage.set", null, request);
        }
    }
}
