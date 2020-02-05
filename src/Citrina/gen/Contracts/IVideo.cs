using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IVideoApi
    {
        /// <summary>
        /// Adds a video to a user or community page.
        /// </summary>
        Task<ApiRequest<bool?>> AddApi(int? targetId = null, int? videoId = null, int? ownerId = null);

        /// <summary>
        /// Creates an empty album for videos.
        /// </summary>
        Task<ApiRequest<VideoAddAlbumResponse>> AddAlbumApi(int? groupId = null, string title = null, IEnumerable<string> privacy = null);

        Task<ApiRequest<bool?>> AddToAlbumApi(int? targetId = null, int? albumId = null, IEnumerable<int> albumIds = null, int? ownerId = null, int? videoId = null);

        /// <summary>
        /// Adds a new comment on a video.
        /// </summary>
        Task<ApiRequest<int?>> CreateCommentApi(int? ownerId = null, int? videoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null);

        /// <summary>
        /// Deletes a video from a user or community page.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteApi(int? videoId = null, int? ownerId = null, int? targetId = null);

        /// <summary>
        /// Deletes a video album.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAlbumApi(int? groupId = null, int? albumId = null);

        /// <summary>
        /// Deletes a comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteCommentApi(int? ownerId = null, int? commentId = null);

        /// <summary>
        /// Edits information about a video on a user or community page.
        /// </summary>
        Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? videoId = null, string name = null, string desc = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null);

        /// <summary>
        /// Edits the title of a video album.
        /// </summary>
        Task<ApiRequest<bool?>> EditAlbumApi(int? groupId = null, int? albumId = null, string title = null, IEnumerable<string> privacy = null);

        /// <summary>
        /// Edits the text of a comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> EditCommentApi(int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);

        /// <summary>
        /// Returns detailed information about videos.
        /// </summary>
        Task<ApiRequest<VideoGetResponse>> GetApi(int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null);

        /// <summary>
        /// Returns detailed information about videos.
        /// </summary>
        Task<ApiRequest<VideoGetExtendedResponse>> GetApi(int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null);

        /// <summary>
        /// Returns video album info.
        /// </summary>
        Task<ApiRequest<VideoVideoAlbumFull>> GetAlbumByIdApi(int? ownerId = null, int? albumId = null);

        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// </summary>
        Task<ApiRequest<VideoGetAlbumsResponse>> GetAlbumsApi(int? ownerId = null, int? offset = null, int? count = null, bool? extended = null, bool? needSystem = null);

        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// </summary>
        Task<ApiRequest<VideoGetAlbumsExtendedResponse>> GetAlbumsApi(int? ownerId = null, int? offset = null, int? count = null, bool? extended = null, bool? needSystem = null);

        Task<ApiRequest<IEnumerable<int>>> GetAlbumsByVideoApi(int? targetId = null, int? ownerId = null, int? videoId = null, bool? extended = null);

        Task<ApiRequest<VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoApi(int? targetId = null, int? ownerId = null, int? videoId = null, bool? extended = null);

        /// <summary>
        /// Returns a list of comments on a video.
        /// </summary>
        Task<ApiRequest<VideoGetCommentsResponse>> GetCommentsApi(int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null);

        /// <summary>
        /// Returns a list of comments on a video.
        /// </summary>
        Task<ApiRequest<VideoGetCommentsExtendedResponse>> GetCommentsApi(int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null);

        Task<ApiRequest<bool?>> RemoveFromAlbumApi(int? targetId = null, int? albumId = null, IEnumerable<int> albumIds = null, int? ownerId = null, int? videoId = null);

        /// <summary>
        /// Reorders the album in the list of user video albums.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderAlbumsApi(int? ownerId = null, int? albumId = null, int? before = null, int? after = null);

        /// <summary>
        /// Reorders the video in the video album.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderVideosApi(int? targetId = null, int? albumId = null, int? ownerId = null, int? videoId = null, int? beforeOwnerId = null, int? beforeVideoId = null, int? afterOwnerId = null, int? afterVideoId = null);

        /// <summary>
        /// Reports (submits a complaint about) a video.
        /// </summary>
        Task<ApiRequest<bool?>> ReportApi(int? ownerId = null, int? videoId = null, int? reason = null, string comment = null, string searchQuery = null);

        /// <summary>
        /// Reports (submits a complaint about) a comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> ReportCommentApi(int? ownerId = null, int? commentId = null, int? reason = null);

        /// <summary>
        /// Restores a previously deleted video.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreApi(int? videoId = null, int? ownerId = null);

        /// <summary>
        /// Restores a previously deleted comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreCommentApi(int? ownerId = null, int? commentId = null);

        /// <summary>
        /// Returns a server address (required for upload) and video data.
        /// </summary>
        Task<ApiRequest<VideoSaveResult>> SaveApi(string name = null, string description = null, bool? isPrivate = null, bool? wallpost = null, string link = null, int? groupId = null, int? albumId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null, bool? compression = null);

        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// </summary>
        Task<ApiRequest<VideoSearchResponse>> SearchApi(string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null);

        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// </summary>
        Task<ApiRequest<VideoSearchExtendedResponse>> SearchApi(string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null);
    }
}
