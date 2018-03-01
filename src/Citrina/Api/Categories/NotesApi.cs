using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class NotesApi : INotesApi
    {
        public Task<ApiRequest<NotesGetResponse>> Get(UserAccessToken accessToken, IEnumerable<int?> noteIds = null, int? userId = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_ids"] = RequestHelpers.ParseEnumerable(noteIds),
                ["user_id"] = userId?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NotesGetResponse>("notes.get", accessToken, request);
        }

        public Task<ApiRequest<NotesNote>> GetById(UserAccessToken accessToken, int? noteId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NotesNote>("notes.getById", accessToken, request);
        }

        public Task<ApiRequest<int?>> Add(UserAccessToken accessToken, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["title"] = title,
                ["text"] = text,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
            };

            return RequestManager.CreateRequestAsync<int?>("notes.add", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? noteId = null, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
                ["title"] = title,
                ["text"] = text,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? noteId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.delete", accessToken, request);
        }

        public Task<ApiRequest<NotesGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NotesGetCommentsResponse>("notes.getComments", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? replyTo = null, string message = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["reply_to"] = replyTo?.ToString(),
                ["message"] = message,
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("notes.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null, string message = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["comment_id"] = commentId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["message"] = message,
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.editComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["comment_id"] = commentId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["comment_id"] = commentId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.restoreComment", accessToken, request);
        }

    }
}
