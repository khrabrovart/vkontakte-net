using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface INotesApi
    {
        /// <summary>
        /// Creates a new note for the current user.
        /// </summary>
        Task<ApiRequest<int?>> AddApi(string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null);

        /// <summary>
        /// Adds a new comment on a note.
        /// </summary>
        Task<ApiRequest<int?>> CreateCommentApi(int? noteId = null, int? ownerId = null, int? replyTo = null, string message = null, string guid = null);

        /// <summary>
        /// Deletes a note of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteApi(int? noteId = null);

        /// <summary>
        /// Deletes a comment on a note.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteCommentApi(int? commentId = null, int? ownerId = null);

        /// <summary>
        /// Edits a note of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> EditApi(int? noteId = null, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null);

        /// <summary>
        /// Edits a comment on a note.
        /// </summary>
        Task<ApiRequest<bool?>> EditCommentApi(int? commentId = null, int? ownerId = null, string message = null);

        /// <summary>
        /// Returns a list of notes created by a user.
        /// </summary>
        Task<ApiRequest<NotesGetResponse>> GetApi(IEnumerable<int> noteIds = null, int? userId = null, int? offset = null, int? count = null, int? sort = null);

        /// <summary>
        /// Returns a note by its ID.
        /// </summary>
        Task<ApiRequest<NotesNote>> GetByIdApi(int? noteId = null, int? ownerId = null, bool? needWiki = null);

        /// <summary>
        /// Returns a list of comments on a note.
        /// </summary>
        Task<ApiRequest<NotesGetCommentsResponse>> GetCommentsApi(int? noteId = null, int? ownerId = null, int? sort = null, int? offset = null, int? count = null);

        /// <summary>
        /// Restores a deleted comment on a note.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreCommentApi(int? commentId = null, int? ownerId = null);
    }
}
