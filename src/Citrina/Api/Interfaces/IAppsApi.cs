using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IAppsApi
    {
        /// <summary>
        /// Returns a list of applications (apps) available to users in the App Catalog.
        /// </summary>
        Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null);
        /// <summary>
        /// Returns a list of applications (apps) available to users in the App Catalog.
        /// </summary>
        Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null);
        /// <summary>
        /// Returns a list of applications (apps) available to users in the App Catalog.
        /// </summary>
        Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null);
        /// <summary>
        /// Returns applications data.
        /// </summary>
        Task<ApiRequest<AppsGetResponse>> Get(UserAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns applications data.
        /// </summary>
        Task<ApiRequest<AppsGetResponse>> Get(int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns applications data.
        /// </summary>
        Task<ApiRequest<AppsGetResponse>> Get(ServiceAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Sends a request to another user in an app that uses VK authorization.
        /// </summary>
        Task<ApiRequest<int?>> SendRequest(UserAccessToken accessToken, int? userId = null, string text = null, string type = null, string name = null, string key = null, bool? separate = null);
        /// <summary>
        /// Deletes all request notifications from the current app.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAppRequests(UserAccessToken accessToken);
        /// <summary>
        /// Creates friends list for requests and invites in current app.
        /// </summary>
        Task<ApiRequest<AppsGetFriendsListResponse>> GetFriendsList(UserAccessToken accessToken, int? count = null, string type = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns players rating in the game.
        /// </summary>
        Task<ApiRequest<AppsGetLeaderboardResponse>> GetLeaderboard(UserAccessToken accessToken, string type = null, bool? global = null);
        /// <summary>
        /// Returns players rating in the game.
        /// </summary>
        Task<ApiRequest<AppsGetLeaderboardExtendedResponse>> GetLeaderboardExtended(UserAccessToken accessToken, string type = null, bool? global = null, bool? extended = null);
        /// <summary>
        /// Returns user score in app
        /// </summary>
        Task<ApiRequest<int?>> GetScore(UserAccessToken accessToken, int? userId = null);
    }
}
