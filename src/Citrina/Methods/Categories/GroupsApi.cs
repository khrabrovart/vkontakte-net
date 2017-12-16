using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class GroupsApi : IGroupsApi
    {
        public Task<ApiRequest<bool?>> IsMember(UserAccessToken accessToken, string groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(UserAccessToken accessToken, string groupId, int? userId, IEnumerable<int?> userIds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatus>>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(UserAccessToken accessToken, string groupId, int? userId, bool? extended)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<GroupsIsMemberExtendedResponse>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(UserAccessToken accessToken, string groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatusFull>>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<bool?>> IsMember(GroupAccessToken accessToken, string groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(GroupAccessToken accessToken, string groupId, int? userId, IEnumerable<int?> userIds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatus>>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(GroupAccessToken accessToken, string groupId, int? userId, bool? extended)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<GroupsIsMemberExtendedResponse>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(GroupAccessToken accessToken, string groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatusFull>>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<bool?>> IsMember(string groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.isMember", null, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(string groupId, int? userId, IEnumerable<int?> userIds)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatus>>("groups.isMember", null, request);
        }

        public Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(string groupId, int? userId, bool? extended)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<GroupsIsMemberExtendedResponse>("groups.isMember", null, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(string groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatusFull>>("groups.isMember", null, request);
        }

        public Task<ApiRequest<bool?>> IsMember(ServiceAccessToken accessToken, string groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(ServiceAccessToken accessToken, string groupId, int? userId, IEnumerable<int?> userIds)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatus>>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(ServiceAccessToken accessToken, string groupId, int? userId, bool? extended)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<GroupsIsMemberExtendedResponse>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(ServiceAccessToken accessToken, string groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatusFull>>("groups.isMember", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(UserAccessToken accessToken, IEnumerable<string> groupIds, string groupId, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_ids"] = RequestHelpers.ParseEnumerable(groupIds),
                ["group_id"] = groupId,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsGroupFull>>("groups.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(GroupAccessToken accessToken, IEnumerable<string> groupIds, string groupId, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_ids"] = RequestHelpers.ParseEnumerable(groupIds),
                ["group_id"] = groupId,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsGroupFull>>("groups.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(IEnumerable<string> groupIds, string groupId, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["group_ids"] = RequestHelpers.ParseEnumerable(groupIds),
                ["group_id"] = groupId,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsGroupFull>>("groups.getById", null, request);
        }

        public Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> groupIds, string groupId, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_ids"] = RequestHelpers.ParseEnumerable(groupIds),
                ["group_id"] = groupId,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsGroupFull>>("groups.getById", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetResponse>> Get(UserAccessToken accessToken, int? userId, IEnumerable<string> filter, IEnumerable<string> fields, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["filter"] = RequestHelpers.ParseEnumerable(filter),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetResponse>("groups.get", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? userId, bool? extended, IEnumerable<string> filter, IEnumerable<string> fields, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["filter"] = RequestHelpers.ParseEnumerable(filter),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetExtendedResponse>("groups.get", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(UserAccessToken accessToken, string groupId, string sort, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersResponse>("groups.getMembers", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(UserAccessToken accessToken, string groupId, string sort, int? offset, int? count, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFieldsResponse>("groups.getMembers", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(UserAccessToken accessToken, string groupId, string sort, int? offset, int? count, string filter)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFilterResponse>("groups.getMembers", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(GroupAccessToken accessToken, string groupId, string sort, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersResponse>("groups.getMembers", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(GroupAccessToken accessToken, string groupId, string sort, int? offset, int? count, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFieldsResponse>("groups.getMembers", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(GroupAccessToken accessToken, string groupId, string sort, int? offset, int? count, string filter)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFilterResponse>("groups.getMembers", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(string groupId, string sort, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersResponse>("groups.getMembers", null, request);
        }

        public Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(string groupId, string sort, int? offset, int? count, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFieldsResponse>("groups.getMembers", null, request);
        }

        public Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(string groupId, string sort, int? offset, int? count, string filter)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFilterResponse>("groups.getMembers", null, request);
        }

        public Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(ServiceAccessToken accessToken, string groupId, string sort, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersResponse>("groups.getMembers", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(ServiceAccessToken accessToken, string groupId, string sort, int? offset, int? count, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFieldsResponse>("groups.getMembers", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(ServiceAccessToken accessToken, string groupId, string sort, int? offset, int? count, string filter)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFilterResponse>("groups.getMembers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Join(UserAccessToken accessToken, int? groupId, string notSure)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["not_sure"] = notSure,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.join", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Leave(UserAccessToken accessToken, int? groupId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.leave", accessToken, request);
        }

        public Task<ApiRequest<GroupsSearchResponse>> Search(UserAccessToken accessToken, string q, string type, int? countryId, int? cityId, bool? future, bool? market, int? sort, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["type"] = type,
                ["country_id"] = countryId?.ToString(),
                ["city_id"] = cityId?.ToString(),
                ["future"] = RequestHelpers.ParseBoolean(future),
                ["market"] = RequestHelpers.ParseBoolean(market),
                ["sort"] = sort?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsSearchResponse>("groups.search", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, int? categoryId, int? subcategoryId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["category_id"] = categoryId?.ToString(),
                ["subcategory_id"] = subcategoryId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCatalogResponse>("groups.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetCatalogInfoResponse>> GetCatalogInfo(UserAccessToken accessToken, bool? subcategories)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["subcategories"] = RequestHelpers.ParseBoolean(subcategories),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCatalogInfoResponse>("groups.getCatalogInfo", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetCatalogInfoExtendedResponse>> GetCatalogInfoExtended(UserAccessToken accessToken, bool? extended, bool? subcategories)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["subcategories"] = RequestHelpers.ParseBoolean(subcategories),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCatalogInfoExtendedResponse>("groups.getCatalogInfo", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetInvitesResponse>> GetInvites(UserAccessToken accessToken, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetInvitesResponse>("groups.getInvites", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetInvitesExtendedResponse>> GetInvitesExtended(UserAccessToken accessToken, int? offset, int? count, bool? extended)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<GroupsGetInvitesExtendedResponse>("groups.getInvites", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetInvitedUsersResponse>> GetInvitedUsers(UserAccessToken accessToken, int? groupId, int? offset, int? count, IEnumerable<string> fields, string nameCase)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<GroupsGetInvitedUsersResponse>("groups.getInvitedUsers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> BanUser(UserAccessToken accessToken, int? groupId, int? userId, DateTime? endDate, int? reason, string comment, bool? commentVisible)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["end_date"] = RequestHelpers.ParseDateTime(endDate),
                ["reason"] = reason?.ToString(),
                ["comment"] = comment,
                ["comment_visible"] = RequestHelpers.ParseBoolean(commentVisible),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.banUser", accessToken, request);
        }

        public Task<ApiRequest<bool?>> UnbanUser(UserAccessToken accessToken, int? groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.unbanUser", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetBannedResponse>> GetBanned(UserAccessToken accessToken, int? groupId, int? offset, int? count, IEnumerable<string> fields, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetBannedResponse>("groups.getBanned", accessToken, request);
        }

        public Task<ApiRequest<GroupsGroup>> Create(UserAccessToken accessToken, string title, string description, string type, int? publicCategory, int? subtype)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["title"] = title,
                ["description"] = description,
                ["type"] = type,
                ["public_category"] = publicCategory?.ToString(),
                ["subtype"] = subtype?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGroup>("groups.create", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? groupId, string title, string description, string screenName, int? access, string website, string subject, string email, string phone, string rss, DateTime? eventStartDate, DateTime? eventFinishDate, int? eventGroupId, int? publicCategory, int? publicSubcategory, string publicDate, int? wall, int? topics, int? photos, int? video, int? audio, bool? links, bool? events, bool? places, bool? contacts, int? docs, int? wiki, bool? messages, int? ageLimits, bool? market, bool? marketComments, IEnumerable<int?> marketCountry, IEnumerable<int?> marketCity, int? marketCurrency, int? marketContact, int? marketWiki, bool? obsceneFilter, bool? obsceneStopwords, IEnumerable<string> obsceneWords)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["title"] = title,
                ["description"] = description,
                ["screen_name"] = screenName,
                ["access"] = access?.ToString(),
                ["website"] = website,
                ["subject"] = subject,
                ["email"] = email,
                ["phone"] = phone,
                ["rss"] = rss,
                ["event_start_date"] = RequestHelpers.ParseDateTime(eventStartDate),
                ["event_finish_date"] = RequestHelpers.ParseDateTime(eventFinishDate),
                ["event_group_id"] = eventGroupId?.ToString(),
                ["public_category"] = publicCategory?.ToString(),
                ["public_subcategory"] = publicSubcategory?.ToString(),
                ["public_date"] = publicDate,
                ["wall"] = wall?.ToString(),
                ["topics"] = topics?.ToString(),
                ["photos"] = photos?.ToString(),
                ["video"] = video?.ToString(),
                ["audio"] = audio?.ToString(),
                ["links"] = RequestHelpers.ParseBoolean(links),
                ["events"] = RequestHelpers.ParseBoolean(events),
                ["places"] = RequestHelpers.ParseBoolean(places),
                ["contacts"] = RequestHelpers.ParseBoolean(contacts),
                ["docs"] = docs?.ToString(),
                ["wiki"] = wiki?.ToString(),
                ["messages"] = RequestHelpers.ParseBoolean(messages),
                ["age_limits"] = ageLimits?.ToString(),
                ["market"] = RequestHelpers.ParseBoolean(market),
                ["market_comments"] = RequestHelpers.ParseBoolean(marketComments),
                ["market_country"] = RequestHelpers.ParseEnumerable(marketCountry),
                ["market_city"] = RequestHelpers.ParseEnumerable(marketCity),
                ["market_currency"] = marketCurrency?.ToString(),
                ["market_contact"] = marketContact?.ToString(),
                ["market_wiki"] = marketWiki?.ToString(),
                ["obscene_filter"] = RequestHelpers.ParseBoolean(obsceneFilter),
                ["obscene_stopwords"] = RequestHelpers.ParseBoolean(obsceneStopwords),
                ["obscene_words"] = RequestHelpers.ParseEnumerable(obsceneWords),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.edit", accessToken, request);
        }

        public Task<ApiRequest<GroupsEditPlaceResponse>> EditPlace(UserAccessToken accessToken, int? groupId, string title, string address, int? countryId, int? cityId, double? latitude, double? longitude)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["title"] = title,
                ["address"] = address,
                ["country_id"] = countryId?.ToString(),
                ["city_id"] = cityId?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsEditPlaceResponse>("groups.editPlace", accessToken, request);
        }

        public Task<ApiRequest<GroupsGroupSettings>> GetSettings(UserAccessToken accessToken, int? groupId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGroupSettings>("groups.getSettings", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetRequestsResponse>> GetRequests(UserAccessToken accessToken, int? groupId, int? offset, int? count)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetRequestsResponse>("groups.getRequests", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetRequestsFieldsResponse>> GetRequestsFields(UserAccessToken accessToken, int? groupId, int? offset, int? count, IEnumerable<string> fields)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<GroupsGetRequestsFieldsResponse>("groups.getRequests", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditManager(UserAccessToken accessToken, int? groupId, int? userId, string role, bool? isContact, string contactPosition, string contactPhone, string contactEmail)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["role"] = role,
                ["is_contact"] = RequestHelpers.ParseBoolean(isContact),
                ["contact_position"] = contactPosition,
                ["contact_phone"] = contactPhone,
                ["contact_email"] = contactEmail,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.editManager", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Invite(UserAccessToken accessToken, int? groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.invite", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddLink(UserAccessToken accessToken, int? groupId, string link, string text)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["link"] = link,
                ["text"] = text,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.addLink", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteLink(UserAccessToken accessToken, int? groupId, int? linkId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["link_id"] = linkId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.deleteLink", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditLink(UserAccessToken accessToken, int? groupId, int? linkId, string text)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["link_id"] = linkId?.ToString(),
                ["text"] = text,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.editLink", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderLink(UserAccessToken accessToken, int? groupId, int? linkId, int? after)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["link_id"] = linkId?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.reorderLink", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveUser(UserAccessToken accessToken, int? groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.removeUser", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ApproveRequest(UserAccessToken accessToken, int? groupId, int? userId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.approveRequest", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(UserAccessToken accessToken, int? groupId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(GroupAccessToken accessToken, int? groupId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(UserAccessToken accessToken, int? groupId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCallbackServerSettingsResponse>("groups.getCallbackServerSettings", accessToken, request);
        }

        public Task<ApiRequest<GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(GroupAccessToken accessToken, int? groupId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCallbackServerSettingsResponse>("groups.getCallbackServerSettings", accessToken, request);
        }

        // Verified signature
        public Task<ApiRequest<GroupsGetCallbackSettingsResponse>> GetCallbackSettings(UserAccessToken accessToken, int? groupId, int? serverId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["server_id"] = serverId?.ToString()
            };

            return RequestManager.CreateRequestAsync<GroupsGetCallbackSettingsResponse>("groups.getCallbackSettings", accessToken, request);
        }

        // Verified signature
        public Task<ApiRequest<GroupsGetCallbackSettingsResponse>> GetCallbackSettings(GroupAccessToken accessToken, int? groupId, int? serverId)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["server_id"] = serverId?.ToString()
            };

            return RequestManager.CreateRequestAsync<GroupsGetCallbackSettingsResponse>("groups.getCallbackSettings", accessToken, request);
        }

        public Task<ApiRequest<GroupsSetCallbackServerResponse>> SetCallbackServer(UserAccessToken accessToken, int? groupId, string serverUrl)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["server_url"] = serverUrl,
            };

            return RequestManager.CreateRequestAsync<GroupsSetCallbackServerResponse>("groups.setCallbackServer", accessToken, request);
        }

        public Task<ApiRequest<GroupsSetCallbackServerResponse>> SetCallbackServer(GroupAccessToken accessToken, int? groupId, string serverUrl)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["server_url"] = serverUrl,
            };

            return RequestManager.CreateRequestAsync<GroupsSetCallbackServerResponse>("groups.setCallbackServer", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetCallbackServerSettings(UserAccessToken accessToken, int? groupId, string secretKey)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["secret_key"] = secretKey,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.setCallbackServerSettings", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetCallbackServerSettings(GroupAccessToken accessToken, int? groupId, string secretKey)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["secret_key"] = secretKey,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.setCallbackServerSettings", accessToken, request);
        }

        // Verified signature / response
        public Task<ApiRequest<bool?>> SetCallbackSettings(
            UserAccessToken accessToken,
            int? groupId,
            int? serverId,
            bool? messageNew,
            bool? messageReply,
            bool? messageAllow,
            bool? messageDeny,
            bool? photoNew,
            bool? audioNew,
            bool? videoNew,
            bool? wallReplyNew,
            bool? wallReplyEdit,
            bool? wallReplyDelete,
            bool? wallReplyRestore,
            bool? wallPostNew,
            bool? wallRepost,
            bool? boardPostNew,
            bool? boardPostEdit,
            bool? boardPostRestore,
            bool? boardPostDelete,
            bool? photoCommentNew,
            bool? photoCommentEdit,
            bool? photoCommentDelete,
            bool? photoCommentRestore,
            bool? videoCommentNew,
            bool? videoCommentEdit,
            bool? videoCommentDelete,
            bool? videoCommentRestore,
            bool? marketCommentNew,
            bool? marketCommentEdit,
            bool? marketCommentDelete,
            bool? marketCommentRestore,
            bool? pollVoteNew,
            bool? groupJoin,
            bool? groupLeave,
            bool? groupChangeSettings,
            bool? groupChangePhoto,
            bool? groupOfficersEdit,
            bool? userBlock,
            bool? userUnblock)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["server_id"] = serverId?.ToString(),
                ["message_new"] = RequestHelpers.ParseBoolean(messageNew),
                ["message_reply"] = RequestHelpers.ParseBoolean(messageReply),
                ["message_allow"] = RequestHelpers.ParseBoolean(messageAllow),
                ["message_deny"] = RequestHelpers.ParseBoolean(messageDeny),
                ["photo_new"] = RequestHelpers.ParseBoolean(photoNew),
                ["audio_new"] = RequestHelpers.ParseBoolean(audioNew),
                ["video_new"] = RequestHelpers.ParseBoolean(videoNew),
                ["wall_reply_new"] = RequestHelpers.ParseBoolean(wallReplyNew),
                ["wall_reply_edit"] = RequestHelpers.ParseBoolean(wallReplyEdit),
                ["wall_reply_delete"] = RequestHelpers.ParseBoolean(wallReplyDelete),
                ["wall_reply_restore"] = RequestHelpers.ParseBoolean(wallReplyRestore),
                ["wall_post_new"] = RequestHelpers.ParseBoolean(wallPostNew),
                ["wall_repost"] = RequestHelpers.ParseBoolean(wallRepost),
                ["board_post_new"] = RequestHelpers.ParseBoolean(boardPostNew),
                ["board_post_edit"] = RequestHelpers.ParseBoolean(boardPostEdit),
                ["board_post_restore"] = RequestHelpers.ParseBoolean(boardPostRestore),
                ["board_post_delete"] = RequestHelpers.ParseBoolean(boardPostDelete),
                ["photo_comment_new"] = RequestHelpers.ParseBoolean(photoCommentNew),
                ["photo_comment_edit"] = RequestHelpers.ParseBoolean(photoCommentEdit),
                ["photo_comment_delete"] = RequestHelpers.ParseBoolean(photoCommentDelete),
                ["photo_comment_restore"] = RequestHelpers.ParseBoolean(photoCommentRestore),
                ["video_comment_new"] = RequestHelpers.ParseBoolean(videoCommentNew),
                ["video_comment_edit"] = RequestHelpers.ParseBoolean(videoCommentEdit),
                ["video_comment_delete"] = RequestHelpers.ParseBoolean(videoCommentDelete),
                ["video_comment_restore"] = RequestHelpers.ParseBoolean(videoCommentRestore),
                ["market_comment_new"] = RequestHelpers.ParseBoolean(marketCommentNew),
                ["market_comment_edit"] = RequestHelpers.ParseBoolean(marketCommentEdit),
                ["market_comment_delete"] = RequestHelpers.ParseBoolean(marketCommentDelete),
                ["market_comment_restore"] = RequestHelpers.ParseBoolean(marketCommentRestore),
                ["poll_vote_new"] = RequestHelpers.ParseBoolean(pollVoteNew),
                ["group_join"] = RequestHelpers.ParseBoolean(groupJoin),
                ["group_leave"] = RequestHelpers.ParseBoolean(groupLeave),
                ["group_change_settings"] = RequestHelpers.ParseBoolean(groupChangeSettings),
                ["group_change_photo"] = RequestHelpers.ParseBoolean(groupChangePhoto),
                ["group_officers_edit"] = RequestHelpers.ParseBoolean(groupOfficersEdit),
                ["user_block"] = RequestHelpers.ParseBoolean(userBlock),
                ["user_unblock"] = RequestHelpers.ParseBoolean(userUnblock)
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.setCallbackSettings", accessToken, request);
        }

        // Verified signature / response
        public Task<ApiRequest<bool?>> SetCallbackSettings(
            GroupAccessToken accessToken,
            int? groupId,
            int? serverId,
            bool? messageNew,
            bool? messageReply,
            bool? messageAllow,
            bool? messageDeny,
            bool? photoNew,
            bool? audioNew,
            bool? videoNew,
            bool? wallReplyNew,
            bool? wallReplyEdit,
            bool? wallReplyDelete,
            bool? wallReplyRestore,
            bool? wallPostNew,
            bool? wallRepost,
            bool? boardPostNew,
            bool? boardPostEdit,
            bool? boardPostRestore,
            bool? boardPostDelete,
            bool? photoCommentNew,
            bool? photoCommentEdit,
            bool? photoCommentDelete,
            bool? photoCommentRestore,
            bool? videoCommentNew,
            bool? videoCommentEdit,
            bool? videoCommentDelete,
            bool? videoCommentRestore,
            bool? marketCommentNew,
            bool? marketCommentEdit,
            bool? marketCommentDelete,
            bool? marketCommentRestore,
            bool? pollVoteNew, 
            bool? groupJoin,
            bool? groupLeave,
            bool? groupChangeSettings,
            bool? groupChangePhoto,
            bool? groupOfficersEdit,
            bool? userBlock,
            bool? userUnblock)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["server_id"] = serverId?.ToString(),
                ["message_new"] = RequestHelpers.ParseBoolean(messageNew),
                ["message_reply"] = RequestHelpers.ParseBoolean(messageReply),
                ["message_allow"] = RequestHelpers.ParseBoolean(messageAllow),
                ["message_deny"] = RequestHelpers.ParseBoolean(messageDeny),
                ["photo_new"] = RequestHelpers.ParseBoolean(photoNew),
                ["audio_new"] = RequestHelpers.ParseBoolean(audioNew),
                ["video_new"] = RequestHelpers.ParseBoolean(videoNew),
                ["wall_reply_new"] = RequestHelpers.ParseBoolean(wallReplyNew),
                ["wall_reply_edit"] = RequestHelpers.ParseBoolean(wallReplyEdit),
                ["wall_reply_delete"] = RequestHelpers.ParseBoolean(wallReplyDelete),
                ["wall_reply_restore"] = RequestHelpers.ParseBoolean(wallReplyRestore),
                ["wall_post_new"] = RequestHelpers.ParseBoolean(wallPostNew),
                ["wall_repost"] = RequestHelpers.ParseBoolean(wallRepost),
                ["board_post_new"] = RequestHelpers.ParseBoolean(boardPostNew),
                ["board_post_edit"] = RequestHelpers.ParseBoolean(boardPostEdit),
                ["board_post_restore"] = RequestHelpers.ParseBoolean(boardPostRestore),
                ["board_post_delete"] = RequestHelpers.ParseBoolean(boardPostDelete),
                ["photo_comment_new"] = RequestHelpers.ParseBoolean(photoCommentNew),
                ["photo_comment_edit"] = RequestHelpers.ParseBoolean(photoCommentEdit),
                ["photo_comment_delete"] = RequestHelpers.ParseBoolean(photoCommentDelete),
                ["photo_comment_restore"] = RequestHelpers.ParseBoolean(photoCommentRestore),
                ["video_comment_new"] = RequestHelpers.ParseBoolean(videoCommentNew),
                ["video_comment_edit"] = RequestHelpers.ParseBoolean(videoCommentEdit),
                ["video_comment_delete"] = RequestHelpers.ParseBoolean(videoCommentDelete),
                ["video_comment_restore"] = RequestHelpers.ParseBoolean(videoCommentRestore),
                ["market_comment_new"] = RequestHelpers.ParseBoolean(marketCommentNew),
                ["market_comment_edit"] = RequestHelpers.ParseBoolean(marketCommentEdit),
                ["market_comment_delete"] = RequestHelpers.ParseBoolean(marketCommentDelete),
                ["market_comment_restore"] = RequestHelpers.ParseBoolean(marketCommentRestore),
                ["poll_vote_new"] = RequestHelpers.ParseBoolean(pollVoteNew),
                ["group_join"] = RequestHelpers.ParseBoolean(groupJoin),
                ["group_leave"] = RequestHelpers.ParseBoolean(groupLeave),
                ["group_change_settings"] = RequestHelpers.ParseBoolean(groupChangeSettings),
                ["group_change_photo"] = RequestHelpers.ParseBoolean(groupChangePhoto),
                ["group_officers_edit"] = RequestHelpers.ParseBoolean(groupOfficersEdit),
                ["user_block"] = RequestHelpers.ParseBoolean(userBlock),
                ["user_unblock"] = RequestHelpers.ParseBoolean(userUnblock)
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.setCallbackSettings", accessToken, request);
        }

    }
}
