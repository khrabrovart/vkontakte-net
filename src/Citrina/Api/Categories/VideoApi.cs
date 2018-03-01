using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class VideoApi : IVideoApi
    {
        public Task<ApiRequest<VideoGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["videos"] = RequestHelpers.ParseEnumerable(videos),
                ["album_id"] = albumId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetResponse>("video.get", accessToken, request);
        }

        public Task<ApiRequest<VideoGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["videos"] = RequestHelpers.ParseEnumerable(videos),
                ["album_id"] = albumId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetExtendedResponse>("video.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string name = null, string desc = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["name"] = name,
                ["desc"] = desc,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["no_comments"] = RequestHelpers.ParseBoolean(noComments),
                ["repeat"] = RequestHelpers.ParseBoolean(repeat),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Add(UserAccessToken accessToken, int? targetId = null, int? videoId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["target_id"] = targetId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.add", accessToken, request);
        }

        public Task<ApiRequest<VideoSaveResult>> Save(UserAccessToken accessToken, string name = null, string description = null, bool? isPrivate = null, bool? wallpost = null, string link = null, int? groupId = null, int? albumId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["name"] = name,
                ["description"] = description,
                ["is_private"] = RequestHelpers.ParseBoolean(isPrivate),
                ["wallpost"] = RequestHelpers.ParseBoolean(wallpost),
                ["link"] = link,
                ["group_id"] = groupId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["no_comments"] = RequestHelpers.ParseBoolean(noComments),
                ["repeat"] = RequestHelpers.ParseBoolean(repeat),
            };

            return RequestManager.CreateRequestAsync<VideoSaveResult>("video.save", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? videoId = null, int? ownerId = null, int? targetId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["video_id"] = videoId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["target_id"] = targetId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? videoId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["video_id"] = videoId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.restore", accessToken, request);
        }

        public Task<ApiRequest<VideoSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["sort"] = sort?.ToString(),
                ["hd"] = hd?.ToString(),
                ["adult"] = RequestHelpers.ParseBoolean(adult),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["search_own"] = RequestHelpers.ParseBoolean(searchOwn),
                ["offset"] = offset?.ToString(),
                ["longer"] = longer?.ToString(),
                ["shorter"] = shorter?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoSearchResponse>("video.search", accessToken, request);
        }

        public Task<ApiRequest<VideoSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["sort"] = sort?.ToString(),
                ["hd"] = hd?.ToString(),
                ["adult"] = RequestHelpers.ParseBoolean(adult),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["search_own"] = RequestHelpers.ParseBoolean(searchOwn),
                ["offset"] = offset?.ToString(),
                ["longer"] = longer?.ToString(),
                ["shorter"] = shorter?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoSearchExtendedResponse>("video.search", accessToken, request);
        }

        public Task<ApiRequest<VideoGetUserVideosResponse>> GetUserVideos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetUserVideosResponse>("video.getUserVideos", accessToken, request);
        }

        public Task<ApiRequest<VideoGetUserVideosExtendedResponse>> GetUserVideosExtended(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetUserVideosExtendedResponse>("video.getUserVideos", accessToken, request);
        }

        public Task<ApiRequest<VideoGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetAlbumsResponse>("video.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<VideoGetAlbumsExtendedResponse>> GetAlbumsExtended(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetAlbumsExtendedResponse>("video.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<VideoVideoAlbumFull>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoVideoAlbumFull>("video.getAlbumById", accessToken, request);
        }

        public Task<ApiRequest<VideoAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? groupId = null, string title = null, IEnumerable<string> privacy = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["title"] = title,
                ["privacy"] = RequestHelpers.ParseEnumerable(privacy),
            };

            return RequestManager.CreateRequestAsync<VideoAddAlbumResponse>("video.addAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null, string title = null, IEnumerable<string> privacy = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["title"] = title,
                ["privacy"] = RequestHelpers.ParseEnumerable(privacy),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.editAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.deleteAlbum", accessToken, request);
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

            return RequestManager.CreateRequestAsync<bool?>("video.reorderAlbums", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderVideos(UserAccessToken accessToken, int? targetId = null, int? albumId = null, int? ownerId = null, int? videoId = null, int? beforeOwnerId = null, int? beforeVideoId = null, int? afterOwnerId = null, int? afterVideoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["target_id"] = targetId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["before_owner_id"] = beforeOwnerId?.ToString(),
                ["before_video_id"] = beforeVideoId?.ToString(),
                ["after_owner_id"] = afterOwnerId?.ToString(),
                ["after_video_id"] = afterVideoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.reorderVideos", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddToAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.addToAlbum", null, request);
        }

        public Task<ApiRequest<bool?>> RemoveFromAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.removeFromAlbum", null, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetAlbumsByVideo(int? targetId = null, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("video.getAlbumsByVideo", null, request);
        }

        public Task<ApiRequest<VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoExtended(int? targetId = null, int? ownerId = null, int? videoId = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetAlbumsByVideoExtendedResponse>("video.getAlbumsByVideo", null, request);
        }

        public Task<ApiRequest<VideoGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<VideoGetCommentsResponse>("video.getComments", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCommentsExtendedResponse>("video.getComments", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("video.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.restoreComment", accessToken, request);
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

            return RequestManager.CreateRequestAsync<bool?>("video.editComment", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<VideoVideoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<VideoVideoTag>>("video.getTags", accessToken, request);
        }

        public Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? userId = null, int? ownerId = null, int? videoId = null, string taggedName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["tagged_name"] = taggedName,
            };

            return RequestManager.CreateRequestAsync<int?>("video.putTag", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? tagId = null, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["tag_id"] = tagId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.removeTag", accessToken, request);
        }

        public Task<ApiRequest<VideoGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetNewTagsResponse>("video.getNewTags", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, int? reason = null, string comment = null, string searchQuery = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["reason"] = reason?.ToString(),
                ["comment"] = comment,
                ["search_query"] = searchQuery,
            };

            return RequestManager.CreateRequestAsync<bool?>("video.report", accessToken, request);
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

            return RequestManager.CreateRequestAsync<bool?>("video.reportComment", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogResponse>("video.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogExtendedResponse>("video.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogResponse>("video.getCatalog", null, request);
        }

        public Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogExtendedResponse>("video.getCatalog", null, request);
        }

        public Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogResponse>("video.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogExtendedResponse>("video.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionResponse>("video.getCatalogSection", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(string sectionId = null, string from = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionResponse>("video.getCatalogSection", null, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(string sectionId = null, string from = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", null, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionResponse>("video.getCatalogSection", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", accessToken, request);
        }

        public Task<ApiRequest<bool?>> HideCatalogSection(UserAccessToken accessToken, int? sectionId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.hideCatalogSection", accessToken, request);
        }

    }
}
