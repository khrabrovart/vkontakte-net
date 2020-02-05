using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Photos : IPhotos
    {
        /// <summary>
        /// Confirms a tag on a photo.
        /// </summary>
        public Task<ApiRequest<bool?>> ConfirmTagApi(int? ownerId = null, string photoId = null, int? tagId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId,
                ["tag_id"] = tagId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.confirmTag", null, request);
        }

        /// <summary>
        /// Allows to copy a photo to the "Saved photos" album.
        /// </summary>
        public Task<ApiRequest<int?>> CopyApi(int? ownerId = null, int? photoId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<int?>("photos.copy", null, request);
        }

        /// <summary>
        /// Creates an empty photo album.
        /// </summary>
        public Task<ApiRequest<PhotosPhotoAlbumFull>> CreateAlbumApi(string title = null, int? groupId = null, string description = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null)
        {
            var request = new Dictionary<string, string>
            {
                ["title"] = title,
                ["group_id"] = groupId?.ToString(),
                ["description"] = description,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["upload_by_admins_only"] = RequestHelpers.ParseBoolean(uploadByAdminsOnly),
                ["comments_disabled"] = RequestHelpers.ParseBoolean(commentsDisabled),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoAlbumFull>("photos.createAlbum", null, request);
        }

        /// <summary>
        /// Adds a new comment on the photo.
        /// </summary>
        public Task<ApiRequest<int?>> CreateCommentApi(int? ownerId = null, int? photoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string accessKey = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["sticker_id"] = stickerId?.ToString(),
                ["access_key"] = accessKey,
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("photos.createComment", null, request);
        }

        /// <summary>
        /// Deletes a photo.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? photoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.delete", null, request);
        }

        /// <summary>
        /// Deletes a photo album belonging to the current user.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteAlbumApi(int? albumId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["album_id"] = albumId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.deleteAlbum", null, request);
        }

        /// <summary>
        /// Deletes a comment on the photo.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteCommentApi(int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.deleteComment", null, request);
        }

        /// <summary>
        /// Edits the caption of a photo.
        /// </summary>
        public Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? photoId = null, string caption = null, double? latitude = null, double? longitude = null, string placeStr = null, string foursquareId = null, bool? deletePlace = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["caption"] = caption,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["place_str"] = placeStr,
                ["foursquare_id"] = foursquareId,
                ["delete_place"] = RequestHelpers.ParseBoolean(deletePlace),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.edit", null, request);
        }

        /// <summary>
        /// Edits information about a photo album.
        /// </summary>
        public Task<ApiRequest<bool?>> EditAlbumApi(int? albumId = null, string title = null, string description = null, int? ownerId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null)
        {
            var request = new Dictionary<string, string>
            {
                ["album_id"] = albumId?.ToString(),
                ["title"] = title,
                ["description"] = description,
                ["owner_id"] = ownerId?.ToString(),
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["upload_by_admins_only"] = RequestHelpers.ParseBoolean(uploadByAdminsOnly),
                ["comments_disabled"] = RequestHelpers.ParseBoolean(commentsDisabled),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.editAlbum", null, request);
        }

        /// <summary>
        /// Edits a comment on a photo.
        /// </summary>
        public Task<ApiRequest<bool?>> EditCommentApi(int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.editComment", null, request);
        }

        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        public Task<ApiRequest<PhotosGetResponse>> GetApi(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["feed_type"] = feedType,
                ["feed"] = feed?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", null, request);
        }

        /// <summary>
        /// Returns a list of a user's or community's photos.
        /// </summary>
        public Task<ApiRequest<PhotosGetExtendedResponse>> GetApi(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, int? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["feed_type"] = feedType,
                ["feed"] = feed?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", null, request);
        }

        /// <summary>
        /// Returns a list of a user's or community's photo albums.
        /// </summary>
        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbumsApi(int? ownerId = null, IEnumerable<int> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["need_system"] = RequestHelpers.ParseBoolean(needSystem),
                ["need_covers"] = RequestHelpers.ParseBoolean(needCovers),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", null, request);
        }

        /// <summary>
        /// Returns the number of photo albums belonging to a user or community.
        /// </summary>
        public Task<ApiRequest<int?>> GetAlbumsCountApi(int? userId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("photos.getAlbumsCount", null, request);
        }

        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// </summary>
        public Task<ApiRequest<PhotosGetAllResponse>> GetAllApi(int? ownerId = null, bool? extended = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["no_service_albums"] = RequestHelpers.ParseBoolean(noServiceAlbums),
                ["need_hidden"] = RequestHelpers.ParseBoolean(needHidden),
                ["skip_hidden"] = RequestHelpers.ParseBoolean(skipHidden),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAllResponse>("photos.getAll", null, request);
        }

        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// </summary>
        public Task<ApiRequest<PhotosGetAllExtendedResponse>> GetAllApi(int? ownerId = null, bool? extended = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["no_service_albums"] = RequestHelpers.ParseBoolean(noServiceAlbums),
                ["need_hidden"] = RequestHelpers.ParseBoolean(needHidden),
                ["skip_hidden"] = RequestHelpers.ParseBoolean(skipHidden),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAllExtendedResponse>("photos.getAll", null, request);
        }

        /// <summary>
        /// Returns a list of comments on a specific photo album or all albums of the user sorted in reverse chronological order.
        /// </summary>
        public Task<ApiRequest<PhotosGetAllCommentsResponse>> GetAllCommentsApi(int? ownerId = null, int? albumId = null, bool? needLikes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAllCommentsResponse>("photos.getAllComments", null, request);
        }

        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetByIdApi(IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", null, request);
        }

        /// <summary>
        /// Returns information about photos by their IDs.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdApi(IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", null, request);
        }

        /// <summary>
        /// Returns an upload link for chat cover pictures.
        /// </summary>
        public Task<ApiRequest<BaseUploadServer>> GetChatUploadServerApi(int? chatId = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            var request = new Dictionary<string, string>
            {
                ["chat_id"] = chatId?.ToString(),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_width"] = cropWidth?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BaseUploadServer>("photos.getChatUploadServer", null, request);
        }

        /// <summary>
        /// Returns a list of comments on a photo.
        /// </summary>
        public Task<ApiRequest<PhotosGetCommentsResponse>> GetCommentsApi(int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, bool? extended = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["access_key"] = accessKey,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<PhotosGetCommentsResponse>("photos.getComments", null, request);
        }

        /// <summary>
        /// Returns a list of comments on a photo.
        /// </summary>
        public Task<ApiRequest<PhotosGetCommentsExtendedResponse>> GetCommentsApi(int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, bool? extended = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["access_key"] = accessKey,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<PhotosGetCommentsExtendedResponse>("photos.getComments", null, request);
        }

        /// <summary>
        /// Returns the server address for market album photo upload.
        /// </summary>
        public Task<ApiRequest<BaseUploadServer>> GetMarketAlbumUploadServerApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BaseUploadServer>("photos.getMarketAlbumUploadServer", null, request);
        }

        /// <summary>
        /// Returns the server address for market photo upload.
        /// </summary>
        public Task<ApiRequest<BaseUploadServer>> GetMarketUploadServerApi(int? groupId = null, bool? mainPhoto = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["main_photo"] = RequestHelpers.ParseBoolean(mainPhoto),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_width"] = cropWidth?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BaseUploadServer>("photos.getMarketUploadServer", null, request);
        }

        /// <summary>
        /// Returns the server address for photo upload in a private message for a user.
        /// </summary>
        public Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServerApi(int? peerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["peer_id"] = peerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getMessagesUploadServer", null, request);
        }

        /// <summary>
        /// Returns a list of photos with tags that have not been viewed.
        /// </summary>
        public Task<ApiRequest<PhotosGetNewTagsResponse>> GetNewTagsApi(int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetNewTagsResponse>("photos.getNewTags", null, request);
        }

        /// <summary>
        /// Returns the server address for owner cover upload.
        /// </summary>
        public Task<ApiRequest<BaseUploadServer>> GetOwnerCoverPhotoUploadServerApi(int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_x2"] = cropX2?.ToString(),
                ["crop_y2"] = cropY2?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BaseUploadServer>("photos.getOwnerCoverPhotoUploadServer", null, request);
        }

        /// <summary>
        /// Returns an upload server address for a profile or community photo.
        /// </summary>
        public Task<ApiRequest<BaseUploadServer>> GetOwnerPhotoUploadServerApi(int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BaseUploadServer>("photos.getOwnerPhotoUploadServer", null, request);
        }

        /// <summary>
        /// Returns a list of tags on a photo.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PhotosPhotoTag>>> GetTagsApi(int? ownerId = null, int? photoId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoTag>>("photos.getTags", null, request);
        }

        /// <summary>
        /// Returns the server address for photo upload.
        /// </summary>
        public Task<ApiRequest<PhotosPhotoUpload>> GetUploadServerApi(int? groupId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getUploadServer", null, request);
        }

        /// <summary>
        /// Returns a list of photos in which a user is tagged.
        /// </summary>
        public Task<ApiRequest<PhotosGetUserPhotosResponse>> GetUserPhotosApi(int? userId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<PhotosGetUserPhotosResponse>("photos.getUserPhotos", null, request);
        }

        /// <summary>
        /// Returns a list of photos in which a user is tagged.
        /// </summary>
        public Task<ApiRequest<PhotosGetUserPhotosExtendedResponse>> GetUserPhotosApi(int? userId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<PhotosGetUserPhotosExtendedResponse>("photos.getUserPhotos", null, request);
        }

        /// <summary>
        /// Returns the server address for photo upload onto a user's wall.
        /// </summary>
        public Task<ApiRequest<PhotosPhotoUpload>> GetWallUploadServerApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getWallUploadServer", null, request);
        }

        /// <summary>
        /// Makes a photo into an album cover.
        /// </summary>
        public Task<ApiRequest<bool?>> MakeCoverApi(int? ownerId = null, int? photoId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.makeCover", null, request);
        }

        /// <summary>
        /// Moves a photo from one album to another.
        /// </summary>
        public Task<ApiRequest<bool?>> MoveApi(int? ownerId = null, int? targetAlbumId = null, int? photoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["target_album_id"] = targetAlbumId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.move", null, request);
        }

        /// <summary>
        /// Adds a tag on the photo.
        /// </summary>
        public Task<ApiRequest<int?>> PutTagApi(int? ownerId = null, int? photoId = null, int? userId = null, double? x = null, double? y = null, double? x2 = null, double? y2 = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["x"] = x?.ToString(),
                ["y"] = y?.ToString(),
                ["x2"] = x2?.ToString(),
                ["y2"] = y2?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("photos.putTag", null, request);
        }

        /// <summary>
        /// Removes a tag from a photo.
        /// </summary>
        public Task<ApiRequest<bool?>> RemoveTagApi(int? ownerId = null, int? photoId = null, int? tagId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["tag_id"] = tagId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.removeTag", null, request);
        }

        /// <summary>
        /// Reorders the album in the list of user albums.
        /// </summary>
        public Task<ApiRequest<bool?>> ReorderAlbumsApi(int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.reorderAlbums", null, request);
        }

        /// <summary>
        /// Reorders the photo in the list of photos of the user album.
        /// </summary>
        public Task<ApiRequest<bool?>> ReorderPhotosApi(int? ownerId = null, int? photoId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.reorderPhotos", null, request);
        }

        /// <summary>
        /// Reports (submits a complaint about) a photo.
        /// </summary>
        public Task<ApiRequest<bool?>> ReportApi(int? ownerId = null, int? photoId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.report", null, request);
        }

        /// <summary>
        /// Reports (submits a complaint about) a comment on a photo.
        /// </summary>
        public Task<ApiRequest<bool?>> ReportCommentApi(int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.reportComment", null, request);
        }

        /// <summary>
        /// Restores a deleted photo.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreApi(int? ownerId = null, int? photoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.restore", null, request);
        }

        /// <summary>
        /// Restores a deleted comment on a photo.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreCommentApi(int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.restoreComment", null, request);
        }

        /// <summary>
        /// Saves photos after successful uploading.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveApi(int? albumId = null, int? groupId = null, int? server = null, string photosList = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null)
        {
            var request = new Dictionary<string, string>
            {
                ["album_id"] = albumId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["server"] = server?.ToString(),
                ["photos_list"] = photosList,
                ["hash"] = hash,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["caption"] = caption,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.save", null, request);
        }

        /// <summary>
        /// Saves market album photos after successful uploading.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhotoApi(int? groupId = null, string photo = null, int? server = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMarketAlbumPhoto", null, request);
        }

        /// <summary>
        /// Saves market photos after successful uploading.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketPhotoApi(int? groupId = null, string photo = null, int? server = null, string hash = null, string cropData = null, string cropHash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
                ["crop_data"] = cropData,
                ["crop_hash"] = cropHash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMarketPhoto", null, request);
        }

        /// <summary>
        /// Saves a photo after being successfully uploaded. URL obtained with [vk.com/dev/photos.getMessagesUploadServer|photos.getMessagesUploadServer] method.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhotoApi(string photo = null, int? server = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMessagesPhoto", null, request);
        }

        /// <summary>
        /// Saves cover photo after successful uploading.
        /// </summary>
        public Task<ApiRequest<IEnumerable<BaseImage>>> SaveOwnerCoverPhotoApi(string hash = null, string photo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["hash"] = hash,
                ["photo"] = photo,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseImage>>("photos.saveOwnerCoverPhoto", null, request);
        }

        /// <summary>
        /// Saves a profile or community photo. Upload URL can be got with the [vk.com/dev/photos.getOwnerPhotoUploadServer|photos.getOwnerPhotoUploadServer] method.
        /// </summary>
        public Task<ApiRequest<PhotosSaveOwnerPhotoResponse>> SaveOwnerPhotoApi(string server = null, string hash = null, string photo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["server"] = server,
                ["hash"] = hash,
                ["photo"] = photo,
            };

            return RequestManager.CreateRequestAsync<PhotosSaveOwnerPhotoResponse>("photos.saveOwnerPhoto", null, request);
        }

        /// <summary>
        /// Saves a photo to a user's or community's wall after being uploaded.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveWallPhotoApi(int? userId = null, int? groupId = null, string photo = null, int? server = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["caption"] = caption,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveWallPhoto", null, request);
        }

        /// <summary>
        /// Returns a list of photos.
        /// </summary>
        public Task<ApiRequest<PhotosSearchResponse>> SearchApi(string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["sort"] = sort?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["radius"] = radius?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosSearchResponse>("photos.search", null, request);
        }
    }
}
