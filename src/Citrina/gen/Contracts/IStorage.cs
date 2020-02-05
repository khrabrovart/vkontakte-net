using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IStorageApi
    {
        /// <summary>
        /// Returns a value of variable with the name set by key parameter.
        /// </summary>
        Task<ApiRequest<string>> GetApi(string key = null, IEnumerable<string> keys = null, int? userId = null, bool? global = null);

        /// <summary>
        /// Returns a value of variable with the name set by key parameter.
        /// </summary>
        Task<ApiRequest<IEnumerable<StorageValue>>> GetApi(string key = null, IEnumerable<string> keys = null, int? userId = null, bool? global = null);

        /// <summary>
        /// Returns the names of all variables.
        /// </summary>
        Task<ApiRequest<IEnumerable<string>>> GetKeysApi(int? userId = null, bool? global = null, int? offset = null, int? count = null);

        /// <summary>
        /// Saves a value of variable with the name set by 'key' parameter.
        /// </summary>
        Task<ApiRequest<bool?>> SetApi(string key = null, string value = null, int? userId = null, bool? global = null);
    }
}
