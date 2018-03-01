using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface INotesApi
    {
        /// <summary>
        /// Returns a list of notes created by a user.
        /// </summary>
        Task<ApiRequest<NotesGetResponse>> Get(UserAccessToken accessToken, IEnumerable<int?> noteIds = null, int? userId = null, int? count = null);
        /// <summary>
        /// Returns a note by its ID.
        /// </summary>
        Task<ApiRequest<NotesNote>> GetById(UserAccessToken accessToken, int? noteId = null, int? ownerId = null);
        /// <summary>
        /// Creates a new note for the current user.
        /// </summary>
        Task<ApiRequest<int?>> Add(UserAccessToken accessToken, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null);
        /// <summary>
        /// Edits a note of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? noteId = null, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null);
        /// <summary>
        /// Deletes a note of the current user.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? noteId = null);
        /// <summary>
        /// Returns a list of comments on a note.
        /// </summary>
        Task<ApiRequest<NotesGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? count = null);
        /// <summary>
        /// Adds a new comment on a note.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? replyTo = null, string message = null, string guid = null);
        /// <summary>
        /// Edits a comment on a note.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null, string message = null);
        /// <summary>
        /// Deletes a comment on a note.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null);
        /// <summary>
        /// Restores a deleted comment on a note.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null);
    }
}
