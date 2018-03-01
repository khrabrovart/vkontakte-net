using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class SearchApi : ISearchApi
    {
        public Task<ApiRequest<IEnumerable<SearchHint>>> GetHints(
            UserAccessToken accessToken,
            string q,
            int? offset,
            int? limit,
            IEnumerable<string> filters,
            IEnumerable<string> fields,
            bool? searchGlobal)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["offset"] = offset?.ToString(),
                ["limit"] = limit?.ToString(),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["search_global"] = RequestHelpers.ParseBoolean(searchGlobal),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SearchHint>>("search.getHints", accessToken, request);
        }
    }
}
