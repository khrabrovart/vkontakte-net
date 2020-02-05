using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IFriendsApi
    {
        /// <summary>
        /// Approves or creates a friend request.
        /// </summary>
        Task<ApiRequest<int?>> AddApi(int? userId = null, string text = null, bool? follow = null);

        /// <summary>
        /// Creates a new friend list for the current user.
        /// </summary>
        Task<ApiRequest<FriendsAddListResponse>> AddListApi(string name = null, IEnumerable<int> userIds = null);

        /// <summary>
        /// Checks the current user's friendship status with other specified users.
        /// </summary>
        Task<ApiRequest<IEnumerable<FriendsFriendStatus>>> AreFriendsApi(IEnumerable<int> userIds = null, bool? needSign = null);

        /// <summary>
        /// Declines a friend request or deletes a user from the current user's friend list.
        /// </summary>
        Task<ApiRequest<FriendsDeleteResponse>> DeleteApi(int? userId = null);

        /// <summary>
        /// Marks all incoming friend requests as viewed.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAllRequestsApi();

        /// <summary>
        /// Deletes a friend list of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteListApi(int? listId = null);

        /// <summary>
        /// Edits the friend lists of the selected user.
        /// </summary>
        Task<ApiRequest<bool?>> EditApi(int? userId = null, IEnumerable<int> listIds = null);

        /// <summary>
        /// Edits a friend list of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> EditListApi(string name = null, int? listId = null, IEnumerable<int> userIds = null, IEnumerable<int> addUserIds = null, IEnumerable<int> deleteUserIds = null);

        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetResponse>> GetApi(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<UsersFields> fields = null, string nameCase = null, string @ref = null);

        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// </summary>
        Task<ApiRequest<FriendsGetFieldsResponse>> GetApi(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<UsersFields> fields = null, string nameCase = null, string @ref = null);

        /// <summary>
        /// Returns a list of IDs of the current user's friends who installed the application.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> GetAppUsersApi();

        /// <summary>
        /// Returns a list of the current user's friends whose phone numbers, validated or specified in a profile, are in a given list.
        /// </summary>
        Task<ApiRequest<IEnumerable<FriendsUserXtrPhone>>> GetByPhonesApi(IEnumerable<string> phones = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns a list of the user's friend lists.
        /// </summary>
        Task<ApiRequest<FriendsGetListsResponse>> GetListsApi(int? userId = null, bool? returnSystem = null);

        /// <summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> GetMutualApi(int? sourceUid = null, int? targetUid = null, IEnumerable<int> targetUids = null, string order = null, int? count = null, int? offset = null);

        /// <summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        /// </summary>
        Task<ApiRequest<IEnumerable<FriendsMutualFriend>>> GetMutualApi(int? sourceUid = null, int? targetUid = null, IEnumerable<int> targetUids = null, string order = null, int? count = null, int? offset = null);

        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> GetOnlineApi(int? userId = null, int? listId = null, bool? onlineMobile = null, string order = null, int? count = null, int? offset = null);

        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// </summary>
        Task<ApiRequest<FriendsGetOnlineOnlineMobileResponse>> GetOnlineApi(int? userId = null, int? listId = null, bool? onlineMobile = null, string order = null, int? count = null, int? offset = null);

        /// <summary>
        /// Returns a list of user IDs of the current user's recently added friends.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> GetRecentApi(int? count = null);

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        Task<ApiRequest<FriendsGetRequestsResponse>> GetRequestsApi(int? offset = null, int? count = null, bool? extended = null, bool? needMutual = null, bool? @out = null, int? sort = null, bool? needViewed = null, bool? suggested = null, string @ref = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        Task<ApiRequest<FriendsGetRequestsNeedMutualResponse>> GetRequestsApi(int? offset = null, int? count = null, bool? extended = null, bool? needMutual = null, bool? @out = null, int? sort = null, bool? needViewed = null, bool? suggested = null, string @ref = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// </summary>
        Task<ApiRequest<FriendsGetRequestsExtendedResponse>> GetRequestsApi(int? offset = null, int? count = null, bool? extended = null, bool? needMutual = null, bool? @out = null, int? sort = null, bool? needViewed = null, bool? suggested = null, string @ref = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns a list of profiles of users whom the current user may know.
        /// </summary>
        Task<ApiRequest<FriendsGetSuggestionsResponse>> GetSuggestionsApi(IEnumerable<string> filter = null, int? count = null, int? offset = null, IEnumerable<UsersFields> fields = null, string nameCase = null);

        /// <summary>
        /// Returns a list of friends matching the search criteria.
        /// </summary>
        Task<ApiRequest<FriendsSearchResponse>> SearchApi(int? userId = null, string q = null, IEnumerable<UsersFields> fields = null, string nameCase = null, int? offset = null, int? count = null);
    }
}
