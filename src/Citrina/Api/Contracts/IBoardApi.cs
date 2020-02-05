using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IBoardApi
    {
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsResponse>> GetComments(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);
        /// <summary>
        /// Creates a new topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<int?>> AddTopic(UserAccessToken accessToken, int? groupId = null, string title = null, string text = null, bool? fromGroup = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Adds a comment on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? stickerId = null, string guid = null);
        /// <summary>
        /// Deletes a topic from a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
        /// <summary>
        /// Edits the title of a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> EditTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string title = null);
        /// <summary>
        /// Edits a comment on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Restores a comment deleted from a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null);
        /// <summary>
        /// Restores a comment deleted from a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(GroupAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null);
        /// <summary>
        /// Re-opens a previously closed topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> OpenTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
        /// <summary>
        /// Closes a topic on a community's discussion board so that comments cannot be posted.
        /// </summary>
        Task<ApiRequest<bool?>> CloseTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
        /// <summary>
        /// Pins a topic (fixes its place) to the top of a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> FixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
        /// <summary>
        /// Unpins a pinned topic from the top of a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> UnfixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null);
    }
}
