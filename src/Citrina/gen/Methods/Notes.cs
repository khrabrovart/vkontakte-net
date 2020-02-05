using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Notes : INotes
    {
        /// <summary>
        /// Creates a new note for the current user.
        /// </summary>
        public Task<ApiRequest<int?>> AddApi(string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["title"] = title,
                ["text"] = text,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
            };

            return RequestManager.CreateRequestAsync<int?>("notes.add", null, request);
        }

        /// <summary>
        /// Adds a new comment on a note.
        /// </summary>
        public Task<ApiRequest<int?>> CreateCommentApi(int? noteId = null, int? ownerId = null, int? replyTo = null, string message = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["note_id"] = noteId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["reply_to"] = replyTo?.ToString(),
                ["message"] = message,
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("notes.createComment", null, request);
        }

        /// <summary>
        /// Deletes a note of the current user.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteApi(int? noteId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["note_id"] = noteId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.delete", null, request);
        }

        /// <summary>
        /// Deletes a comment on a note.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteCommentApi(int? commentId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["comment_id"] = commentId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.deleteComment", null, request);
        }

        /// <summary>
        /// Edits a note of the current user.
        /// </summary>
        public Task<ApiRequest<bool?>> EditApi(int? noteId = null, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["note_id"] = noteId?.ToString(),
                ["title"] = title,
                ["text"] = text,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.edit", null, request);
        }

        /// <summary>
        /// Edits a comment on a note.
        /// </summary>
        public Task<ApiRequest<bool?>> EditCommentApi(int? commentId = null, int? ownerId = null, string message = null)
        {
            var request = new Dictionary<string, string>
            {
                ["comment_id"] = commentId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["message"] = message,
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.editComment", null, request);
        }

        /// <summary>
        /// Returns a list of notes created by a user.
        /// </summary>
        public Task<ApiRequest<NotesGetResponse>> GetApi(IEnumerable<int> noteIds = null, int? userId = null, int? offset = null, int? count = null, int? sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["note_ids"] = RequestHelpers.ParseEnumerable(noteIds),
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NotesGetResponse>("notes.get", null, request);
        }

        /// <summary>
        /// Returns a note by its ID.
        /// </summary>
        public Task<ApiRequest<NotesNote>> GetByIdApi(int? noteId = null, int? ownerId = null, bool? needWiki = null)
        {
            var request = new Dictionary<string, string>
            {
                ["note_id"] = noteId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["need_wiki"] = RequestHelpers.ParseBoolean(needWiki),
            };

            return RequestManager.CreateRequestAsync<NotesNote>("notes.getById", null, request);
        }

        /// <summary>
        /// Returns a list of comments on a note.
        /// </summary>
        public Task<ApiRequest<NotesGetCommentsResponse>> GetCommentsApi(int? noteId = null, int? ownerId = null, int? sort = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["note_id"] = noteId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["sort"] = sort?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NotesGetCommentsResponse>("notes.getComments", null, request);
        }

        /// <summary>
        /// Restores a deleted comment on a note.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreCommentApi(int? commentId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["comment_id"] = commentId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.restoreComment", null, request);
        }
    }
}
