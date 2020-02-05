using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Apps : IApps
    {
        /// <summary>
        /// Deletes all request notifications from the current app.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteAppRequestsApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<bool?>("apps.deleteAppRequests", null, request);
        }

        /// <summary>
        /// Returns applications data.
        /// </summary>
        public Task<ApiRequest<AppsGetResponse>> GetApi(int? appId = null, IEnumerable<string> appIds = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<UsersFields> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["app_id"] = appId?.ToString(),
                ["app_ids"] = RequestHelpers.ParseEnumerable(appIds),
                ["platform"] = platform,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["return_friends"] = RequestHelpers.ParseBoolean(returnFriends),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", null, request);
        }

        /// <summary>
        /// Returns a list of applications (apps) available to users in the App Catalog.
        /// </summary>
        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalogApi(string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<UsersFields> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["platform"] = platform,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["return_friends"] = RequestHelpers.ParseBoolean(returnFriends),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
                ["q"] = q,
                ["genre_id"] = genreId?.ToString(),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<AppsGetCatalogResponse>("apps.getCatalog", null, request);
        }

        /// <summary>
        /// Creates friends list for requests and invites in current app.
        /// </summary>
        public Task<ApiRequest<AppsGetFriendsListResponse>> GetFriendsListApi(bool? extended = null, int? count = null, int? offset = null, string type = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["type"] = type,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<AppsGetFriendsListResponse>("apps.getFriendsList", null, request);
        }

        /// <summary>
        /// Returns players rating in the game.
        /// </summary>
        public Task<ApiRequest<AppsGetLeaderboardResponse>> GetLeaderboardApi(string type = null, bool? global = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["global"] = RequestHelpers.ParseBoolean(global),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<AppsGetLeaderboardResponse>("apps.getLeaderboard", null, request);
        }

        /// <summary>
        /// Returns players rating in the game.
        /// </summary>
        public Task<ApiRequest<AppsGetLeaderboardExtendedResponse>> GetLeaderboardApi(string type = null, bool? global = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["global"] = RequestHelpers.ParseBoolean(global),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<AppsGetLeaderboardExtendedResponse>("apps.getLeaderboard", null, request);
        }

        /// <summary>
        /// Returns scopes for auth.
        /// </summary>
        public Task<ApiRequest<AppsGetScopesResponse>> GetScopesApi(string type = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
            };

            return RequestManager.CreateRequestAsync<AppsGetScopesResponse>("apps.getScopes", null, request);
        }

        /// <summary>
        /// Returns user score in app.
        /// </summary>
        public Task<ApiRequest<int?>> GetScoreApi(int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("apps.getScore", null, request);
        }

        /// <summary>
        /// Sends a request to another user in an app that uses VK authorization.
        /// </summary>
        public Task<ApiRequest<int?>> SendRequestApi(int? userId = null, string text = null, string type = null, string name = null, string key = null, bool? separate = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["text"] = text,
                ["type"] = type,
                ["name"] = name,
                ["key"] = key,
                ["separate"] = RequestHelpers.ParseBoolean(separate),
            };

            return RequestManager.CreateRequestAsync<int?>("apps.sendRequest", null, request);
        }
    }
}
