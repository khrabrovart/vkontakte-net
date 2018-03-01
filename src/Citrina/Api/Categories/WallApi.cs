using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class WallApi : IWallApi
    {
        public Task<ApiRequest<WallGetResponse>> Get(
            UserAccessToken accessToken,
            int? ownerId,
            string domain,
            int? offset,
            int? count,
            string filter,
            IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetResponse>("wall.get", accessToken, request);
        }

        public Task<ApiRequest<WallGetExtendedResponse>> GetExtended(
            UserAccessToken accessToken,
            int? ownerId,
            string domain,
            int? offset,
            int? count,
            string filter,
            bool? extended,
            IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetExtendedResponse>("wall.get", accessToken, request);
        }

        public Task<ApiRequest<WallGetResponse>> Get(
            ServiceAccessToken accessToken,
            int? ownerId,
            string domain,
            int? offset,
            int? count,
            string filter,
            IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetResponse>("wall.get", accessToken, request);
        }

        public Task<ApiRequest<WallGetExtendedResponse>> GetExtended(
            ServiceAccessToken accessToken,
            int? ownerId,
            string domain,
            int? offset,
            int? count,
            string filter,
            bool? extended,
            IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetExtendedResponse>("wall.get", accessToken, request);
        }

        public Task<ApiRequest<WallSearchResponse>> Search(UserAccessToken accessToken, int? ownerId, string domain, string query, bool? ownersOnly, int? count, int? offset, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchResponse>("wall.search", accessToken, request);
        }

        public Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId, string domain, string query, bool? ownersOnly, int? count, int? offset, bool? extended, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchExtendedResponse>("wall.search", accessToken, request);
        }

        public Task<ApiRequest<WallSearchResponse>> Search(ServiceAccessToken accessToken, int? ownerId, string domain, string query, bool? ownersOnly, int? count, int? offset, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchResponse>("wall.search", accessToken, request);
        }

        public Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(ServiceAccessToken accessToken, int? ownerId, string domain, string query, bool? ownersOnly, int? count, int? offset, bool? extended, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchExtendedResponse>("wall.search", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(UserAccessToken accessToken, IEnumerable<string> posts, int? copyHistoryDepth, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", accessToken, request);
        }

        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> posts, bool? extended, int? copyHistoryDepth, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetByIdExtendedResponse>("wall.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(IEnumerable<string> posts, int? copyHistoryDepth, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", null, request);
        }

        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(IEnumerable<string> posts, bool? extended, int? copyHistoryDepth, IEnumerable<string> fields)
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

        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> posts, int? copyHistoryDepth, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", accessToken, request);
        }

        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> posts, bool? extended, int? copyHistoryDepth, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetByIdExtendedResponse>("wall.getById", accessToken, request);
        }

        public Task<ApiRequest<WallPostResponse>> Post(UserAccessToken accessToken, int? ownerId, bool? friendsOnly, bool? fromGroup, string message, IEnumerable<string> attachments, string services, bool? signed, DateTime? publishDate, double? lat, double? @long, int? placeId, int? postId, string guid, bool? markAsAds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["services"] = services,
                ["signed"] = RequestHelpers.ParseBoolean(signed),
                ["publish_date"] = RequestHelpers.ParseDateTime(publishDate),
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["place_id"] = placeId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["guid"] = guid,
                ["mark_as_ads"] = RequestHelpers.ParseBoolean(markAsAds),
            };

            return RequestManager.CreateRequestAsync<WallPostResponse>("wall.post", accessToken, request);
        }

        public Task<ApiRequest<WallRepostResponse>> Repost(UserAccessToken accessToken, string @object, string message, int? groupId, bool? markAsAds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["object"] = @object,
                ["message"] = message,
                ["group_id"] = groupId?.ToString(),
                ["mark_as_ads"] = RequestHelpers.ParseBoolean(markAsAds),
            };

            return RequestManager.CreateRequestAsync<WallRepostResponse>("wall.repost", accessToken, request);
        }

        public Task<ApiRequest<WallGetRepostsResponse>> GetReposts(UserAccessToken accessToken, int? ownerId, int? postId, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetRepostsResponse>("wall.getReposts", accessToken, request);
        }

        public Task<ApiRequest<WallGetRepostsResponse>> GetReposts(int? ownerId, int? postId, int? offset, int? count)
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

        public Task<ApiRequest<WallGetRepostsResponse>> GetReposts(ServiceAccessToken accessToken, int? ownerId, int? postId, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetRepostsResponse>("wall.getReposts", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId, int? postId, bool? friendsOnly, string message, IEnumerable<string> attachments, string services, bool? signed, DateTime? publishDate, double? lat, double? @long, int? placeId, bool? markAsAds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["services"] = services,
                ["signed"] = RequestHelpers.ParseBoolean(signed),
                ["publish_date"] = RequestHelpers.ParseDateTime(publishDate),
                ["lat"] = lat?.ToString(),
                ["long"] = @long?.ToString(),
                ["place_id"] = placeId?.ToString(),
                ["mark_as_ads"] = RequestHelpers.ParseBoolean(markAsAds),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId, int? postId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId, int? postId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Pin(UserAccessToken accessToken, int? ownerId, int? postId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.pin", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Unpin(UserAccessToken accessToken, int? ownerId, int? postId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.unpin", accessToken, request);
        }

        public Task<ApiRequest<WallGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId, int? postId, bool? needLikes, int? startCommentId, int? offset, int? count, string sort, int? previewLength)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", accessToken, request);
        }

        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId, int? postId, bool? needLikes, int? startCommentId, int? offset, int? count, string sort, int? previewLength, bool? extended)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", accessToken, request);
        }

        public Task<ApiRequest<WallGetCommentsResponse>> GetComments(int? ownerId, int? postId, bool? needLikes, int? startCommentId, int? offset, int? count, string sort, int? previewLength)
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
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", null, request);
        }

        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(int? ownerId, int? postId, bool? needLikes, int? startCommentId, int? offset, int? count, string sort, int? previewLength, bool? extended)
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
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", null, request);
        }

        public Task<ApiRequest<WallGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? ownerId, int? postId, bool? needLikes, int? startCommentId, int? offset, int? count, string sort, int? previewLength)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", accessToken, request);
        }

        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? ownerId, int? postId, bool? needLikes, int? startCommentId, int? offset, int? count, string sort, int? previewLength, bool? extended)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", accessToken, request);
        }

        public Task<ApiRequest<WallCreateCommentResponse>> CreateComment(UserAccessToken accessToken, int? ownerId, int? postId, int? fromGroup, string message, int? replyToComment, IEnumerable<string> attachments, int? stickerId, string guid)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["from_group"] = fromGroup?.ToString(),
                ["message"] = message,
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<WallCreateCommentResponse>("wall.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId, int? commentId, string message, IEnumerable<string> attachments)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.editComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId, int? commentId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId, int? commentId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReportPost(UserAccessToken accessToken, int? ownerId, int? postId, int? reason)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.reportPost", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId, int? commentId, int? reason)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.reportComment", accessToken, request);
        }
    }
}
