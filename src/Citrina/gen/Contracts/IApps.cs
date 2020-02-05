using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IAppsApi
    {
        /// <summary>
        /// Deletes all request notifications from the current app.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAppRequestsApi();

        /// <summary>
        /// Returns applications data.
        /// </summary>
        Task<ApiRequest<AppsGetResponse>> GetApi(int? appId = null, IEnumerable<string> appIds = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<UsersFields> fields = null, string nameCase = null);

        /// <summary>
        /// Returns a list of applications (apps) available to users in the App Catalog.
        /// </summary>
        Task<ApiRequest<AppsGetCatalogResponse>> GetCatalogApi(string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<UsersFields> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null);

        /// <summary>
        /// Creates friends list for requests and invites in current app.
        /// </summary>
        Task<ApiRequest<AppsGetFriendsListResponse>> GetFriendsListApi(bool? extended = null, int? count = null, int? offset = null, string type = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns players rating in the game.
        /// </summary>
        Task<ApiRequest<AppsGetLeaderboardResponse>> GetLeaderboardApi(string type = null, bool? global = null, bool? extended = null);

        /// <summary>
        /// Returns players rating in the game.
        /// </summary>
        Task<ApiRequest<AppsGetLeaderboardExtendedResponse>> GetLeaderboardApi(string type = null, bool? global = null, bool? extended = null);

        /// <summary>
        /// Returns scopes for auth.
        /// </summary>
        Task<ApiRequest<AppsGetScopesResponse>> GetScopesApi(string type = null);

        /// <summary>
        /// Returns user score in app.
        /// </summary>
        Task<ApiRequest<int?>> GetScoreApi(int? userId = null);

        /// <summary>
        /// Sends a request to another user in an app that uses VK authorization.
        /// </summary>
        Task<ApiRequest<int?>> SendRequestApi(int? userId = null, string text = null, string type = null, string name = null, string key = null, bool? separate = null);
    }
}
