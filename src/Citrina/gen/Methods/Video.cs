using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Video : IVideo
    {
        /// <summary>
        /// Adds a video to a user or community page.
        /// </summary>
        public Task<ApiRequest<bool?>> AddApi(int? targetId = null, int? videoId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.add", null, request);
        }

        /// <summary>
        /// Creates an empty album for videos.
        /// </summary>
        public Task<ApiRequest<VideoAddAlbumResponse>> AddAlbumApi(int? groupId = null, string title = null, IEnumerable<string> privacy = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["title"] = title,
                ["privacy"] = RequestHelpers.ParseEnumerable(privacy),
            };

            return RequestManager.CreateRequestAsync<VideoAddAlbumResponse>("video.addAlbum", null, request);
        }

        public Task<ApiRequest<bool?>> AddToAlbumApi(int? targetId = null, int? albumId = null, IEnumerable<int> albumIds = null, int? ownerId = null, int? videoId = null)
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

        /// <summary>
        /// Adds a new comment on a video.
        /// </summary>
        public Task<ApiRequest<int?>> CreateCommentApi(int? ownerId = null, int? videoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("video.createComment", null, request);
        }

        /// <summary>
        /// Deletes a video from a user or community page.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteApi(int? videoId = null, int? ownerId = null, int? targetId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["video_id"] = videoId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["target_id"] = targetId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.delete", null, request);
        }

        /// <summary>
        /// Deletes a video album.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteAlbumApi(int? groupId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.deleteAlbum", null, request);
        }

        /// <summary>
        /// Deletes a comment on a video.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteCommentApi(int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.deleteComment", null, request);
        }

        /// <summary>
        /// Edits information about a video on a user or community page.
        /// </summary>
        public Task<ApiRequest<bool?>> EditApi(int? ownerId = null, int? videoId = null, string name = null, string desc = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["name"] = name,
                ["desc"] = desc,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["no_comments"] = RequestHelpers.ParseBoolean(noComments),
                ["repeat"] = RequestHelpers.ParseBoolean(repeat),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.edit", null, request);
        }

        /// <summary>
        /// Edits the title of a video album.
        /// </summary>
        public Task<ApiRequest<bool?>> EditAlbumApi(int? groupId = null, int? albumId = null, string title = null, IEnumerable<string> privacy = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["title"] = title,
                ["privacy"] = RequestHelpers.ParseEnumerable(privacy),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.editAlbum", null, request);
        }

        /// <summary>
        /// Edits the text of a comment on a video.
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

            return RequestManager.CreateRequestAsync<bool?>("video.editComment", null, request);
        }

        /// <summary>
        /// Returns detailed information about videos.
        /// </summary>
        public Task<ApiRequest<VideoGetResponse>> GetApi(int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["videos"] = RequestHelpers.ParseEnumerable(videos),
                ["album_id"] = albumId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetResponse>("video.get", null, request);
        }

        /// <summary>
        /// Returns detailed information about videos.
        /// </summary>
        public Task<ApiRequest<VideoGetExtendedResponse>> GetApi(int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["videos"] = RequestHelpers.ParseEnumerable(videos),
                ["album_id"] = albumId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetExtendedResponse>("video.get", null, request);
        }

        /// <summary>
        /// Returns video album info.
        /// </summary>
        public Task<ApiRequest<VideoVideoAlbumFull>> GetAlbumByIdApi(int? ownerId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoVideoAlbumFull>("video.getAlbumById", null, request);
        }

        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// </summary>
        public Task<ApiRequest<VideoGetAlbumsResponse>> GetAlbumsApi(int? ownerId = null, int? offset = null, int? count = null, bool? extended = null, bool? needSystem = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["need_system"] = RequestHelpers.ParseBoolean(needSystem),
            };

            return RequestManager.CreateRequestAsync<VideoGetAlbumsResponse>("video.getAlbums", null, request);
        }

        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// </summary>
        public Task<ApiRequest<VideoGetAlbumsExtendedResponse>> GetAlbumsApi(int? ownerId = null, int? offset = null, int? count = null, bool? extended = null, bool? needSystem = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["need_system"] = RequestHelpers.ParseBoolean(needSystem),
            };

            return RequestManager.CreateRequestAsync<VideoGetAlbumsExtendedResponse>("video.getAlbums", null, request);
        }

        public Task<ApiRequest<IEnumerable<int>>> GetAlbumsByVideoApi(int? targetId = null, int? ownerId = null, int? videoId = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("video.getAlbumsByVideo", null, request);
        }

        public Task<ApiRequest<VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoApi(int? targetId = null, int? ownerId = null, int? videoId = null, bool? extended = null)
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

        /// <summary>
        /// Returns a list of comments on a video.
        /// </summary>
        public Task<ApiRequest<VideoGetCommentsResponse>> GetCommentsApi(int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<VideoGetCommentsResponse>("video.getComments", null, request);
        }

        /// <summary>
        /// Returns a list of comments on a video.
        /// </summary>
        public Task<ApiRequest<VideoGetCommentsExtendedResponse>> GetCommentsApi(int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<VideoGetCommentsExtendedResponse>("video.getComments", null, request);
        }

        public Task<ApiRequest<bool?>> RemoveFromAlbumApi(int? targetId = null, int? albumId = null, IEnumerable<int> albumIds = null, int? ownerId = null, int? videoId = null)
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

        /// <summary>
        /// Reorders the album in the list of user video albums.
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

            return RequestManager.CreateRequestAsync<bool?>("video.reorderAlbums", null, request);
        }

        /// <summary>
        /// Reorders the video in the video album.
        /// </summary>
        public Task<ApiRequest<bool?>> ReorderVideosApi(int? targetId = null, int? albumId = null, int? ownerId = null, int? videoId = null, int? beforeOwnerId = null, int? beforeVideoId = null, int? afterOwnerId = null, int? afterVideoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["before_owner_id"] = beforeOwnerId?.ToString(),
                ["before_video_id"] = beforeVideoId?.ToString(),
                ["after_owner_id"] = afterOwnerId?.ToString(),
                ["after_video_id"] = afterVideoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.reorderVideos", null, request);
        }

        /// <summary>
        /// Reports (submits a complaint about) a video.
        /// </summary>
        public Task<ApiRequest<bool?>> ReportApi(int? ownerId = null, int? videoId = null, int? reason = null, string comment = null, string searchQuery = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["reason"] = reason?.ToString(),
                ["comment"] = comment,
                ["search_query"] = searchQuery,
            };

            return RequestManager.CreateRequestAsync<bool?>("video.report", null, request);
        }

        /// <summary>
        /// Reports (submits a complaint about) a comment on a video.
        /// </summary>
        public Task<ApiRequest<bool?>> ReportCommentApi(int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.reportComment", null, request);
        }

        /// <summary>
        /// Restores a previously deleted video.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreApi(int? videoId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["video_id"] = videoId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.restore", null, request);
        }

        /// <summary>
        /// Restores a previously deleted comment on a video.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreCommentApi(int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.restoreComment", null, request);
        }

        /// <summary>
        /// Returns a server address (required for upload) and video data.
        /// </summary>
        public Task<ApiRequest<VideoSaveResult>> SaveApi(string name = null, string description = null, bool? isPrivate = null, bool? wallpost = null, string link = null, int? groupId = null, int? albumId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null, bool? compression = null)
        {
            var request = new Dictionary<string, string>
            {
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
                ["compression"] = RequestHelpers.ParseBoolean(compression),
            };

            return RequestManager.CreateRequestAsync<VideoSaveResult>("video.save", null, request);
        }

        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// </summary>
        public Task<ApiRequest<VideoSearchResponse>> SearchApi(string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
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

            return RequestManager.CreateRequestAsync<VideoSearchResponse>("video.search", null, request);
        }

        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// </summary>
        public Task<ApiRequest<VideoSearchExtendedResponse>> SearchApi(string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
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

            return RequestManager.CreateRequestAsync<VideoSearchExtendedResponse>("video.search", null, request);
        }
    }
}
