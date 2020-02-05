using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface INewsfeedApi
    {
        /// <summary>
        /// Prevents news from specified users and communities from appearing in the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> AddBanApi(IEnumerable<int> userIds = null, IEnumerable<int> groupIds = null);

        /// <summary>
        /// Allows news from previously banned users and communities to be shown in the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteBanApi(IEnumerable<int> userIds = null, IEnumerable<int> groupIds = null);

        Task<ApiRequest<bool?>> DeleteListApi(int? listId = null);

        /// <summary>
        /// Returns data required to show newsfeed for the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetResponse>> GetApi(IEnumerable<NewsfeedFilters> filters = null, bool? returnBanned = null, int? startTime = null, int? endTime = null, int? maxPhotos = null, string sourceIds = null, string startFrom = null, int? count = null, IEnumerable<BaseUserGroupFields> fields = null, string section = null);

        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<NewsfeedGetBannedResponse>> GetBannedApi(bool? extended = null, IEnumerable<UsersFields> fields = null, string nameCase = null);

        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<NewsfeedGetBannedExtendedResponse>> GetBannedApi(bool? extended = null, IEnumerable<UsersFields> fields = null, string nameCase = null);

        /// <summary>
        /// Returns a list of comments in the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<NewsfeedGetCommentsResponse>> GetCommentsApi(int? count = null, IEnumerable<NewsfeedCommentsFilters> filters = null, string reposts = null, int? startTime = null, int? endTime = null, int? lastCommentsCount = null, string startFrom = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns a list of newsfeeds followed by the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetListsResponse>> GetListsApi(IEnumerable<int> listIds = null, bool? extended = null);

        /// <summary>
        /// Returns a list of newsfeeds followed by the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetListsExtendedResponse>> GetListsApi(IEnumerable<int> listIds = null, bool? extended = null);

        /// <summary>
        /// Returns a list of posts on user walls in which the current user is mentioned.
        /// </summary>
        Task<ApiRequest<NewsfeedGetMentionsResponse>> GetMentionsApi(int? ownerId = null, int? startTime = null, int? endTime = null, int? offset = null, int? count = null);

        /// <summary>
        /// , Returns a list of newsfeeds recommended to the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetRecommendedResponse>> GetRecommendedApi(int? startTime = null, int? endTime = null, int? maxPhotos = null, string startFrom = null, int? count = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns communities and users that current user is suggested to follow.
        /// </summary>
        Task<ApiRequest<NewsfeedGetSuggestedSourcesResponse>> GetSuggestedSourcesApi(int? offset = null, int? count = null, bool? shuffle = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Hides an item from the newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> IgnoreItemApi(string type = null, int? ownerId = null, int? itemId = null);

        /// <summary>
        /// Creates and edits user newsfeed lists.
        /// </summary>
        Task<ApiRequest<int?>> SaveListApi(int? listId = null, string title = null, IEnumerable<int> sourceIds = null, bool? noReposts = null);

        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchResponse>> SearchApi(string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, int? startTime = null, int? endTime = null, string startFrom = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchApi(string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, int? startTime = null, int? endTime = null, string startFrom = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns a hidden item to the newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> UnignoreItemApi(string type = null, int? ownerId = null, int? itemId = null);

        /// <summary>
        /// Unsubscribes the current user from specified newsfeeds.
        /// </summary>
        Task<ApiRequest<bool?>> UnsubscribeApi(string type = null, int? ownerId = null, int? itemId = null);
    }
}
