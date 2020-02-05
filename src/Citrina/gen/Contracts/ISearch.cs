using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface ISearchApi
    {
        /// <summary>
        /// Allows the programmer to do a quick search for any substring.
        /// </summary>
        Task<ApiRequest<SearchGetHintsResponse>> GetHintsApi(string q = null, int? offset = null, int? limit = null, IEnumerable<string> filters = null, IEnumerable<string> fields = null, bool? searchGlobal = null);
    }
}
