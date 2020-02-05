using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Stories : IStories
    {
        /// <summary>
        /// Allows to hide stories from chosen sources from current user's feed.
        /// </summary>
        public Task<ApiRequest<bool?>> BanOwnerApi(IEnumerable<int> ownersIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owners_ids"] = RequestHelpers.ParseEnumerable(ownersIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("stories.banOwner", null, request);
        }

        /// <summary>
        /// Allows to delete story.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? storyId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["story_id"] = storyId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("stories.delete", null, request);
        }

        /// <summary>
        /// Returns stories available for current user.
        /// </summary>
        public Task<ApiRequest<StoriesGetResponse>> GetApi(int? ownerId = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<StoriesGetResponse>("stories.get", null, request);
        }

        /// <summary>
        /// Returns stories available for current user.
        /// </summary>
        public Task<ApiRequest<StoriesGetExtendedResponse>> GetApi(int? ownerId = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<StoriesGetExtendedResponse>("stories.get", null, request);
        }

        /// <summary>
        /// Returns list of sources hidden from current user's feed.
        /// </summary>
        public Task<ApiRequest<StoriesGetBannedResponse>> GetBannedApi(bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<StoriesGetBannedResponse>("stories.getBanned", null, request);
        }

        /// <summary>
        /// Returns list of sources hidden from current user's feed.
        /// </summary>
        public Task<ApiRequest<StoriesGetBannedExtendedResponse>> GetBannedApi(bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<StoriesGetBannedExtendedResponse>("stories.getBanned", null, request);
        }

        /// <summary>
        /// Returns story by its ID.
        /// </summary>
        public Task<ApiRequest<StoriesGetByIdResponse>> GetByIdApi(IEnumerable<string> stories = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["stories"] = RequestHelpers.ParseEnumerable(stories),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<StoriesGetByIdResponse>("stories.getById", null, request);
        }

        /// <summary>
        /// Returns story by its ID.
        /// </summary>
        public Task<ApiRequest<StoriesGetByIdExtendedResponse>> GetByIdApi(IEnumerable<string> stories = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["stories"] = RequestHelpers.ParseEnumerable(stories),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<StoriesGetByIdExtendedResponse>("stories.getById", null, request);
        }

        /// <summary>
        /// Returns URL for uploading a story with photo.
        /// </summary>
        public Task<ApiRequest<StoriesGetPhotoUploadServerResponse>> GetPhotoUploadServerApi(bool? addToNews = null, IEnumerable<int> userIds = null, string replyToStory = null, string linkText = null, string linkUrl = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["add_to_news"] = RequestHelpers.ParseBoolean(addToNews),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["reply_to_story"] = replyToStory,
                ["link_text"] = linkText,
                ["link_url"] = linkUrl,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<StoriesGetPhotoUploadServerResponse>("stories.getPhotoUploadServer", null, request);
        }

        /// <summary>
        /// Returns replies to the story.
        /// </summary>
        public Task<ApiRequest<StoriesGetRepliesResponse>> GetRepliesApi(int? ownerId = null, int? storyId = null, string accessKey = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["story_id"] = storyId?.ToString(),
                ["access_key"] = accessKey,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<StoriesGetRepliesResponse>("stories.getReplies", null, request);
        }

        /// <summary>
        /// Returns replies to the story.
        /// </summary>
        public Task<ApiRequest<StoriesGetRepliesExtendedResponse>> GetRepliesApi(int? ownerId = null, int? storyId = null, string accessKey = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["story_id"] = storyId?.ToString(),
                ["access_key"] = accessKey,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<StoriesGetRepliesExtendedResponse>("stories.getReplies", null, request);
        }

        /// <summary>
        /// Returns stories available for current user.
        /// </summary>
        public Task<ApiRequest<StoriesStoryStats>> GetStatsApi(int? ownerId = null, int? storyId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["story_id"] = storyId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<StoriesStoryStats>("stories.getStats", null, request);
        }

        /// <summary>
        /// Allows to receive URL for uploading story with video.
        /// </summary>
        public Task<ApiRequest<StoriesGetVideoUploadServerResponse>> GetVideoUploadServerApi(bool? addToNews = null, IEnumerable<int> userIds = null, string replyToStory = null, string linkText = null, string linkUrl = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["add_to_news"] = RequestHelpers.ParseBoolean(addToNews),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["reply_to_story"] = replyToStory,
                ["link_text"] = linkText,
                ["link_url"] = linkUrl,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<StoriesGetVideoUploadServerResponse>("stories.getVideoUploadServer", null, request);
        }

        /// <summary>
        /// Returns a list of story viewers.
        /// </summary>
        public Task<ApiRequest<StoriesGetViewersResponse>> GetViewersApi(int? ownerId = null, int? storyId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["story_id"] = storyId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<StoriesGetViewersResponse>("stories.getViewers", null, request);
        }

        /// <summary>
        /// Returns a list of story viewers.
        /// </summary>
        public Task<ApiRequest<StoriesGetViewersExtendedResponse>> GetViewersApi(int? ownerId = null, int? storyId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["story_id"] = storyId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<StoriesGetViewersExtendedResponse>("stories.getViewers", null, request);
        }

        /// <summary>
        /// Hides all replies in the last 24 hours from the user to current user's stories.
        /// </summary>
        public Task<ApiRequest<bool?>> HideAllRepliesApi(int? ownerId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("stories.hideAllReplies", null, request);
        }

        /// <summary>
        /// Hides the reply to the current user's story.
        /// </summary>
        public Task<ApiRequest<bool?>> HideReplyApi(int? ownerId = null, int? storyId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["story_id"] = storyId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("stories.hideReply", null, request);
        }

        /// <summary>
        /// Allows to show stories from hidden sources in current user's feed.
        /// </summary>
        public Task<ApiRequest<bool?>> UnbanOwnerApi(IEnumerable<int> ownersIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owners_ids"] = RequestHelpers.ParseEnumerable(ownersIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("stories.unbanOwner", null, request);
        }
    }
}
