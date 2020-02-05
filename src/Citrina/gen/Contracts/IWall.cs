using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IWallApi
    {
        Task<ApiRequest<bool?>> CloseCommentsApi(int? ownerId = null, int? postId = null);

        /// <summary>
        /// Adds a comment to a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallCreateCommentResponse>> CreateCommentApi(int? ownerId = null, int? postId = null, int? fromGroup = null, string message = null, int? replyToComment = null, IEnumerable<string> attachments = null, int? stickerId = null, string guid = null);

        /// <summary>
        /// Deletes a post from a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? postId = null);

        /// <summary>
        /// Deletes a comment on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteCommentApi(int? ownerId = null, int? commentId = null);

        /// <summary>
        /// Edits a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallEditResponse>> EditApi(int? ownerId = null, int? postId = null, bool? friendsOnly = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, int? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, bool? markAsAds = null, bool? closeComments = null, int? posterBkgId = null, int? posterBkgOwnerId = null, string posterBkgAccessHash = null);

        /// <summary>
        /// Allows to edit hidden post.
        /// </summary>
        Task<ApiRequest<bool?>> EditAdsStealthApi(int? ownerId = null, int? postId = null, string message = null, IEnumerable<string> attachments = null, bool? signed = null, double? lat = null, double? @long = null, int? placeId = null, string linkButton = null, string linkTitle = null, string linkImage = null, string linkVideo = null);

        /// <summary>
        /// Edits a comment on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> EditCommentApi(int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);

        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetResponse>> GetApi(int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetExtendedResponse>> GetApi(int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetByIdApi(IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdApi(IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsResponse>> GetCommentsApi(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null, int? commentId = null, int? threadItemsCount = null);

        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsApi(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null, int? commentId = null, int? threadItemsCount = null);

        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetRepostsResponse>> GetRepostsApi(int? ownerId = null, int? postId = null, int? offset = null, int? count = null);

        Task<ApiRequest<bool?>> OpenCommentsApi(int? ownerId = null, int? postId = null);

        /// <summary>
        /// Pins the post on wall.
        /// </summary>
        Task<ApiRequest<bool?>> PinApi(int? ownerId = null, int? postId = null);

        /// <summary>
        /// Adds a new post on a user wall or community wall. Can also be used to publish suggested or scheduled posts.
        /// </summary>
        Task<ApiRequest<WallPostResponse>> PostApi(int? ownerId = null, bool? friendsOnly = null, bool? fromGroup = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, int? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, int? postId = null, string guid = null, bool? markAsAds = null, bool? closeComments = null, bool? muteNotifications = null);

        /// <summary>
        /// Allows to create hidden post which will not be shown on the community's wall and can be used for creating an ad with type "Community post".
        /// </summary>
        Task<ApiRequest<WallPostAdsStealthResponse>> PostAdsStealthApi(int? ownerId = null, string message = null, IEnumerable<string> attachments = null, bool? signed = null, double? lat = null, double? @long = null, int? placeId = null, string guid = null, string linkButton = null, string linkTitle = null, string linkImage = null, string linkVideo = null);

        /// <summary>
        /// Reports (submits a complaint about) a comment on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> ReportCommentApi(int? ownerId = null, int? commentId = null, int? reason = null);

        /// <summary>
        /// Reports (submits a complaint about) a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> ReportPostApi(int? ownerId = null, int? postId = null, int? reason = null);

        /// <summary>
        /// Reposts (copies) an object to a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallRepostResponse>> RepostApi(string @object = null, string message = null, int? groupId = null, bool? markAsAds = null, bool? muteNotifications = null);

        /// <summary>
        /// Restores a post deleted from a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreApi(int? ownerId = null, int? postId = null);

        /// <summary>
        /// Restores a comment deleted from a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreCommentApi(int? ownerId = null, int? commentId = null);

        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchResponse>> SearchApi(int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchExtendedResponse>> SearchApi(int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Unpins the post on wall.
        /// </summary>
        Task<ApiRequest<bool?>> UnpinApi(int? ownerId = null, int? postId = null);
    }
}
