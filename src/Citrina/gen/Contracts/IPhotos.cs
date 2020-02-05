using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IPhotosApi
    {
        /// <summary>
        /// Confirms a tag on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> ConfirmTagApi(int? ownerId = null, string photoId = null, int? tagId = null);

        /// <summary>
        /// Allows to copy a photo to the "Saved photos" album.
        /// </summary>
        Task<ApiRequest<int?>> CopyApi(int? ownerId = null, int? photoId = null, string accessKey = null);

        /// <summary>
        /// Creates an empty photo album.
        /// </summary>
        Task<ApiRequest<PhotosPhotoAlbumFull>> CreateAlbumApi(string title = null, int? groupId = null, string description = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null);

        /// <summary>
        /// Adds a new comment on the photo.
        /// </summary>
        Task<ApiRequest<int?>> CreateCommentApi(int? ownerId = null, int? photoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string accessKey = null, string guid = null);

        /// <summary>
        /// Deletes a photo.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? photoId = null);

        /// <summary>
        /// Deletes a photo album belonging to the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAlbumApi(int? albumId = null, int? groupId = null);

        /// <summary>
        /// Deletes a comment on the photo.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteCommentApi(int? ownerId = null, int? commentId = null);

        /// <summary>
        /// Edits the caption of a photo.
        /// </summary>
        Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? photoId = null, string caption = null, double? latitude = null, double? longitude = null, string placeStr = null, string foursquareId = null, bool? deletePlace = null);

        /// <summary>
        /// Edits information about a photo album.
        /// </summary>
        Task<ApiRequest<bool?>> EditAlbumApi(int? albumId = null, string title = null, string description = null, int? ownerId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null);

        /// <summary>
        /// Edits a comment on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> EditCommentApi(int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);

        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetResponse>> GetApi(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetExtendedResponse>> GetApi(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns a list of a user's or community's photo albums.
        /// </summary>
        Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbumsApi(int? ownerId = null, IEnumerable<int> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null);

        /// <summary>
        /// Returns the number of photo albums belonging to a user or community.
        /// </summary>
        Task<ApiRequest<int?>> GetAlbumsCountApi(int? userId = null, int? groupId = null);

        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// </summary>
        Task<ApiRequest<PhotosGetAllResponse>> GetAllApi(int? ownerId = null, bool? extended = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null);

        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// </summary>
        Task<ApiRequest<PhotosGetAllExtendedResponse>> GetAllApi(int? ownerId = null, bool? extended = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null);

        /// <summary>
        /// Returns a list of comments on a specific photo album or all albums of the user sorted in reverse chronological order.
        /// </summary>
        Task<ApiRequest<PhotosGetAllCommentsResponse>> GetAllCommentsApi(int? ownerId = null, int? albumId = null, bool? needLikes = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetByIdApi(IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null);

        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdApi(IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null);

        /// <summary>
        /// Returns an upload link for chat cover pictures.
        /// </summary>
        Task<ApiRequest<BaseUploadServer>> GetChatUploadServerApi(int? chatId = null, int? cropX = null, int? cropY = null, int? cropWidth = null);

        /// <summary>
        /// Returns a list of comments on a photo.
        /// </summary>
        Task<ApiRequest<PhotosGetCommentsResponse>> GetCommentsApi(int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, bool? extended = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns a list of comments on a photo.
        /// </summary>
        Task<ApiRequest<PhotosGetCommentsExtendedResponse>> GetCommentsApi(int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, bool? extended = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns the server address for market album photo upload.
        /// </summary>
        Task<ApiRequest<BaseUploadServer>> GetMarketAlbumUploadServerApi(int? groupId = null);

        /// <summary>
        /// Returns the server address for market photo upload.
        /// </summary>
        Task<ApiRequest<BaseUploadServer>> GetMarketUploadServerApi(int? groupId = null, bool? mainPhoto = null, int? cropX = null, int? cropY = null, int? cropWidth = null);

        /// <summary>
        /// Returns the server address for photo upload in a private message for a user.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServerApi(int? peerId = null);

        /// <summary>
        /// Returns a list of photos with tags that have not been viewed.
        /// </summary>
        Task<ApiRequest<PhotosGetNewTagsResponse>> GetNewTagsApi(int? offset = null, int? count = null);

        /// <summary>
        /// Returns the server address for owner cover upload.
        /// </summary>
        Task<ApiRequest<BaseUploadServer>> GetOwnerCoverPhotoUploadServerApi(int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null);

        /// <summary>
        /// Returns an upload server address for a profile or community photo.
        /// </summary>
        Task<ApiRequest<BaseUploadServer>> GetOwnerPhotoUploadServerApi(int? ownerId = null);

        /// <summary>
        /// Returns a list of tags on a photo.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoTag>>> GetTagsApi(int? ownerId = null, int? photoId = null, string accessKey = null);

        /// <summary>
        /// Returns the server address for photo upload.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetUploadServerApi(int? groupId = null, int? albumId = null);

        /// <summary>
        /// Returns a list of photos in which a user is tagged.
        /// </summary>
        Task<ApiRequest<PhotosGetUserPhotosResponse>> GetUserPhotosApi(int? userId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);

        /// <summary>
        /// Returns a list of photos in which a user is tagged.
        /// </summary>
        Task<ApiRequest<PhotosGetUserPhotosExtendedResponse>> GetUserPhotosApi(int? userId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);

        /// <summary>
        /// Returns the server address for photo upload onto a user's wall.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetWallUploadServerApi(int? groupId = null);

        /// <summary>
        /// Makes a photo into an album cover.
        /// </summary>
        Task<ApiRequest<bool?>> MakeCoverApi(int? ownerId = null, int? photoId = null, int? albumId = null);

        /// <summary>
        /// Moves a photo from one album to another.
        /// </summary>
        Task<ApiRequest<bool?>> MoveApi(int? ownerId = null, int? targetAlbumId = null, int? photoId = null);

        /// <summary>
        /// Adds a tag on the photo.
        /// </summary>
        Task<ApiRequest<int?>> PutTagApi(int? ownerId = null, int? photoId = null, int? userId = null, double? x = null, double? y = null, double? x2 = null, double? y2 = null);

        /// <summary>
        /// Removes a tag from a photo.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveTagApi(int? ownerId = null, int? photoId = null, int? tagId = null);

        /// <summary>
        /// Reorders the album in the list of user albums.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderAlbumsApi(int? ownerId = null, int? albumId = null, int? before = null, int? after = null);

        /// <summary>
        /// Reorders the photo in the list of photos of the user album.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderPhotosApi(int? ownerId = null, int? photoId = null, int? before = null, int? after = null);

        /// <summary>
        /// Reports (submits a complaint about) a photo.
        /// </summary>
        Task<ApiRequest<bool?>> ReportApi(int? ownerId = null, int? photoId = null, int? reason = null);

        /// <summary>
        /// Reports (submits a complaint about) a comment on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> ReportCommentApi(int? ownerId = null, int? commentId = null, int? reason = null);

        /// <summary>
        /// Restores a deleted photo.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreApi(int? ownerId = null, int? photoId = null);

        /// <summary>
        /// Restores a deleted comment on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreCommentApi(int? ownerId = null, int? commentId = null);

        /// <summary>
        /// Saves photos after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveApi(int? albumId = null, int? groupId = null, int? server = null, string photosList = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null);

        /// <summary>
        /// Saves market album photos after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhotoApi(int? groupId = null, string photo = null, int? server = null, string hash = null);

        /// <summary>
        /// Saves market photos after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketPhotoApi(int? groupId = null, string photo = null, int? server = null, string hash = null, string cropData = null, string cropHash = null);

        /// <summary>
        /// Saves a photo after being successfully uploaded. URL obtained with [vk.com/dev/photos.getMessagesUploadServer|photos.getMessagesUploadServer] method.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhotoApi(string photo = null, int? server = null, string hash = null);

        /// <summary>
        /// Saves cover photo after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseImage>>> SaveOwnerCoverPhotoApi(string hash = null, string photo = null);

        /// <summary>
        /// Saves a profile or community photo. Upload URL can be got with the [vk.com/dev/photos.getOwnerPhotoUploadServer|photos.getOwnerPhotoUploadServer] method.
        /// </summary>
        Task<ApiRequest<PhotosSaveOwnerPhotoResponse>> SaveOwnerPhotoApi(string server = null, string hash = null, string photo = null);

        /// <summary>
        /// Saves a photo to a user's or community's wall after being uploaded.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveWallPhotoApi(int? userId = null, int? groupId = null, string photo = null, int? server = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null);

        /// <summary>
        /// Returns a list of photos.
        /// </summary>
        Task<ApiRequest<PhotosSearchResponse>> SearchApi(string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null);
    }
}
