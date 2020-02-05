using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class AppsApi : IAppsApi
    {
        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
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

            return RequestManager.CreateRequestAsync<AppsGetCatalogResponse>("apps.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
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

        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
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

            return RequestManager.CreateRequestAsync<AppsGetCatalogResponse>("apps.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<AppsGetResponse>> Get(UserAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken.Value,
                ["app_id"] = appId?.ToString(),
                ["app_ids"] = RequestHelpers.ParseEnumerable(appIds),
                ["platform"] = platform,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", accessToken, request);
        }

        public Task<ApiRequest<AppsGetResponse>> Get(int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["app_id"] = appId?.ToString(),
                ["app_ids"] = RequestHelpers.ParseEnumerable(appIds),
                ["platform"] = platform,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", null, request);
        }

        public Task<ApiRequest<AppsGetResponse>> Get(ServiceAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["app_id"] = appId?.ToString(),
                ["app_ids"] = RequestHelpers.ParseEnumerable(appIds),
                ["platform"] = platform,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", accessToken, request);
        }

        public Task<ApiRequest<int?>> SendRequest(UserAccessToken accessToken, int? userId = null, string text = null, string type = null, string name = null, string key = null, bool? separate = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["text"] = text,
                ["type"] = type,
                ["name"] = name,
                ["key"] = key,
                ["separate"] = RequestHelpers.ParseBoolean(separate),
            };

            return RequestManager.CreateRequestAsync<int?>("apps.sendRequest", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAppRequests(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<bool?>("apps.deleteAppRequests", accessToken, request);
        }

        public Task<ApiRequest<AppsGetFriendsListResponse>> GetFriendsList(UserAccessToken accessToken, int? count = null, string type = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["type"] = type,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<AppsGetFriendsListResponse>("apps.getFriendsList", accessToken, request);
        }

        public Task<ApiRequest<AppsGetLeaderboardResponse>> GetLeaderboard(UserAccessToken accessToken, string type = null, bool? global = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["global"] = RequestHelpers.ParseBoolean(global),
            };

            return RequestManager.CreateRequestAsync<AppsGetLeaderboardResponse>("apps.getLeaderboard", accessToken, request);
        }

        public Task<ApiRequest<AppsGetLeaderboardExtendedResponse>> GetLeaderboardExtended(UserAccessToken accessToken, string type = null, bool? global = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["global"] = RequestHelpers.ParseBoolean(global),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<AppsGetLeaderboardExtendedResponse>("apps.getLeaderboard", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetScore(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("apps.getScore", accessToken, request);
        }

    }
}
