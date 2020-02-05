using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IStorageApi
    {
        /// <summary>
        /// Returns a value of variable with the name set by key parameter.
        /// </summary>
        Task<ApiRequest<string>> Get(UserAccessToken accessToken, string key = null, IEnumerable<string> keys = null, int? userId = null);
        /// <summary>
        /// Saves a value of variable with the name set by 'key' parameter.
        /// </summary>
        Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string key = null, string value = null, int? userId = null);
        /// <summary>
        /// Returns the names of all variables.
        /// </summary>
        Task<ApiRequest<IEnumerable<string>>> GetKeys(UserAccessToken accessToken, int? userId = null, int? count = null);
    }
}
