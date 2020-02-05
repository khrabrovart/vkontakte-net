using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IStoriesApi
    {
        /// <summary>
        /// Allows to hide stories from chosen sources from current user's feed.
        /// </summary>
        Task<ApiRequest<bool?>> BanOwnerApi(IEnumerable<int> ownersIds = null);

        /// <summary>
        /// Allows to delete story.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteApi(int? ownerId = null, int? storyId = null);

        /// <summary>
        /// Returns stories available for current user.
        /// </summary>
        Task<ApiRequest<StoriesGetResponse>> GetApi(int? ownerId = null, bool? extended = null);

        /// <summary>
        /// Returns stories available for current user.
        /// </summary>
        Task<ApiRequest<StoriesGetExtendedResponse>> GetApi(int? ownerId = null, bool? extended = null);

        /// <summary>
        /// Returns list of sources hidden from current user's feed.
        /// </summary>
        Task<ApiRequest<StoriesGetBannedResponse>> GetBannedApi(bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns list of sources hidden from current user's feed.
        /// </summary>
        Task<ApiRequest<StoriesGetBannedExtendedResponse>> GetBannedApi(bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns story by its ID.
        /// </summary>
        Task<ApiRequest<StoriesGetByIdResponse>> GetByIdApi(IEnumerable<string> stories = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns story by its ID.
        /// </summary>
        Task<ApiRequest<StoriesGetByIdExtendedResponse>> GetByIdApi(IEnumerable<string> stories = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns URL for uploading a story with photo.
        /// </summary>
        Task<ApiRequest<StoriesGetPhotoUploadServerResponse>> GetPhotoUploadServerApi(bool? addToNews = null, IEnumerable<int> userIds = null, string replyToStory = null, string linkText = null, string linkUrl = null, int? groupId = null);

        /// <summary>
        /// Returns replies to the story.
        /// </summary>
        Task<ApiRequest<StoriesGetRepliesResponse>> GetRepliesApi(int? ownerId = null, int? storyId = null, string accessKey = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns replies to the story.
        /// </summary>
        Task<ApiRequest<StoriesGetRepliesExtendedResponse>> GetRepliesApi(int? ownerId = null, int? storyId = null, string accessKey = null, bool? extended = null, IEnumerable<BaseUserGroupFields> fields = null);

        /// <summary>
        /// Returns stories available for current user.
        /// </summary>
        Task<ApiRequest<StoriesStoryStats>> GetStatsApi(int? ownerId = null, int? storyId = null);

        /// <summary>
        /// Allows to receive URL for uploading story with video.
        /// </summary>
        Task<ApiRequest<StoriesGetVideoUploadServerResponse>> GetVideoUploadServerApi(bool? addToNews = null, IEnumerable<int> userIds = null, string replyToStory = null, string linkText = null, string linkUrl = null, int? groupId = null);

        /// <summary>
        /// Returns a list of story viewers.
        /// </summary>
        Task<ApiRequest<StoriesGetViewersResponse>> GetViewersApi(int? ownerId = null, int? storyId = null, int? count = null, int? offset = null, bool? extended = null);

        /// <summary>
        /// Returns a list of story viewers.
        /// </summary>
        Task<ApiRequest<StoriesGetViewersExtendedResponse>> GetViewersApi(int? ownerId = null, int? storyId = null, int? count = null, int? offset = null, bool? extended = null);

        /// <summary>
        /// Hides all replies in the last 24 hours from the user to current user's stories.
        /// </summary>
        Task<ApiRequest<bool?>> HideAllRepliesApi(int? ownerId = null, int? groupId = null);

        /// <summary>
        /// Hides the reply to the current user's story.
        /// </summary>
        Task<ApiRequest<bool?>> HideReplyApi(int? ownerId = null, int? storyId = null);

        /// <summary>
        /// Allows to show stories from hidden sources in current user's feed.
        /// </summary>
        Task<ApiRequest<bool?>> UnbanOwnerApi(IEnumerable<int> ownersIds = null);
    }
}
