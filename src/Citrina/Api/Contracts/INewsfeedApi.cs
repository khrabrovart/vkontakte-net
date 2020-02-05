using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface INewsfeedApi
    {
        /// <summary>
        /// Returns data required to show newsfeed for the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetResponse>> Get(UserAccessToken accessToken, IEnumerable<string> filters = null, bool? returnBanned = null, DateTime? startTime = null, DateTime? endTime = null, int? maxPhotos = null, IEnumerable<string> sourceIds = null, string startFrom = null, int? count = null, IEnumerable<string> fields = null);
        
        /// <summary>
        /// , Returns a list of newsfeeds recommended to the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetRecommendedResponse>> GetRecommended(UserAccessToken accessToken, DateTime? startTime = null, DateTime? endTime = null, int? maxPhotos = null, string startFrom = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of comments in the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<NewsfeedGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? count = null, IEnumerable<string> filters = null, string reposts = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts on user walls in which the current user is mentioned.
        /// </summary>
        Task<ApiRequest<NewsfeedGetMentionsResponse>> GetMentions(UserAccessToken accessToken, int? ownerId = null, DateTime? startTime = null, DateTime? endTime = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<NewsfeedGetBannedResponse>> GetBanned(UserAccessToken accessToken, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<NewsfeedGetBannedExtendedResponse>> GetBannedExtended(UserAccessToken accessToken, bool? extended = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Prevents news from specified users and communities from appearing in the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> AddBan(UserAccessToken accessToken, IEnumerable<int?> userIds = null, IEnumerable<int?> groupIds = null);
        /// <summary>
        /// Allows news from previously banned users and communities to be shown in the current user's newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteBan(UserAccessToken accessToken, IEnumerable<int?> userIds = null, IEnumerable<int?> groupIds = null);
        /// <summary>
        /// Hides an item from the newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> IgnoreItem(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Returns a hidden item to the newsfeed.
        /// </summary>
        Task<ApiRequest<bool?>> UnignoreItem(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? count = null, double? latitude = null, double? longitude = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchResponse>> Search(ServiceAccessToken accessToken, string q = null, int? count = null, double? latitude = null, double? longitude = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchExtended(ServiceAccessToken accessToken, string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, DateTime? startTime = null, DateTime? endTime = null, string startFrom = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of newsfeeds followed by the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetListsResponse>> GetLists(UserAccessToken accessToken, IEnumerable<int?> listIds = null);
        /// <summary>
        /// Returns a list of newsfeeds followed by the current user.
        /// </summary>
        Task<ApiRequest<NewsfeedGetListsExtendedResponse>> GetListsExtended(UserAccessToken accessToken, IEnumerable<int?> listIds = null, bool? extended = null);
        /// <summary>
        /// Creates and edits user newsfeed lists
        /// </summary>
        Task<ApiRequest<int?>> SaveList(UserAccessToken accessToken, int? listId = null, string title = null, IEnumerable<int?> sourceIds = null, bool? noReposts = null);
        Task<ApiRequest<bool?>> DeleteList(int? listId = null);
        /// <summary>
        /// Unsubscribes the current user from specified newsfeeds.
        /// </summary>
        Task<ApiRequest<bool?>> Unsubscribe(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null);
        /// <summary>
        /// Returns communities and users that current user is suggested to follow.
        /// </summary>
        Task<ApiRequest<NewsfeedGetSuggestedSourcesResponse>> GetSuggestedSources(UserAccessToken accessToken, int? offset = null, int? count = null, bool? shuffle = null, IEnumerable<string> fields = null);
    }
}
