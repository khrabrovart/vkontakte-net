using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IPhotosApi
    {
        /// <summary>
        /// Creates an empty photo album.
        /// </summary>
        Task<ApiRequest<PhotosPhotoAlbumFull>> CreateAlbum(UserAccessToken accessToken, string title = null, int? groupId = null, string description = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null);
        /// <summary>
        /// Edits information about a photo album.
        /// </summary>
        Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? albumId = null, string title = null, string description = null, int? ownerId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null);
        /// <summary>
        /// Returns a list of a user's or community's photo albums.
        /// </summary>
        Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null);
        /// <summary>
        /// Returns a list of a user's or community's photo albums.
        /// </summary>
        Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null);
        /// <summary>
        /// Returns a list of a user's or community's photo albums.
        /// </summary>
        Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(ServiceAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetResponse>> Get(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetResponse>> Get(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns the number of photo albums belonging to a user or community.
        /// </summary>
        Task<ApiRequest<int?>> GetAlbumsCount(UserAccessToken accessToken, int? userId = null, int? groupId = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(IEnumerable<string> photos = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null);
        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null);
        /// <summary>
        /// Returns the server address for photo upload.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetUploadServer(UserAccessToken accessToken, int? albumId = null, int? groupId = null);
        /// <summary>
        /// Returns the server address for owner cover upload.
        /// </summary>
        Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(UserAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null);
        /// <summary>
        /// Returns the server address for owner cover upload.
        /// </summary>
        Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(GroupAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null);
        /// <summary>
        /// Returns an upload server address for a profile or community photo.
        /// </summary>
        Task<ApiRequest<PhotosGetOwnerPhotoUploadServerResponse>> GetOwnerPhotoUploadServer(UserAccessToken accessToken, int? ownerId = null);
        /// <summary>
        /// Returns an upload link for chat cover pictures.
        /// </summary>
        Task<ApiRequest<PhotosGetChatUploadServerResponse>> GetChatUploadServer(UserAccessToken accessToken, int? chatId = null, int? cropX = null, int? cropY = null, int? cropWidth = null);
        /// <summary>
        /// Returns the server address for market photo upload.
        /// </summary>
        Task<ApiRequest<PhotosGetMarketUploadServerResponse>> GetMarketUploadServer(UserAccessToken accessToken, int? groupId = null, bool? mainPhoto = null, int? cropX = null, int? cropY = null, int? cropWidth = null);
        /// <summary>
        /// Returns the server address for market album photo upload.
        /// </summary>
        Task<ApiRequest<PhotosGetMarketAlbumUploadServerResponse>> GetMarketAlbumUploadServer(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Saves market photos after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null, string cropData = null, string cropHash = null);
        /// <summary>
        /// Saves cover photo after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseImage>>> SaveOwnerCoverPhoto(UserAccessToken accessToken, string photo = null, string hash = null);
        /// <summary>
        /// Saves market album photos after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null);
        /// <summary>
        /// Saves a profile or community photo. Upload URL can be got with the [vk.com/dev/photos.getOwnerPhotoUploadServer|photos.getOwnerPhotoUploadServer] method.
        /// </summary>
        Task<ApiRequest<PhotosSaveOwnerPhotoResponse>> SaveOwnerPhoto(UserAccessToken accessToken, string server = null, string hash = null, string photo = null);
        /// <summary>
        /// Saves a photo to a user's or community's wall after being uploaded.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveWallPhoto(UserAccessToken accessToken, int? userId = null, int? groupId = null, string photo = null, int? server = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null);
        /// <summary>
        /// Returns the server address for photo upload onto a user's wall.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns the server address for photo upload in a private message for a user.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(UserAccessToken accessToken);
        /// <summary>
        /// Returns the server address for photo upload in a private message for a user.
        /// </summary>
        Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(GroupAccessToken accessToken);
        /// <summary>
        /// Saves a photo after being successfully uploaded. URL obtained with [vk.com/dev/photos.getMessagesUploadServer|photos.getMessagesUploadServer] method.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(UserAccessToken accessToken, string photo = null, int? server = null, string hash = null);
        /// <summary>
        /// Saves a photo after being successfully uploaded. URL obtained with [vk.com/dev/photos.getMessagesUploadServer|photos.getMessagesUploadServer] method.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(GroupAccessToken accessToken, string photo = null, int? server = null, string hash = null);
        /// <summary>
        /// Reports (submits a complaint about) a photo.
        /// </summary>
        Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? reason = null);
        /// <summary>
        /// Reports (submits a complaint about) a comment on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null);
        /// <summary>
        /// Returns a list of photos.
        /// </summary>
        Task<ApiRequest<PhotosSearchResponse>> Search(UserAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null);
        /// <summary>
        /// Returns a list of photos.
        /// </summary>
        Task<ApiRequest<PhotosSearchResponse>> Search(string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null);
        /// <summary>
        /// Returns a list of photos.
        /// </summary>
        Task<ApiRequest<PhotosSearchResponse>> Search(ServiceAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null);
        /// <summary>
        /// Saves photos after successful uploading.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhoto>>> Save(UserAccessToken accessToken, int? albumId = null, int? groupId = null, int? server = null, string photosList = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null);
        /// <summary>
        /// Allows to copy a photo to the "Saved photos" album
        /// </summary>
        Task<ApiRequest<int?>> Copy(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null);
        /// <summary>
        /// Edits the caption of a photo.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string caption = null, double? latitude = null, double? longitude = null, string placeStr = null, string foursquareId = null, bool? deletePlace = null);
        /// <summary>
        /// Moves a photo from one album to another.
        /// </summary>
        Task<ApiRequest<bool?>> Move(UserAccessToken accessToken, int? ownerId = null, int? targetAlbumId = null, int? photoId = null);
        /// <summary>
        /// Makes a photo into an album cover.
        /// </summary>
        Task<ApiRequest<bool?>> MakeCover(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? albumId = null);
        /// <summary>
        /// Reorders the album in the list of user albums.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null);
        /// <summary>
        /// Reorders the photo in the list of photos of the user album.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderPhotos(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? before = null, int? after = null);
        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// </summary>
        Task<ApiRequest<PhotosGetAllResponse>> GetAll(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null);
        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// </summary>
        Task<ApiRequest<PhotosGetAllExtendedResponse>> GetAllExtended(UserAccessToken accessToken, int? ownerId = null, bool? extended = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null);
        /// <summary>
        /// Returns a list of photos in which a user is tagged.
        /// </summary>
        Task<ApiRequest<PhotosGetUserPhotosResponse>> GetUserPhotos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null);
        /// <summary>
        /// Deletes a photo album belonging to the current user.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? albumId = null, int? groupId = null);
        /// <summary>
        /// Deletes a photo.
        /// </summary>
        Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? photoId = null);
        /// <summary>
        /// Restores a deleted photo.
        /// </summary>
        Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? photoId = null);
        /// <summary>
        /// Confirms a tag on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> ConfirmTag(UserAccessToken accessToken, int? ownerId = null, string photoId = null, int? tagId = null);
        /// <summary>
        /// Returns a list of comments on a photo.
        /// </summary>
        Task<ApiRequest<PhotosGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of comments on a photo.
        /// </summary>
        Task<ApiRequest<PhotosGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, bool? extended = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of comments on a specific photo album or all albums of the user sorted in reverse chronological order.
        /// </summary>
        Task<ApiRequest<PhotosGetAllCommentsResponse>> GetAllComments(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, bool? needLikes = null, int? offset = null, int? count = null);
        /// <summary>
        /// Adds a new comment on the photo.
        /// </summary>
        Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string accessKey = null, string guid = null);
        /// <summary>
        /// Deletes a comment on the photo.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Restores a deleted comment on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null);
        /// <summary>
        /// Edits a comment on a photo.
        /// </summary>
        Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null);
        /// <summary>
        /// Returns a list of tags on a photo.
        /// </summary>
        Task<ApiRequest<IEnumerable<PhotosPhotoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null);
        /// <summary>
        /// Adds a tag on the photo.
        /// </summary>
        Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? userId = null, double? x = null, double? y = null, double? x2 = null, double? y2 = null);
        /// <summary>
        /// Removes a tag from a photo.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? tagId = null);
        /// <summary>
        /// Returns a list of photos with tags that have not been viewed.
        /// </summary>
        Task<ApiRequest<PhotosGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null);
    }
}
