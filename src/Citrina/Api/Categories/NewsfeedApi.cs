using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class NewsfeedApi : INewsfeedApi
    {
        public Task<ApiRequest<NewsfeedGetResponse>> Get(UserAccessToken accessToken, IEnumerable<string> filters, bool? returnBanned, DateTime? startTime, DateTime? endTime, int? maxPhotos, IEnumerable<string> sourceIds, string startFrom, int? count, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["return_banned"] = RequestHelpers.ParseBoolean(returnBanned),
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
                ["max_photos"] = maxPhotos?.ToString(),
                ["source_ids"] = RequestHelpers.ParseEnumerable(sourceIds),
                ["start_from"] = startFrom,
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetResponse>("newsfeed.get", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedGetRecommendedResponse>> GetRecommended(UserAccessToken accessToken, DateTime? startTime, DateTime? endTime, int? maxPhotos, string startFrom, int? count, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
                ["max_photos"] = maxPhotos?.ToString(),
                ["start_from"] = startFrom,
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetRecommendedResponse>("newsfeed.getRecommended", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? count, IEnumerable<string> filters, string reposts, DateTime? startTime, DateTime? endTime, string startFrom, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["reposts"] = reposts,
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
                ["start_from"] = startFrom,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetCommentsResponse>("newsfeed.getComments", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedGetMentionsResponse>> GetMentions(UserAccessToken accessToken, int? ownerId, DateTime? startTime, DateTime? endTime, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetMentionsResponse>("newsfeed.getMentions", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedGetBannedResponse>> GetBanned(UserAccessToken accessToken, IEnumerable<string> fields, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetBannedResponse>("newsfeed.getBanned", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedGetBannedExtendedResponse>> GetBannedExtended(UserAccessToken accessToken, bool? extended, IEnumerable<string> fields, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetBannedExtendedResponse>("newsfeed.getBanned", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddBan(UserAccessToken accessToken, IEnumerable<int?> userIds, IEnumerable<int?> groupIds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["group_ids"] = RequestHelpers.ParseEnumerable(groupIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.addBan", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteBan(UserAccessToken accessToken, IEnumerable<int?> userIds, IEnumerable<int?> groupIds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["group_ids"] = RequestHelpers.ParseEnumerable(groupIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.deleteBan", accessToken, request);
        }

        public Task<ApiRequest<bool?>> IgnoreItem(UserAccessToken accessToken, string type, int? ownerId, int? itemId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.ignoreItem", accessToken, request);
        }

        public Task<ApiRequest<bool?>> UnignoreItem(UserAccessToken accessToken, string type, int? ownerId, int? itemId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.unignoreItem", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedSearchResponse>> Search(UserAccessToken accessToken, string q, int? count, double? latitude, double? longitude, DateTime? startTime, DateTime? endTime, string startFrom, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["count"] = count?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
                ["start_from"] = startFrom,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedSearchResponse>("newsfeed.search", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, string q, bool? extended, int? count, double? latitude, double? longitude, DateTime? startTime, DateTime? endTime, string startFrom, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["count"] = count?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
                ["start_from"] = startFrom,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedSearchExtendedResponse>("newsfeed.search", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedSearchResponse>> Search(ServiceAccessToken accessToken, string q, int? count, double? latitude, double? longitude, DateTime? startTime, DateTime? endTime, string startFrom, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["count"] = count?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
                ["start_from"] = startFrom,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedSearchResponse>("newsfeed.search", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedSearchExtendedResponse>> SearchExtended(ServiceAccessToken accessToken, string q, bool? extended, int? count, double? latitude, double? longitude, DateTime? startTime, DateTime? endTime, string startFrom, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["count"] = count?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
                ["start_from"] = startFrom,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedSearchExtendedResponse>("newsfeed.search", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedGetListsResponse>> GetLists(UserAccessToken accessToken, IEnumerable<int?> listIds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["list_ids"] = RequestHelpers.ParseEnumerable(listIds),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetListsResponse>("newsfeed.getLists", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedGetListsExtendedResponse>> GetListsExtended(UserAccessToken accessToken, IEnumerable<int?> listIds, bool? extended)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["list_ids"] = RequestHelpers.ParseEnumerable(listIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetListsExtendedResponse>("newsfeed.getLists", accessToken, request);
        }

        public Task<ApiRequest<int?>> SaveList(UserAccessToken accessToken, int? listId, string title, IEnumerable<int?> sourceIds, bool? noReposts)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["list_id"] = listId?.ToString(),
                ["title"] = title,
                ["source_ids"] = RequestHelpers.ParseEnumerable(sourceIds),
                ["no_reposts"] = RequestHelpers.ParseBoolean(noReposts),
            };

            return RequestManager.CreateRequestAsync<int?>("newsfeed.saveList", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteList(int? listId)
        {
            var request = new Dictionary<string, string>
            {
                ["list_id"] = listId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.deleteList", null, request);
        }

        public Task<ApiRequest<bool?>> Unsubscribe(UserAccessToken accessToken, string type, int? ownerId, int? itemId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("newsfeed.unsubscribe", accessToken, request);
        }

        public Task<ApiRequest<NewsfeedGetSuggestedSourcesResponse>> GetSuggestedSources(UserAccessToken accessToken, int? offset, int? count, bool? shuffle, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["shuffle"] = RequestHelpers.ParseBoolean(shuffle),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<NewsfeedGetSuggestedSourcesResponse>("newsfeed.getSuggestedSources", accessToken, request);
        }
    }
}
