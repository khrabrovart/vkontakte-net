using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IBoardApi
    {
        /// <summary>
        /// Creates a new topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<int?>> AddTopicApi(int? groupId = null, string title = null, string text = null, bool? fromGroup = null, IEnumerable<string> attachments = null);

        /// <summary>
        /// Closes a topic on a community's discussion board so that comments cannot be posted.
        /// </summary>
        Task<ApiRequest<bool?>> CloseTopicApi(int? groupId = null, int? topicId = null);

        /// <summary>
        /// Adds a comment on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<int?>> CreateCommentApi(int? groupId = null, int? topicId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? stickerId = null, string guid = null);

        /// <summary>
        /// Deletes a comment on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteCommentApi(int? groupId = null, int? topicId = null, int? commentId = null);

        /// <summary>
        /// Deletes a topic from a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteTopicApi(int? groupId = null, int? topicId = null);

        /// <summary>
        /// Edits a comment on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> EditCommentApi(int? groupId = null, int? topicId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);

        /// <summary>
        /// Edits the title of a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> EditTopicApi(int? groupId = null, int? topicId = null, string title = null);

        /// <summary>
        /// Pins a topic (fixes its place) to the top of a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> FixTopicApi(int? groupId = null, int? topicId = null);

        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsResponse>> GetCommentsApi(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);

        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsApi(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);

        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsResponse>> GetTopicsApi(int? groupId = null, IEnumerable<int> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null);

        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsApi(int? groupId = null, IEnumerable<int> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null);

        /// <summary>
        /// Re-opens a previously closed topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> OpenTopicApi(int? groupId = null, int? topicId = null);

        /// <summary>
        /// Restores a comment deleted from a topic on a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreCommentApi(int? groupId = null, int? topicId = null, int? commentId = null);

        /// <summary>
        /// Unpins a pinned topic from the top of a community's discussion board.
        /// </summary>
        Task<ApiRequest<bool?>> UnfixTopicApi(int? groupId = null, int? topicId = null);
    }
}
