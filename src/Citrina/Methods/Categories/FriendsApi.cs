using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class FriendsApi : IFriendsApi
    {
        public Task<ApiRequest<FriendsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetResponse>> Get(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", null, request);
        }

        public Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", null, request);
        }

        public Task<ApiRequest<FriendsGetResponse>> Get(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetOnline(UserAccessToken accessToken, int? userId = null, int? listId = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["list_id"] = listId?.ToString(),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getOnline", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetOnlineOnlineMobileResponse>> GetOnlineOnlineMobile(UserAccessToken accessToken, int? userId = null, int? listId = null, bool? onlineMobile = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["list_id"] = listId?.ToString(),
                ["online_mobile"] = RequestHelpers.ParseBoolean(onlineMobile),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FriendsGetOnlineOnlineMobileResponse>("friends.getOnline", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetMutual(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["source_uid"] = sourceUid?.ToString(),
                ["target_uid"] = targetUid?.ToString(),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getMutual", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<FriendsMutualFriend>>> GetMutualTargetUids(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, IEnumerable<int?> targetUids = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["source_uid"] = sourceUid?.ToString(),
                ["target_uid"] = targetUid?.ToString(),
                ["target_uids"] = RequestHelpers.ParseEnumerable(targetUids),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<FriendsMutualFriend>>("friends.getMutual", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetRecent(UserAccessToken accessToken, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getRecent", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetRequestsResponse>> GetRequests(
            UserAccessToken accessToken,
            int? offset,
            int? count,
            bool? @out,
            int? sort,
            bool? needViewed,
            bool? suggested)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["out"] = RequestHelpers.ParseBoolean(@out),
                ["sort"] = sort?.ToString(),
                ["need_viewed"] = RequestHelpers.ParseBoolean(needViewed),
                ["suggested"] = RequestHelpers.ParseBoolean(suggested),
            };

            return RequestManager.CreateRequestAsync<FriendsGetRequestsResponse>("friends.getRequests", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetRequestsNeedMutualResponse>> GetRequestsNeedMutual(
            UserAccessToken accessToken,
            int? offset,
            int? count,
            bool? needMutual,
            bool? @out,
            int? sort,
            bool? needViewed,
            bool? suggested)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["need_mutual"] = RequestHelpers.ParseBoolean(needMutual),
                ["out"] = RequestHelpers.ParseBoolean(@out),
                ["sort"] = sort?.ToString(),
                ["need_viewed"] = RequestHelpers.ParseBoolean(needViewed),
                ["suggested"] = RequestHelpers.ParseBoolean(suggested),
            };

            return RequestManager.CreateRequestAsync<FriendsGetRequestsNeedMutualResponse>("friends.getRequests", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetRequestsExtendedResponse>> GetRequestsExtended(
            UserAccessToken accessToken,
            int? offset,
            int? count,
            bool? extended,
            bool? @out,
            int? sort,
            bool? needViewed,
            bool? suggested)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["out"] = RequestHelpers.ParseBoolean(@out),
                ["sort"] = sort?.ToString(),
                ["need_viewed"] = RequestHelpers.ParseBoolean(needViewed),
                ["suggested"] = RequestHelpers.ParseBoolean(suggested),
            };

            return RequestManager.CreateRequestAsync<FriendsGetRequestsExtendedResponse>("friends.getRequests", accessToken, request);
        }

        public Task<ApiRequest<int?>> Add(UserAccessToken accessToken, int? userId = null, string text = null, bool? follow = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["text"] = text,
                ["follow"] = RequestHelpers.ParseBoolean(follow),
            };

            return RequestManager.CreateRequestAsync<int?>("friends.add", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? userId = null, IEnumerable<int?> listIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["list_ids"] = RequestHelpers.ParseEnumerable(listIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.edit", accessToken, request);
        }

        public Task<ApiRequest<FriendsDeleteResponse>> Delete(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FriendsDeleteResponse>("friends.delete", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetListsResponse>> GetLists(UserAccessToken accessToken, int? userId = null, bool? returnSystem = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["return_system"] = RequestHelpers.ParseBoolean(returnSystem),
            };

            return RequestManager.CreateRequestAsync<FriendsGetListsResponse>("friends.getLists", accessToken, request);
        }

        public Task<ApiRequest<FriendsAddListResponse>> AddList(UserAccessToken accessToken, string name = null, IEnumerable<int?> userIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["name"] = name,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<FriendsAddListResponse>("friends.addList", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditList(UserAccessToken accessToken, string name = null, int? listId = null, IEnumerable<int?> userIds = null, IEnumerable<int?> addUserIds = null, IEnumerable<int?> deleteUserIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["name"] = name,
                ["list_id"] = listId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["add_user_ids"] = RequestHelpers.ParseEnumerable(addUserIds),
                ["delete_user_ids"] = RequestHelpers.ParseEnumerable(deleteUserIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.editList", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteList(UserAccessToken accessToken, int? listId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["list_id"] = listId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.deleteList", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetAppUsers(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getAppUsers", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<FriendsUserXtrPhone>>> GetByPhones(UserAccessToken accessToken, IEnumerable<string> phones = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["phones"] = RequestHelpers.ParseEnumerable(phones),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<FriendsUserXtrPhone>>("friends.getByPhones", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAllRequests(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.deleteAllRequests", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetSuggestionsResponse>> GetSuggestions(UserAccessToken accessToken, IEnumerable<string> filter = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["filter"] = RequestHelpers.ParseEnumerable(filter),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetSuggestionsResponse>("friends.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<FriendsFriendStatus>>> AreFriends(UserAccessToken accessToken, IEnumerable<int?> userIds = null, bool? needSign = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["need_sign"] = RequestHelpers.ParseBoolean(needSign),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<FriendsFriendStatus>>("friends.areFriends", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetAvailableForCallResponse>> GetAvailableForCall(UserAccessToken accessToken, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetAvailableForCallResponse>("friends.getAvailableForCall", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetAvailableForCallFieldsResponse>> GetAvailableForCallFields(UserAccessToken accessToken, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetAvailableForCallFieldsResponse>("friends.getAvailableForCall", accessToken, request);
        }

        public Task<ApiRequest<FriendsSearchResponse>> Search(UserAccessToken accessToken, int? userId = null, string q = null, IEnumerable<string> fields = null, string nameCase = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["q"] = q,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FriendsSearchResponse>("friends.search", accessToken, request);
        }
    }
}