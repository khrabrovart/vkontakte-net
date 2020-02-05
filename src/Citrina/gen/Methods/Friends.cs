using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Friends : IFriends
    {
        /// <summary>
        /// Approves or creates a friend request.
        /// </summary>
        public Task<ApiRequest<int?>> AddApi(int? userId = null, string text = null, bool? follow = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["text"] = text,
                ["follow"] = RequestHelpers.ParseBoolean(follow),
            };

            return RequestManager.CreateRequestAsync<int?>("friends.add", null, request);
        }

        /// <summary>
        /// Creates a new friend list for the current user.
        /// </summary>
        public Task<ApiRequest<FriendsAddListResponse>> AddListApi(string name = null, IEnumerable<int> userIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["name"] = name,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<FriendsAddListResponse>("friends.addList", null, request);
        }

        /// <summary>
        /// Checks the current user's friendship status with other specified users.
        /// </summary>
        public Task<ApiRequest<IEnumerable<FriendsFriendStatus>>> AreFriendsApi(IEnumerable<int> userIds = null, bool? needSign = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["need_sign"] = RequestHelpers.ParseBoolean(needSign),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<FriendsFriendStatus>>("friends.areFriends", null, request);
        }

        /// <summary>
        /// Declines a friend request or deletes a user from the current user's friend list.
        /// </summary>
        public Task<ApiRequest<FriendsDeleteResponse>> DeleteApi(int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FriendsDeleteResponse>("friends.delete", null, request);
        }

        /// <summary>
        /// Marks all incoming friend requests as viewed.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteAllRequestsApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.deleteAllRequests", null, request);
        }

        /// <summary>
        /// Deletes a friend list of the current user.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteListApi(int? listId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["list_id"] = listId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.deleteList", null, request);
        }

        /// <summary>
        /// Edits the friend lists of the selected user.
        /// </summary>
        public Task<ApiRequest<bool?>> EditApi(int? userId = null, IEnumerable<int> listIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["list_ids"] = RequestHelpers.ParseEnumerable(listIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.edit", null, request);
        }

        /// <summary>
        /// Edits a friend list of the current user.
        /// </summary>
        public Task<ApiRequest<bool?>> EditListApi(string name = null, int? listId = null, IEnumerable<int> userIds = null, IEnumerable<int> addUserIds = null, IEnumerable<int> deleteUserIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["name"] = name,
                ["list_id"] = listId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["add_user_ids"] = RequestHelpers.ParseEnumerable(addUserIds),
                ["delete_user_ids"] = RequestHelpers.ParseEnumerable(deleteUserIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.editList", null, request);
        }

        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        public Task<ApiRequest<FriendsGetResponse>> GetApi(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<UsersFields> fields = null, string nameCase = null, string @ref = null)
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
                ["ref"] = @ref,
            };

            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", null, request);
        }

        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        public Task<ApiRequest<FriendsGetFieldsResponse>> GetApi(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<UsersFields> fields = null, string nameCase = null, string @ref = null)
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
                ["ref"] = @ref,
            };

            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", null, request);
        }

        /// <summary>
        /// Returns a list of IDs of the current user's friends who installed the application.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> GetAppUsersApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("friends.getAppUsers", null, request);
        }

        /// <summary>
        /// Returns a list of the current user's friends whose phone numbers, validated or specified in a profile, are in a given list.
        /// </summary>
        public Task<ApiRequest<IEnumerable<FriendsUserXtrPhone>>> GetByPhonesApi(IEnumerable<string> phones = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["phones"] = RequestHelpers.ParseEnumerable(phones),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<FriendsUserXtrPhone>>("friends.getByPhones", null, request);
        }

        /// <summary>
        /// Returns a list of the user's friend lists.
        /// </summary>
        public Task<ApiRequest<FriendsGetListsResponse>> GetListsApi(int? userId = null, bool? returnSystem = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["return_system"] = RequestHelpers.ParseBoolean(returnSystem),
            };

            return RequestManager.CreateRequestAsync<FriendsGetListsResponse>("friends.getLists", null, request);
        }

        /// <summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> GetMutualApi(int? sourceUid = null, int? targetUid = null, IEnumerable<int> targetUids = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["source_uid"] = sourceUid?.ToString(),
                ["target_uid"] = targetUid?.ToString(),
                ["target_uids"] = RequestHelpers.ParseEnumerable(targetUids),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("friends.getMutual", null, request);
        }

        /// <summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        /// </summary>
        public Task<ApiRequest<IEnumerable<FriendsMutualFriend>>> GetMutualApi(int? sourceUid = null, int? targetUid = null, IEnumerable<int> targetUids = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["source_uid"] = sourceUid?.ToString(),
                ["target_uid"] = targetUid?.ToString(),
                ["target_uids"] = RequestHelpers.ParseEnumerable(targetUids),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<FriendsMutualFriend>>("friends.getMutual", null, request);
        }

        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> GetOnlineApi(int? userId = null, int? listId = null, bool? onlineMobile = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["list_id"] = listId?.ToString(),
                ["online_mobile"] = RequestHelpers.ParseBoolean(onlineMobile),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("friends.getOnline", null, request);
        }

        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// </summary>
        public Task<ApiRequest<FriendsGetOnlineOnlineMobileResponse>> GetOnlineApi(int? userId = null, int? listId = null, bool? onlineMobile = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["list_id"] = listId?.ToString(),
                ["online_mobile"] = RequestHelpers.ParseBoolean(onlineMobile),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FriendsGetOnlineOnlineMobileResponse>("friends.getOnline", null, request);
        }

        /// <summary>
        /// Returns a list of user IDs of the current user's recently added friends.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> GetRecentApi(int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("friends.getRecent", null, request);
        }

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        public Task<ApiRequest<FriendsGetRequestsResponse>> GetRequestsApi(int? offset = null, int? count = null, bool? extended = null, bool? needMutual = null, bool? @out = null, int? sort = null, bool? needViewed = null, bool? suggested = null, string @ref = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["need_mutual"] = RequestHelpers.ParseBoolean(needMutual),
                ["out"] = RequestHelpers.ParseBoolean(@out),
                ["sort"] = sort?.ToString(),
                ["need_viewed"] = RequestHelpers.ParseBoolean(needViewed),
                ["suggested"] = RequestHelpers.ParseBoolean(suggested),
                ["ref"] = @ref,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<FriendsGetRequestsResponse>("friends.getRequests", null, request);
        }

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        public Task<ApiRequest<FriendsGetRequestsNeedMutualResponse>> GetRequestsApi(int? offset = null, int? count = null, bool? extended = null, bool? needMutual = null, bool? @out = null, int? sort = null, bool? needViewed = null, bool? suggested = null, string @ref = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["need_mutual"] = RequestHelpers.ParseBoolean(needMutual),
                ["out"] = RequestHelpers.ParseBoolean(@out),
                ["sort"] = sort?.ToString(),
                ["need_viewed"] = RequestHelpers.ParseBoolean(needViewed),
                ["suggested"] = RequestHelpers.ParseBoolean(suggested),
                ["ref"] = @ref,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<FriendsGetRequestsNeedMutualResponse>("friends.getRequests", null, request);
        }

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        public Task<ApiRequest<FriendsGetRequestsExtendedResponse>> GetRequestsApi(int? offset = null, int? count = null, bool? extended = null, bool? needMutual = null, bool? @out = null, int? sort = null, bool? needViewed = null, bool? suggested = null, string @ref = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["need_mutual"] = RequestHelpers.ParseBoolean(needMutual),
                ["out"] = RequestHelpers.ParseBoolean(@out),
                ["sort"] = sort?.ToString(),
                ["need_viewed"] = RequestHelpers.ParseBoolean(needViewed),
                ["suggested"] = RequestHelpers.ParseBoolean(suggested),
                ["ref"] = @ref,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<FriendsGetRequestsExtendedResponse>("friends.getRequests", null, request);
        }

        /// <summary>
        /// Returns a list of profiles of users whom the current user may know.
        /// </summary>
        public Task<ApiRequest<FriendsGetSuggestionsResponse>> GetSuggestionsApi(IEnumerable<string> filter = null, int? count = null, int? offset = null, IEnumerable<UsersFields> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["filter"] = RequestHelpers.ParseEnumerable(filter),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetSuggestionsResponse>("friends.getSuggestions", null, request);
        }

        /// <summary>
        /// Returns a list of friends matching the search criteria.
        /// </summary>
        public Task<ApiRequest<FriendsSearchResponse>> SearchApi(int? userId = null, string q = null, IEnumerable<UsersFields> fields = null, string nameCase = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["q"] = q,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FriendsSearchResponse>("friends.search", null, request);
        }
    }
}
