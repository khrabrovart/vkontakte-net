using System.Threading.Tasks;

namespace Citrina
{
    public interface IFaveApi
    {
        /// <summary>
        /// Returns a list of users whom the current user has bookmarked.
        /// </summary>
        Task<ApiRequest<FaveGetUsersResponse>> GetUsers(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of photos that the current user has liked.
        /// </summary>
        Task<ApiRequest<FaveGetPhotosResponse>> GetPhotos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? photoSizes = null);
        /// <summary>
        /// Returns a list of wall posts that the current user has liked.
        /// </summary>
        Task<ApiRequest<FaveGetPostsResponse>> GetPosts(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a list of videos that the current user has liked.
        /// </summary>
        Task<ApiRequest<FaveGetVideosResponse>> GetVideos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a list of links that the current user has bookmarked.
        /// </summary>
        Task<ApiRequest<FaveGetLinksResponse>> GetLinks(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Returns market items bookmarked by current user.
        /// </summary>
        Task<ApiRequest<FaveGetMarketItemsResponse>> GetMarketItems(UserAccessToken accessToken, int? count = null, bool? extended = null);
        /// <summary>
        /// Adds a profile to user faves.
        /// </summary>
        Task<ApiRequest<bool?>> AddUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Removes a profile from user faves.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Adds a community to user faves.
        /// </summary>
        Task<ApiRequest<bool?>> AddGroup(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Removes a community from user faves.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveGroup(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Adds a link to user faves.
        /// </summary>
        Task<ApiRequest<bool?>> AddLink(UserAccessToken accessToken, string link = null, string text = null);
        /// <summary>
        /// Removes link from the user's faves.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveLink(UserAccessToken accessToken, string linkId = null);
    }
}
