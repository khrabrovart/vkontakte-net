using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Search : ISearch
    {
        /// <summary>
        /// Allows the programmer to do a quick search for any substring.
        /// </summary>
        public Task<ApiRequest<SearchGetHintsResponse>> GetHintsApi(string q = null, int? offset = null, int? limit = null, IEnumerable<string> filters = null, IEnumerable<string> fields = null, bool? searchGlobal = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["offset"] = offset?.ToString(),
                ["limit"] = limit?.ToString(),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["search_global"] = RequestHelpers.ParseBoolean(searchGlobal),
            };

            return RequestManager.CreateRequestAsync<SearchGetHintsResponse>("search.getHints", null, request);
        }
    }
}
