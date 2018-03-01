using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class BoardApi : IBoardApi
    {
        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", accessToken, request);
        }

        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsExtendedResponse>("board.getTopics", accessToken, request);
        }

        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", null, request);
        }

        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
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

        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", accessToken, request);
        }

        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsExtendedResponse>("board.getTopics", accessToken, request);
        }

        public Task<ApiRequest<BoardGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", accessToken, request);
        }

        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsExtendedResponse>("board.getComments", accessToken, request);
        }

        public Task<ApiRequest<BoardGetCommentsResponse>> GetComments(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", null, request);
        }

        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
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

        public Task<ApiRequest<BoardGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", accessToken, request);
        }

        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsExtendedResponse>("board.getComments", accessToken, request);
        }

        public Task<ApiRequest<int?>> AddTopic(UserAccessToken accessToken, int? groupId = null, string title = null, string text = null, bool? fromGroup = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["title"] = title,
                ["text"] = text,
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<int?>("board.addTopic", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("board.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.deleteTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<bool?>("board.editTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.editComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(GroupAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> OpenTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.openTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> CloseTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.closeTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> FixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.fixTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> UnfixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.unfixTopic", accessToken, request);
        }

    }
}
