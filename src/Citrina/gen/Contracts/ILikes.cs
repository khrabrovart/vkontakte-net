using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface ILikesApi
    {
        /// <summary>
        /// Adds the specified object to the 'Likes' list of the current user.
        /// </summary>
        Task<ApiRequest<LikesAddResponse>> AddApi(string type = null, int? ownerId = null, int? itemId = null, string accessKey = null);

        /// <summary>
        /// Deletes the specified object from the 'Likes' list of the current user.
        /// </summary>
        Task<ApiRequest<LikesDeleteResponse>> DeleteApi(string type = null, int? ownerId = null, int? itemId = null);

        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListResponse>> GetListApi(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, int? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null);

        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        Task<ApiRequest<LikesGetListExtendedResponse>> GetListApi(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, int? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null);

        /// <summary>
        /// Checks for the object in the 'Likes' list of the specified user.
        /// </summary>
        Task<ApiRequest<LikesIsLikedResponse>> IsLikedApi(int? userId = null, string type = null, int? ownerId = null, int? itemId = null);
    }
}
