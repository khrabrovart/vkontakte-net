using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Wall : IWall
    {
        public Task<ApiRequest<bool?>> CloseCommentsApi(int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.closeComments", null, request);
        }

        /// <summary>
        /// Adds a comment to a post on a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<WallCreateCommentResponse>> CreateCommentApi(int? ownerId = null, int? postId = null, int? fromGroup = null, string message = null, int? replyToComment = null, IEnumerable<string> attachments = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["from_group"] = fromGroup?.ToString(),
                ["message"] = message,
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<WallCreateCommentResponse>("wall.createComment", null, request);
        }

        /// <summary>
        /// Deletes a post from a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.delete", null, request);
        }

        /// <summary>
        /// Deletes a comment on a post on a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteCommentApi(int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.deleteComment", null, request);
        }

        /// <summary>
        /// Edits a post on a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<WallEditResponse>> EditApi(int? ownerId = null, int? postId = null, bool? friendsOnly = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, int? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, bool? markAsAds = null, bool? closeComments = null, int? posterBkgId = null, int? posterBkgOwnerId = null, string posterBkgAccessHash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["services"] = services,
                ["signed"] = RequestHelpers.ParseBoolean(signed),
                ["publish_date"] = publishDate?.ToString(),
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["place_id"] = placeId?.ToString(),
                ["mark_as_ads"] = RequestHelpers.ParseBoolean(markAsAds),
                ["close_comments"] = RequestHelpers.ParseBoolean(closeComments),
                ["poster_bkg_id"] = posterBkgId?.ToString(),
                ["poster_bkg_owner_id"] = posterBkgOwnerId?.ToString(),
                ["poster_bkg_access_hash"] = posterBkgAccessHash,
            };

            return RequestManager.CreateRequestAsync<WallEditResponse>("wall.edit", null, request);
        }

        /// <summary>
        /// Allows to edit hidden post.
        /// </summary>
        public Task<ApiRequest<bool?>> EditAdsStealthApi(int? ownerId = null, int? postId = null, string message = null, IEnumerable<string> attachments = null, bool? signed = null, double? lat = null, double? @long = null, int? placeId = null, string linkButton = null, string linkTitle = null, string linkImage = null, string linkVideo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["signed"] = RequestHelpers.ParseBoolean(signed),
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["place_id"] = placeId?.ToString(),
                ["link_button"] = linkButton,
                ["link_title"] = linkTitle,
                ["link_image"] = linkImage,
                ["link_video"] = linkVideo,
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.editAdsStealth", null, request);
        }

        /// <summary>
        /// Edits a comment on a user wall or community wall.
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

            return RequestManager.CreateRequestAsync<bool?>("wall.editComment", null, request);
        }

        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<WallGetResponse>> GetApi(int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetResponse>("wall.get", null, request);
        }

        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<WallGetExtendedResponse>> GetApi(int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetExtendedResponse>("wall.get", null, request);
        }

        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetByIdApi(IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", null, request);
        }

        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// </summary>
        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdApi(IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetByIdExtendedResponse>("wall.getById", null, request);
        }

        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<WallGetCommentsResponse>> GetCommentsApi(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null, int? commentId = null, int? threadItemsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["comment_id"] = commentId?.ToString(),
                ["thread_items_count"] = threadItemsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", null, request);
        }

        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsApi(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null, int? commentId = null, int? threadItemsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["comment_id"] = commentId?.ToString(),
                ["thread_items_count"] = threadItemsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", null, request);
        }

        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// </summary>
        public Task<ApiRequest<WallGetRepostsResponse>> GetRepostsApi(int? ownerId = null, int? postId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetRepostsResponse>("wall.getReposts", null, request);
        }

        public Task<ApiRequest<bool?>> OpenCommentsApi(int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.openComments", null, request);
        }

        /// <summary>
        /// Pins the post on wall.
        /// </summary>
        public Task<ApiRequest<bool?>> PinApi(int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.pin", null, request);
        }

        /// <summary>
        /// Adds a new post on a user wall or community wall. Can also be used to publish suggested or scheduled posts.
        /// </summary>
        public Task<ApiRequest<WallPostResponse>> PostApi(int? ownerId = null, bool? friendsOnly = null, bool? fromGroup = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, int? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, int? postId = null, string guid = null, bool? markAsAds = null, bool? closeComments = null, bool? muteNotifications = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["services"] = services,
                ["signed"] = RequestHelpers.ParseBoolean(signed),
                ["publish_date"] = publishDate?.ToString(),
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["place_id"] = placeId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["guid"] = guid,
                ["mark_as_ads"] = RequestHelpers.ParseBoolean(markAsAds),
                ["close_comments"] = RequestHelpers.ParseBoolean(closeComments),
                ["mute_notifications"] = RequestHelpers.ParseBoolean(muteNotifications),
            };

            return RequestManager.CreateRequestAsync<WallPostResponse>("wall.post", null, request);
        }

        /// <summary>
        /// Allows to create hidden post which will not be shown on the community's wall and can be used for creating an ad with type "Community post".
        /// </summary>
        public Task<ApiRequest<WallPostAdsStealthResponse>> PostAdsStealthApi(int? ownerId = null, string message = null, IEnumerable<string> attachments = null, bool? signed = null, double? lat = null, double? @long = null, int? placeId = null, string guid = null, string linkButton = null, string linkTitle = null, string linkImage = null, string linkVideo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["signed"] = RequestHelpers.ParseBoolean(signed),
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["place_id"] = placeId?.ToString(),
                ["guid"] = guid,
                ["link_button"] = linkButton,
                ["link_title"] = linkTitle,
                ["link_image"] = linkImage,
                ["link_video"] = linkVideo,
            };

            return RequestManager.CreateRequestAsync<WallPostAdsStealthResponse>("wall.postAdsStealth", null, request);
        }

        /// <summary>
        /// Reports (submits a complaint about) a comment on a post on a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<bool?>> ReportCommentApi(int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.reportComment", null, request);
        }

        /// <summary>
        /// Reports (submits a complaint about) a post on a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<bool?>> ReportPostApi(int? ownerId = null, int? postId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.reportPost", null, request);
        }

        /// <summary>
        /// Reposts (copies) an object to a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<WallRepostResponse>> RepostApi(string @object = null, string message = null, int? groupId = null, bool? markAsAds = null, bool? muteNotifications = null)
        {
            var request = new Dictionary<string, string>
            {
                ["object"] = @object,
                ["message"] = message,
                ["group_id"] = groupId?.ToString(),
                ["mark_as_ads"] = RequestHelpers.ParseBoolean(markAsAds),
                ["mute_notifications"] = RequestHelpers.ParseBoolean(muteNotifications),
            };

            return RequestManager.CreateRequestAsync<WallRepostResponse>("wall.repost", null, request);
        }

        /// <summary>
        /// Restores a post deleted from a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreApi(int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.restore", null, request);
        }

        /// <summary>
        /// Restores a comment deleted from a user wall or community wall.
        /// </summary>
        public Task<ApiRequest<bool?>> RestoreCommentApi(int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.restoreComment", null, request);
        }

        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        public Task<ApiRequest<WallSearchResponse>> SearchApi(int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchResponse>("wall.search", null, request);
        }

        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        public Task<ApiRequest<WallSearchExtendedResponse>> SearchApi(int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchExtendedResponse>("wall.search", null, request);
        }

        /// <summary>
        /// Unpins the post on wall.
        /// </summary>
        public Task<ApiRequest<bool?>> UnpinApi(int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.unpin", null, request);
        }
    }
}
