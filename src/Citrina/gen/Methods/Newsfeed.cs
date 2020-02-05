using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Newsfeed : INewsfeed
    {
        /// <summary>
        /// Prevents news from specified users and communities from appearing in the current user's newsfeed.
        /// </summary>
        public Task<ApiRequest<bool?>> AddBanApi(IEnumerable<int> userIds = null, IEnumerable<int> groupIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["group_ids"] = RequestHelpers.ParseEnumerable(groupIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.addBan", null, request);
        }

        /// <summary>
        /// Allows news from previously banned users and communities to be shown in the current user's newsfeed.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteBanApi(IEnumerable<int> userIds = null, IEnumerable<int> groupIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["group_ids"] = RequestHelpers.ParseEnumerable(groupIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.deleteBan", null, request);
        }

        public Task<ApiRequest<bool?>> DeleteListApi(int? listId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["list_id"] = listId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.deleteList", null, request);
        }

        /// <summary>
        /// Returns data required to show newsfeed for the current user.
        /// </summary>
        public Task<ApiRequest<NewsfeedGetResponse>> GetApi(IEnumerable<NewsfeedFilters> filters = null, bool? returnBanned = null, int? startTime = null, int? endTime = null, int? maxPhotos = null, string sourceIds = null, string startFrom = null, int? count = null, IEnumerable<BaseUserGroupFields> fields = null, string section = null)
        {
            var request = new Dictionary<string, string>
            {
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["return_banned"] = RequestHelpers.ParseBoolean(returnBanned),
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["max_photos"] = maxPhotos?.ToString(),
                ["source_ids"] = sourceIds,
                ["start_from"] = startFrom,
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["section"] = section,
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetResponse>("newsfeed.get", null, request);
        }

        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// </summary>
        public Task<ApiRequest<NewsfeedGetBannedResponse>> GetBannedApi(bool? extended = null, IEnumerable<UsersFields> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetBannedResponse>("newsfeed.getBanned", null, request);
        }

        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// </summary>
        public Task<ApiRequest<NewsfeedGetBannedExtendedResponse>> GetBannedApi(bool? extended = null, IEnumerable<UsersFields> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetBannedExtendedResponse>("newsfeed.getBanned", null, request);
        }

        /// <summary>
        /// Returns a list of comments in the current user's newsfeed.
        /// </summary>
        public Task<ApiRequest<NewsfeedGetCommentsResponse>> GetCommentsApi(int? count = null, IEnumerable<NewsfeedCommentsFilters> filters = null, string reposts = null, int? startTime = null, int? endTime = null, int? lastCommentsCount = null, string startFrom = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["reposts"] = reposts,
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["last_comments_count"] = lastCommentsCount?.ToString(),
                ["start_from"] = startFrom,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetCommentsResponse>("newsfeed.getComments", null, request);
        }

        /// <summary>
        /// Returns a list of newsfeeds followed by the current user.
        /// </summary>
        public Task<ApiRequest<NewsfeedGetListsResponse>> GetListsApi(IEnumerable<int> listIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["list_ids"] = RequestHelpers.ParseEnumerable(listIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetListsResponse>("newsfeed.getLists", null, request);
        }

        /// <summary>
        /// Returns a list of newsfeeds followed by the current user.
        /// </summary>
        public Task<ApiRequest<NewsfeedGetListsExtendedResponse>> GetListsApi(IEnumerable<int> listIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["list_ids"] = RequestHelpers.ParseEnumerable(listIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetListsExtendedResponse>("newsfeed.getLists", null, request);
        }

        /// <summary>
        /// Returns a list of posts on user walls in which the current user is mentioned.
        /// </summary>
        public Task<ApiRequest<NewsfeedGetMentionsResponse>> GetMentionsApi(int? ownerId = null, int? startTime = null, int? endTime = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetMentionsResponse>("newsfeed.getMentions", null, request);
        }

        /// <summary>
        /// , Returns a list of newsfeeds recommended to the current user.
        /// </summary>
        public Task<ApiRequest<NewsfeedGetRecommendedResponse>> GetRecommendedApi(int? startTime = null, int? endTime = null, int? maxPhotos = null, string startFrom = null, int? count = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["max_photos"] = maxPhotos?.ToString(),
                ["start_from"] = startFrom,
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetRecommendedResponse>("newsfeed.getRecommended", null, request);
        }

        /// <summary>
        /// Returns communities and users that current user is suggested to follow.
        /// </summary>
        public Task<ApiRequest<NewsfeedGetSuggestedSourcesResponse>> GetSuggestedSourcesApi(int? offset = null, int? count = null, bool? shuffle = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["shuffle"] = RequestHelpers.ParseBoolean(shuffle),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetSuggestedSourcesResponse>("newsfeed.getSuggestedSources", null, request);
        }

        /// <summary>
        /// Hides an item from the newsfeed.
        /// </summary>
        public Task<ApiRequest<bool?>> IgnoreItemApi(string type = null, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.ignoreItem", null, request);
        }

        /// <summary>
        /// Creates and edits user newsfeed lists.
        /// </summary>
        public Task<ApiRequest<int?>> SaveListApi(int? listId = null, string title = null, IEnumerable<int> sourceIds = null, bool? noReposts = null)
        {
            var request = new Dictionary<string, string>
            {
                ["list_id"] = listId?.ToString(),
                ["title"] = title,
                ["source_ids"] = RequestHelpers.ParseEnumerable(sourceIds),
                ["no_reposts"] = RequestHelpers.ParseBoolean(noReposts),
            };

            return RequestManager.CreateRequestAsync<int?>("newsfeed.saveList", null, request);
        }

        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        public Task<ApiRequest<NewsfeedSearchResponse>> SearchApi(string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, int? startTime = null, int? endTime = null, string startFrom = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["count"] = count?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["start_from"] = startFrom,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedSearchResponse>("newsfeed.search", null, request);
        }

        /// <summary>
        /// Returns search results by statuses.
        /// </summary>
        public Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchApi(string q = null, bool? extended = null, int? count = null, double? latitude = null, double? longitude = null, int? startTime = null, int? endTime = null, string startFrom = null, IEnumerable<BaseUserGroupFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["count"] = count?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["start_from"] = startFrom,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedSearchExtendedResponse>("newsfeed.search", null, request);
        }

        /// <summary>
        /// Returns a hidden item to the newsfeed.
        /// </summary>
        public Task<ApiRequest<bool?>> UnignoreItemApi(string type = null, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.unignoreItem", null, request);
        }

        /// <summary>
        /// Unsubscribes the current user from specified newsfeeds.
        /// </summary>
        public Task<ApiRequest<bool?>> UnsubscribeApi(string type = null, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.unsubscribe", null, request);
        }
    }
}
