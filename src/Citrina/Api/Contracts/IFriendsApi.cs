using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IFriendsApi
    {
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetResponse>> Get(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetResponse>> Get(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetOnline(UserAccessToken accessToken, int? userId = null, int? listId = null, string order = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// </summary>
        Task<ApiRequest<FriendsGetOnlineOnlineMobileResponse>> GetOnlineOnlineMobile(UserAccessToken accessToken, int? userId = null, int? listId = null, bool? onlineMobile = null, string order = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetMutual(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, string order = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        /// </summary>
        Task<ApiRequest<IEnumerable<FriendsMutualFriend>>> GetMutualTargetUids(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, IEnumerable<int?> targetUids = null, string order = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user IDs of the current user's recently added friends.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetRecent(UserAccessToken accessToken, int? count = null);

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        Task<ApiRequest<FriendsGetRequestsResponse>> GetRequests(
            UserAccessToken accessToken,
            int? offset = null,
            int? count = null,
            bool? @out = null,
            int? sort = null,
            bool? needViewed = null,
            bool? suggested = null);

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        Task<ApiRequest<FriendsGetRequestsNeedMutualResponse>> GetRequestsNeedMutual(
            UserAccessToken accessToken,
            int? offset = null,
            int? count = null,
            bool? needMutual = null,
            bool? @out = null,
            int? sort = null,
            bool? needViewed = null,
            bool? suggested = null);

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        Task<ApiRequest<FriendsGetRequestsExtendedResponse>> GetRequestsExtended(
            UserAccessToken accessToken,
            int? offset = null,
            int? count = null,
            bool? extended = null,
            bool? @out = null,
            int? sort = null,
            bool? needViewed = null,
            bool? suggested = null);

        /// <summary>
        /// Approves or creates a friend request.
        /// </summary>
        Task<ApiRequest<int?>> Add(UserAccessToken accessToken, int? userId = null, string text = null, bool? follow = null);
        /// <summary>
        /// Edits the friend lists of the selected user.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? userId = null, IEnumerable<int?> listIds = null);
        /// <summary>
        /// Declines a friend request or deletes a user from the current user's friend list.
        /// </summary>
        Task<ApiRequest<FriendsDeleteResponse>> Delete(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Returns a list of the user's friend lists.
        /// </summary>
        Task<ApiRequest<FriendsGetListsResponse>> GetLists(UserAccessToken accessToken, int? userId = null, bool? returnSystem = null);
        /// <summary>
        /// Creates a new friend list for the current user.
        /// </summary>
        Task<ApiRequest<FriendsAddListResponse>> AddList(UserAccessToken accessToken, string name = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Edits a friend list of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> EditList(UserAccessToken accessToken, string name = null, int? listId = null, IEnumerable<int?> userIds = null, IEnumerable<int?> addUserIds = null, IEnumerable<int?> deleteUserIds = null);
        /// <summary>
        /// Deletes a friend list of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteList(UserAccessToken accessToken, int? listId = null);
        /// <summary>
        /// Returns a list of IDs of the current user's friends who installed the application.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> GetAppUsers(UserAccessToken accessToken);
        /// <summary>
        /// Returns a list of the current user's friends whose phone numbers, validated or specified in a profile, are in a given list.
        /// </summary>
        Task<ApiRequest<IEnumerable<FriendsUserXtrPhone>>> GetByPhones(UserAccessToken accessToken, IEnumerable<string> phones = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Marks all incoming friend requests as viewed.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAllRequests(UserAccessToken accessToken);
        /// <summary>
        /// Returns a list of profiles of users whom the current user may know.
        /// </summary>
        Task<ApiRequest<FriendsGetSuggestionsResponse>> GetSuggestions(UserAccessToken accessToken, IEnumerable<string> filter = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Checks the current user's friendship status with other specified users.
        /// </summary>
        Task<ApiRequest<IEnumerable<FriendsFriendStatus>>> AreFriends(UserAccessToken accessToken, IEnumerable<int?> userIds = null, bool? needSign = null);
        /// <summary>
        /// Returns a list of friends who can be called by the current user.
        /// </summary>
        Task<ApiRequest<FriendsGetAvailableForCallResponse>> GetAvailableForCall(UserAccessToken accessToken, string nameCase = null);
        /// <summary>
        /// Returns a list of friends who can be called by the current user.
        /// </summary>
        Task<ApiRequest<FriendsGetAvailableForCallFieldsResponse>> GetAvailableForCallFields(UserAccessToken accessToken, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of friends matching the search criteria.
        /// </summary>
        Task<ApiRequest<FriendsSearchResponse>> Search(UserAccessToken accessToken, int? userId = null, string q = null, IEnumerable<string> fields = null, string nameCase = null, int? offset = null, int? count = null);
    }
}
