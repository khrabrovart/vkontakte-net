using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface ISearchApi
    {
        /// <summary>
        /// Allows the programmer to do a quick search for any substring.
        /// </summary>
        Task<ApiRequest<IEnumerable<SearchHint>>> GetHints(
            UserAccessToken accessToken,
            string q = null,
            int? offset = null,
            int? limit = null,
            IEnumerable<string> filters = null,
            IEnumerable<string> fields = null,
            bool? searchGlobal = null);
    }
}
