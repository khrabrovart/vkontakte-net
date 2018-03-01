using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class LikesApi : ILikesApi
    {
        public Task<ApiRequest<LikesGetListResponse>> GetList(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", accessToken, request);
        }

        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", accessToken, request);
        }

        public Task<ApiRequest<LikesGetListResponse>> GetList(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", null, request);
        }

        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", null, request);
        }

        public Task<ApiRequest<LikesGetListResponse>> GetList(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", accessToken, request);
        }

        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", accessToken, request);
        }

        public Task<ApiRequest<LikesAddResponse>> Add(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<LikesAddResponse>("likes.add", accessToken, request);
        }

        public Task<ApiRequest<LikesDeleteResponse>> Delete(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<LikesDeleteResponse>("likes.delete", accessToken, request);
        }

        public Task<ApiRequest<LikesIsLikedResponse>> IsLiked(UserAccessToken accessToken, int? userId = null, string type = null, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<LikesIsLikedResponse>("likes.isLiked", accessToken, request);
        }

    }
}
