using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
    internal class FaveApi : IFaveApi
    {
        public Task<ApiRequest<FaveGetUsersResponse>> GetUsers(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FaveGetUsersResponse>("fave.getUsers", accessToken, request);
        }

        public Task<ApiRequest<FaveGetPhotosResponse>> GetPhotos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<FaveGetPhotosResponse>("fave.getPhotos", accessToken, request);
        }

        public Task<ApiRequest<FaveGetPostsResponse>> GetPosts(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<FaveGetPostsResponse>("fave.getPosts", accessToken, request);
        }

        public Task<ApiRequest<FaveGetVideosResponse>> GetVideos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<FaveGetVideosResponse>("fave.getVideos", accessToken, request);
        }

        public Task<ApiRequest<FaveGetLinksResponse>> GetLinks(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FaveGetLinksResponse>("fave.getLinks", accessToken, request);
        }

        public Task<ApiRequest<FaveGetMarketItemsResponse>> GetMarketItems(UserAccessToken accessToken, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<FaveGetMarketItemsResponse>("fave.getMarketItems", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddUser(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addUser", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveUser(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeUser", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddGroup(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveGroup(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddLink(UserAccessToken accessToken, string link = null, string text = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["link"] = link,
                ["text"] = text,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addLink", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveLink(UserAccessToken accessToken, string linkId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["link_id"] = linkId,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeLink", accessToken, request);
        }

    }
}
