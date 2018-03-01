using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
    internal class PhotosApi : IPhotosApi
    {
        public Task<ApiRequest<PhotosPhotoAlbumFull>> CreateAlbum(UserAccessToken accessToken, string title = null, int? groupId = null, string description = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["title"] = title,
                ["group_id"] = groupId?.ToString(),
                ["description"] = description,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["upload_by_admins_only"] = RequestHelpers.ParseBoolean(uploadByAdminsOnly),
                ["comments_disabled"] = RequestHelpers.ParseBoolean(commentsDisabled),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoAlbumFull>("photos.createAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? albumId = null, string title = null, string description = null, int? ownerId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["album_id"] = albumId?.ToString(),
                ["title"] = title,
                ["description"] = description,
                ["owner_id"] = ownerId?.ToString(),
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["upload_by_admins_only"] = RequestHelpers.ParseBoolean(uploadByAdminsOnly),
                ["comments_disabled"] = RequestHelpers.ParseBoolean(commentsDisabled),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.editAlbum", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["need_system"] = RequestHelpers.ParseBoolean(needSystem),
                ["need_covers"] = RequestHelpers.ParseBoolean(needCovers),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
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

        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(ServiceAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["need_system"] = RequestHelpers.ParseBoolean(needSystem),
                ["need_covers"] = RequestHelpers.ParseBoolean(needCovers),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetResponse>> Get(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", null, request);
        }

        public Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", null, request);
        }

        public Task<ApiRequest<PhotosGetResponse>> Get(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetAlbumsCount(UserAccessToken accessToken, int? userId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("photos.getAlbumsCount", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(IEnumerable<string> photos = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", null, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", null, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", accessToken, request);
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetUploadServer(UserAccessToken accessToken, int? albumId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["album_id"] = albumId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(UserAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_x2"] = cropX2?.ToString(),
                ["crop_y2"] = cropY2?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetOwnerCoverPhotoUploadServerResponse>("photos.getOwnerCoverPhotoUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(GroupAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_x2"] = cropX2?.ToString(),
                ["crop_y2"] = cropY2?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetOwnerCoverPhotoUploadServerResponse>("photos.getOwnerCoverPhotoUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetOwnerPhotoUploadServerResponse>> GetOwnerPhotoUploadServer(UserAccessToken accessToken, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetOwnerPhotoUploadServerResponse>("photos.getOwnerPhotoUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetChatUploadServerResponse>> GetChatUploadServer(UserAccessToken accessToken, int? chatId = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_width"] = cropWidth?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetChatUploadServerResponse>("photos.getChatUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetMarketUploadServerResponse>> GetMarketUploadServer(UserAccessToken accessToken, int? groupId = null, bool? mainPhoto = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["main_photo"] = RequestHelpers.ParseBoolean(mainPhoto),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_width"] = cropWidth?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetMarketUploadServerResponse>("photos.getMarketUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetMarketAlbumUploadServerResponse>> GetMarketAlbumUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetMarketAlbumUploadServerResponse>("photos.getMarketAlbumUploadServer", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null, string cropData = null, string cropHash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
                ["crop_data"] = cropData,
                ["crop_hash"] = cropHash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMarketPhoto", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<BaseImage>>> SaveOwnerCoverPhoto(UserAccessToken accessToken, string photo = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photo"] = photo,
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseImage>>("photos.saveOwnerCoverPhoto", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMarketAlbumPhoto", accessToken, request);
        }

        public Task<ApiRequest<PhotosSaveOwnerPhotoResponse>> SaveOwnerPhoto(UserAccessToken accessToken, string server = null, string hash = null, string photo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["server"] = server,
                ["hash"] = hash,
                ["photo"] = photo,
            };

            return RequestManager.CreateRequestAsync<PhotosSaveOwnerPhotoResponse>("photos.saveOwnerPhoto", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveWallPhoto(UserAccessToken accessToken, int? userId = null, int? groupId = null, string photo = null, int? server = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["caption"] = caption,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveWallPhoto", accessToken, request);
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getWallUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getMessagesUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(GroupAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getMessagesUploadServer", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(UserAccessToken accessToken, string photo = null, int? server = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMessagesPhoto", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(GroupAccessToken accessToken, string photo = null, int? server = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMessagesPhoto", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.report", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.reportComment", accessToken, request);
        }

        public Task<ApiRequest<PhotosSearchResponse>> Search(UserAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
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

            return RequestManager.CreateRequestAsync<PhotosSearchResponse>("photos.search", accessToken, request);
        }

        public Task<ApiRequest<PhotosSearchResponse>> Search(string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
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

        public Task<ApiRequest<PhotosSearchResponse>> Search(ServiceAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
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

            return RequestManager.CreateRequestAsync<PhotosSearchResponse>("photos.search", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> Save(UserAccessToken accessToken, int? albumId = null, int? groupId = null, int? server = null, string photosList = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["album_id"] = albumId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["server"] = server?.ToString(),
                ["photos_list"] = photosList,
                ["hash"] = hash,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["caption"] = caption,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.save", accessToken, request);
        }

        public Task<ApiRequest<int?>> Copy(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<int?>("photos.copy", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string caption = null, double? latitude = null, double? longitude = null, string placeStr = null, string foursquareId = null, bool? deletePlace = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["caption"] = caption,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["place_str"] = placeStr,
                ["foursquare_id"] = foursquareId,
                ["delete_place"] = RequestHelpers.ParseBoolean(deletePlace),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Move(UserAccessToken accessToken, int? ownerId = null, int? targetAlbumId = null, int? photoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["target_album_id"] = targetAlbumId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.move", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MakeCover(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.makeCover", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.reorderAlbums", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderPhotos(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.reorderPhotos", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAllResponse>> GetAll(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["no_service_albums"] = RequestHelpers.ParseBoolean(noServiceAlbums),
                ["need_hidden"] = RequestHelpers.ParseBoolean(needHidden),
                ["skip_hidden"] = RequestHelpers.ParseBoolean(skipHidden),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAllResponse>("photos.getAll", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAllExtendedResponse>> GetAllExtended(UserAccessToken accessToken, int? ownerId = null, bool? extended = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["no_service_albums"] = RequestHelpers.ParseBoolean(noServiceAlbums),
                ["need_hidden"] = RequestHelpers.ParseBoolean(needHidden),
                ["skip_hidden"] = RequestHelpers.ParseBoolean(skipHidden),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAllExtendedResponse>("photos.getAll", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetUserPhotosResponse>> GetUserPhotos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<PhotosGetUserPhotosResponse>("photos.getUserPhotos", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? albumId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["album_id"] = albumId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.deleteAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? photoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? photoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ConfirmTag(UserAccessToken accessToken, int? ownerId = null, string photoId = null, int? tagId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId,
                ["tag_id"] = tagId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.confirmTag", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["access_key"] = accessKey,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<PhotosGetCommentsResponse>("photos.getComments", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
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

            return RequestManager.CreateRequestAsync<PhotosGetCommentsExtendedResponse>("photos.getComments", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAllCommentsResponse>> GetAllComments(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, bool? needLikes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAllCommentsResponse>("photos.getAllComments", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string accessKey = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
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

            return RequestManager.CreateRequestAsync<int?>("photos.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.editComment", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoTag>>("photos.getTags", accessToken, request);
        }

        public Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? userId = null, double? x = null, double? y = null, double? x2 = null, double? y2 = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["x"] = x?.ToString(),
                ["y"] = y?.ToString(),
                ["x2"] = x2?.ToString(),
                ["y2"] = y2?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("photos.putTag", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? tagId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["tag_id"] = tagId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.removeTag", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetNewTagsResponse>("photos.getNewTags", accessToken, request);
        }

    }
}
