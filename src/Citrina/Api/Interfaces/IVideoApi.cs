using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IVideoApi
    {
        /// <summary>
        /// Returns detailed information about videos.
        /// </summary>
        Task<ApiRequest<VideoGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null);
        /// <summary>
        /// Returns detailed information about videos.
        /// </summary>
        Task<ApiRequest<VideoGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null);
        /// <summary>
        /// Edits information about a video on a user or community page.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string name = null, string desc = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null);
        /// <summary>
        /// Adds a video to a user or community page.
        /// </summary>
        Task<ApiRequest<bool?>> Add(UserAccessToken accessToken, int? targetId = null, int? videoId = null, int? ownerId = null);
        /// <summary>
        /// Returns a server address (required for upload) and video data.
        /// </summary>
        Task<ApiRequest<VideoSaveResult>> Save(UserAccessToken accessToken, string name = null, string description = null, bool? isPrivate = null, bool? wallpost = null, string link = null, int? groupId = null, int? albumId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null);
        /// <summary>
        /// Deletes a video from a user or community page.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? videoId = null, int? ownerId = null, int? targetId = null);
        /// <summary>
        /// Restores a previously deleted video.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? videoId = null, int? ownerId = null);
        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// </summary>
        Task<ApiRequest<VideoSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null);
        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// </summary>
        Task<ApiRequest<VideoSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns list of videos in which the user is tagged.
        /// </summary>
        Task<ApiRequest<VideoGetUserVideosResponse>> GetUserVideos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns list of videos in which the user is tagged.
        /// </summary>
        Task<ApiRequest<VideoGetUserVideosExtendedResponse>> GetUserVideosExtended(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// </summary>
        Task<ApiRequest<VideoGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// </summary>
        Task<ApiRequest<VideoGetAlbumsExtendedResponse>> GetAlbumsExtended(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns video album info
        /// </summary>
        Task<ApiRequest<VideoVideoAlbumFull>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, int? albumId = null);
        /// <summary>
        /// Creates an empty album for videos.
        /// </summary>
        Task<ApiRequest<VideoAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? groupId = null, string title = null, IEnumerable<string> privacy = null);
        /// <summary>
        /// Edits the title of a video album.
        /// </summary>
        Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null, string title = null, IEnumerable<string> privacy = null);
        /// <summary>
        /// Deletes a video album.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null);
        /// <summary>
        /// Reorders the album in the list of user video albums.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null);
        /// <summary>
        /// Reorders the video in the video album.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderVideos(UserAccessToken accessToken, int? targetId = null, int? albumId = null, int? ownerId = null, int? videoId = null, int? beforeOwnerId = null, int? beforeVideoId = null, int? afterOwnerId = null, int? afterVideoId = null);
        Task<ApiRequest<bool?>> AddToAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null);
        Task<ApiRequest<bool?>> RemoveFromAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null);
        Task<ApiRequest<IEnumerable<int?>>> GetAlbumsByVideo(int? targetId = null, int? ownerId = null, int? videoId = null);
        Task<ApiRequest<VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoExtended(int? targetId = null, int? ownerId = null, int? videoId = null, bool? extended = null);
        /// <summary>
        /// Returns a list of comments on a video.
        /// </summary>
        Task<ApiRequest<VideoGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null);
        /// <summary>
        /// Returns a list of comments on a video.
        /// </summary>
        Task<ApiRequest<VideoGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null);
        /// <summary>
        /// Adds a new comment on a video.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null);
        /// <summary>
        /// Deletes a comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Restores a previously deleted comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Edits the text of a comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Returns a list of tags on a video.
        /// </summary>
        Task<ApiRequest<IEnumerable<VideoVideoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? videoId = null);
        /// <summary>
        /// Adds a tag on a video.
        /// </summary>
        Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? userId = null, int? ownerId = null, int? videoId = null, string taggedName = null);
        /// <summary>
        /// Removes a tag from a video.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? tagId = null, int? ownerId = null, int? videoId = null);
        /// <summary>
        /// Returns a list of videos with tags that have not been viewed.
        /// </summary>
        Task<ApiRequest<VideoGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Reports (submits a complaint about) a video.
        /// </summary>
        Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, int? reason = null, string comment = null, string searchQuery = null);
        /// <summary>
        /// Reports (submits a complaint about) a comment on a video.
        /// </summary>
        Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null);
        /// <summary>
        /// Returns video catalog
        /// </summary>
        Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(string sectionId = null, string from = null, int? count = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(string sectionId = null, string from = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null);
        /// <summary>
        /// Returns a separate catalog section
        /// </summary>
        Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Hides a video catalog section from a user.
        /// </summary>
        Task<ApiRequest<bool?>> HideCatalogSection(UserAccessToken accessToken, int? sectionId = null);
    }
}
