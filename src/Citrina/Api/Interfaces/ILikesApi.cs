using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface ILikesApi
    {
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListResponse>> GetList(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListResponse>> GetList(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListResponse>> GetList(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null);
        /// <summary>
        /// Adds the specified object to the 'Likes' list of the current user.
        /// </summary>
        Task<ApiRequest<LikesAddResponse>> Add(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string accessKey = null);
        /// <summary>
        /// Deletes the specified object from the 'Likes' list of the current user.
        /// </summary>
        Task<ApiRequest<LikesDeleteResponse>> Delete(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Checks for the object in the 'Likes' list of the specified user.
        /// </summary>
        Task<ApiRequest<LikesIsLikedResponse>> IsLiked(UserAccessToken accessToken, int? userId = null, string type = null, int? ownerId = null, int? itemId = null);
    }
}
