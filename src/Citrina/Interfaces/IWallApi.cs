using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IWallApi
    {
        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetResponse>> Get(
            UserAccessToken accessToken,
            int? ownerId = null,
            string domain = null,
            int? offset = null,
            int? count = null,
            string filter = null,
            IEnumerable<string> fields = null);

        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetExtendedResponse>> GetExtended(
            UserAccessToken accessToken,
            int? ownerId = null,
            string domain = null,
            int? offset = null,
            int? count = null,
            string filter = null,
            bool? extended = null,
            IEnumerable<string> fields = null);

        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetResponse>> Get(
            ServiceAccessToken accessToken,
            int? ownerId = null,
            string domain = null,
            int? offset = null,
            int? count = null,
            string filter = null,
            IEnumerable<string> fields = null);

        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetExtendedResponse>> GetExtended(
            ServiceAccessToken accessToken,
            int? ownerId = null,
            string domain = null,
            int? offset = null,
            int? count = null,
            string filter = null,
            bool? extended = null,
            IEnumerable<string> fields = null);

        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchResponse>> Search(UserAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchResponse>> Search(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(UserAccessToken accessToken, IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Adds a new post on a user wall or community wall. Can also be used to publish suggested or scheduled posts.
        /// </summary>
        Task<ApiRequest<WallPostResponse>> Post(UserAccessToken accessToken, int? ownerId = null, bool? friendsOnly = null, bool? fromGroup = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, DateTime? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, int? postId = null, string guid = null, bool? markAsAds = null);
        /// <summary>
        /// Reposts (copies) an object to a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallRepostResponse>> Repost(UserAccessToken accessToken, string @object = null, string message = null, int? groupId = null, bool? markAsAds = null);
        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetRepostsResponse>> GetReposts(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetRepostsResponse>> GetReposts(int? ownerId = null, int? postId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetRepostsResponse>> GetReposts(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Edits a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? friendsOnly = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, DateTime? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, bool? markAsAds = null);
        /// <summary>
        /// Deletes a post from a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
        /// <summary>
        /// Restores a post deleted from a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
        /// <summary>
        /// Pins the post on wall.
        /// </summary>
        Task<ApiRequest<bool?>> Pin(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
        /// <summary>
        /// Unpins the post on wall.
        /// </summary>
        Task<ApiRequest<bool?>> Unpin(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsResponse>> GetComments(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null);
        /// <summary>
        /// Adds a comment to a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<WallCreateCommentResponse>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? fromGroup = null, string message = null, int? replyToComment = null, IEnumerable<string> attachments = null, int? stickerId = null, string guid = null);
        /// <summary>
        /// Edits a comment on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Deletes a comment on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Restores a comment deleted from a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Reports (submits a complaint about) a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> ReportPost(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? reason = null);
        /// <summary>
        /// Reports (submits a complaint about) a comment on a post on a user wall or community wall.
        /// </summary>
        Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null);
    }
}
