using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Board : IBoard
    {
        /// <summary>
        /// Creates a new topic on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<int?>> AddTopicApi(int? groupId = null, string title = null, string text = null, bool? fromGroup = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["title"] = title,
                ["text"] = text,
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<int?>("board.addTopic", null, request);
        }

        /// <summary>
        /// Closes a topic on a community's discussion board so that comments cannot be posted.
        /// </summary>
        public Task<ApiRequest<bool?>> CloseTopicApi(int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.closeTopic", null, request);
        }

        /// <summary>
        /// Adds a comment on a topic on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<int?>> CreateCommentApi(int? groupId = null, int? topicId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("board.createComment", null, request);
        }

        /// <summary>
        /// Deletes a comment on a topic on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteCommentApi(int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.deleteComment", null, request);
        }

        /// <summary>
        /// Deletes a topic from a community's discussion board.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteTopicApi(int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.deleteTopic", null, request);
        }

        /// <summary>
        /// Edits a comment on a topic on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<bool?>> EditCommentApi(int? groupId = null, int? topicId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.editComment", null, request);
        }

        /// <summary>
        /// Edits the title of a topic on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<bool?>> EditTopicApi(int? groupId = null, int? topicId = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<bool?>("board.editTopic", null, request);
        }

        /// <summary>
        /// Pins a topic (fixes its place) to the top of a community's discussion board.
        /// </summary>
        public Task<ApiRequest<bool?>> FixTopicApi(int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.fixTopic", null, request);
        }

        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<BoardGetCommentsResponse>> GetCommentsApi(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", null, request);
        }

        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsApi(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsExtendedResponse>("board.getComments", null, request);
        }

        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopicsApi(int? groupId = null, IEnumerable<int> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", null, request);
        }

        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsApi(int? groupId = null, IEnumerable<int> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsExtendedResponse>("board.getTopics", null, request);
        }

        /// <summary>
        /// Re-opens a previously closed topic on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<bool?>> OpenTopicApi(int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.openTopic", null, request);
        }

        /// <summary>
        /// Restores a comment deleted from a topic on a community's discussion board.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreCommentApi(int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.restoreComment", null, request);
        }

        /// <summary>
        /// Unpins a pinned topic from the top of a community's discussion board.
        /// </summary>
        public Task<ApiRequest<bool?>> UnfixTopicApi(int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.unfixTopic", null, request);
        }
    }
}
