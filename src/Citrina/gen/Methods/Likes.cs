using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Likes : ILikes
    {
        /// <summary>
        /// Adds the specified object to the 'Likes' list of the current user.
        /// </summary>
        public Task<ApiRequest<LikesAddResponse>> AddApi(string type = null, int? ownerId = null, int? itemId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<LikesAddResponse>("likes.add", null, request);
        }

        /// <summary>
        /// Deletes the specified object from the 'Likes' list of the current user.
        /// </summary>
        public Task<ApiRequest<LikesDeleteResponse>> DeleteApi(string type = null, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<LikesDeleteResponse>("likes.delete", null, request);
        }

        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        public Task<ApiRequest<LikesGetListResponse>> GetListApi(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, int? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = friendsOnly?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", null, request);
        }

        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// </summary>
        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListApi(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, int? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = friendsOnly?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", null, request);
        }

        /// <summary>
        /// Checks for the object in the 'Likes' list of the specified user.
        /// </summary>
        public Task<ApiRequest<LikesIsLikedResponse>> IsLikedApi(int? userId = null, string type = null, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<LikesIsLikedResponse>("likes.isLiked", null, request);
        }
    }
}
