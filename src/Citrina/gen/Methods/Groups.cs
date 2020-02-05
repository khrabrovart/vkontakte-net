using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Groups : IGroups
    {
        public Task<ApiRequest<GroupsAddress>> AddAddressApi(int? groupId = null, string title = null, string address = null, string additionalAddress = null, int? countryId = null, int? cityId = null, int? metroId = null, double? latitude = null, double? longitude = null, string phone = null, string workInfoStatus = null, string timetable = null, bool? isMainAddress = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["title"] = title,
                ["address"] = address,
                ["additional_address"] = additionalAddress,
                ["country_id"] = countryId?.ToString(),
                ["city_id"] = cityId?.ToString(),
                ["metro_id"] = metroId?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["phone"] = phone,
                ["work_info_status"] = workInfoStatus,
                ["timetable"] = timetable,
                ["is_main_address"] = RequestHelpers.ParseBoolean(isMainAddress),
            };

            return RequestManager.CreateRequestAsync<GroupsAddress>("groups.addAddress", null, request);
        }

        public Task<ApiRequest<GroupsAddCallbackServerResponse>> AddCallbackServerApi(int? groupId = null, string url = null, string title = null, string secretKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["url"] = url,
                ["title"] = title,
                ["secret_key"] = secretKey,
            };

            return RequestManager.CreateRequestAsync<GroupsAddCallbackServerResponse>("groups.addCallbackServer", null, request);
        }

        /// <summary>
        /// Allows to add a link to the community.
        /// </summary>
        public Task<ApiRequest<GroupsGroupLink>> AddLinkApi(int? groupId = null, string link = null, string text = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["link"] = link,
                ["text"] = text,
            };

            return RequestManager.CreateRequestAsync<GroupsGroupLink>("groups.addLink", null, request);
        }

        /// <summary>
        /// Allows to approve join request to the community.
        /// </summary>
        public Task<ApiRequest<bool?>> ApproveRequestApi(int? groupId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.approveRequest", null, request);
        }

        public Task<ApiRequest<bool?>> BanApi(int? groupId = null, int? ownerId = null, int? endDate = null, int? reason = null, string comment = null, bool? commentVisible = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["end_date"] = endDate?.ToString(),
                ["reason"] = reason?.ToString(),
                ["comment"] = comment,
                ["comment_visible"] = RequestHelpers.ParseBoolean(commentVisible),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.ban", null, request);
        }

        /// <summary>
        /// Creates a new community.
        /// </summary>
        public Task<ApiRequest<GroupsGroup>> CreateApi(string title = null, string description = null, string type = null, int? publicCategory = null, int? subtype = null)
        {
            var request = new Dictionary<string, string>
            {
                ["title"] = title,
                ["description"] = description,
                ["type"] = type,
                ["public_category"] = publicCategory?.ToString(),
                ["subtype"] = subtype?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGroup>("groups.create", null, request);
        }

        public Task<ApiRequest<bool?>> DeleteCallbackServerApi(int? groupId = null, int? serverId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["server_id"] = serverId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.deleteCallbackServer", null, request);
        }

        /// <summary>
        /// Allows to delete a link from the community.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteLinkApi(int? groupId = null, int? linkId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["link_id"] = linkId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.deleteLink", null, request);
        }

        public Task<ApiRequest<bool?>> DisableOnlineApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.disableOnline", null, request);
        }

        /// <summary>
        /// Edits a community.
        /// </summary>
        public Task<ApiRequest<bool?>> EditApi(int? groupId = null, string title = null, string description = null, string screenName = null, int? access = null, string website = null, string subject = null, string email = null, string phone = null, string rss = null, int? eventStartDate = null, int? eventFinishDate = null, int? eventGroupId = null, int? publicCategory = null, int? publicSubcategory = null, string publicDate = null, int? wall = null, int? topics = null, int? photos = null, int? video = null, int? audio = null, bool? links = null, bool? events = null, bool? places = null, bool? contacts = null, int? docs = null, int? wiki = null, bool? messages = null, bool? articles = null, bool? addresses = null, int? ageLimits = null, bool? market = null, bool? marketComments = null, IEnumerable<int> marketCountry = null, IEnumerable<int> marketCity = null, int? marketCurrency = null, int? marketContact = null, int? marketWiki = null, bool? obsceneFilter = null, bool? obsceneStopwords = null, IEnumerable<string> obsceneWords = null, int? mainSection = null, int? secondarySection = null, int? country = null, int? city = null)
        {
            var request = new Dictionary<string, string>
            {
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
                ["event_start_date"] = eventStartDate?.ToString(),
                ["event_finish_date"] = eventFinishDate?.ToString(),
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
                ["articles"] = RequestHelpers.ParseBoolean(articles),
                ["addresses"] = RequestHelpers.ParseBoolean(addresses),
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
                ["main_section"] = mainSection?.ToString(),
                ["secondary_section"] = secondarySection?.ToString(),
                ["country"] = country?.ToString(),
                ["city"] = city?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.edit", null, request);
        }

        public Task<ApiRequest<GroupsAddress>> EditAddressApi(int? groupId = null, int? addressId = null, string title = null, string address = null, string additionalAddress = null, int? countryId = null, int? cityId = null, int? metroId = null, double? latitude = null, double? longitude = null, string phone = null, string workInfoStatus = null, string timetable = null, bool? isMainAddress = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["address_id"] = addressId?.ToString(),
                ["title"] = title,
                ["address"] = address,
                ["additional_address"] = additionalAddress,
                ["country_id"] = countryId?.ToString(),
                ["city_id"] = cityId?.ToString(),
                ["metro_id"] = metroId?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["phone"] = phone,
                ["work_info_status"] = workInfoStatus,
                ["timetable"] = timetable,
                ["is_main_address"] = RequestHelpers.ParseBoolean(isMainAddress),
            };

            return RequestManager.CreateRequestAsync<GroupsAddress>("groups.editAddress", null, request);
        }

        public Task<ApiRequest<bool?>> EditCallbackServerApi(int? groupId = null, int? serverId = null, string url = null, string title = null, string secretKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["server_id"] = serverId?.ToString(),
                ["url"] = url,
                ["title"] = title,
                ["secret_key"] = secretKey,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.editCallbackServer", null, request);
        }

        /// <summary>
        /// Allows to edit a link in the community.
        /// </summary>
        public Task<ApiRequest<bool?>> EditLinkApi(int? groupId = null, int? linkId = null, string text = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["link_id"] = linkId?.ToString(),
                ["text"] = text,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.editLink", null, request);
        }

        /// <summary>
        /// Allows to add, remove or edit the community manager.
        /// </summary>
        public Task<ApiRequest<bool?>> EditManagerApi(int? groupId = null, int? userId = null, string role = null, bool? isContact = null, string contactPosition = null, string contactPhone = null, string contactEmail = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["role"] = role,
                ["is_contact"] = RequestHelpers.ParseBoolean(isContact),
                ["contact_position"] = contactPosition,
                ["contact_phone"] = contactPhone,
                ["contact_email"] = contactEmail,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.editManager", null, request);
        }

        public Task<ApiRequest<bool?>> EnableOnlineApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.enableOnline", null, request);
        }

        /// <summary>
        /// Returns a list of the communities to which a user belongs.
        /// </summary>
        public Task<ApiRequest<GroupsGetResponse>> GetApi(int? userId = null, bool? extended = null, IEnumerable<GroupsFilter> filter = null, IEnumerable<GroupsFields> fields = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["filter"] = RequestHelpers.ParseEnumerable(filter),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetResponse>("groups.get", null, request);
        }

        /// <summary>
        /// Returns a list of the communities to which a user belongs.
        /// </summary>
        public Task<ApiRequest<GroupsGetExtendedResponse>> GetApi(int? userId = null, bool? extended = null, IEnumerable<GroupsFilter> filter = null, IEnumerable<GroupsFields> fields = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["filter"] = RequestHelpers.ParseEnumerable(filter),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetExtendedResponse>("groups.get", null, request);
        }

        /// <summary>
        /// Returns a list of community addresses.
        /// </summary>
        public Task<ApiRequest<GroupsGetAddressesResponse>> GetAddressesApi(int? groupId = null, IEnumerable<int> addressIds = null, double? latitude = null, double? longitude = null, int? offset = null, int? count = null, IEnumerable<AddressesFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["address_ids"] = RequestHelpers.ParseEnumerable(addressIds),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<GroupsGetAddressesResponse>("groups.getAddresses", null, request);
        }

        /// <summary>
        /// Returns a list of users on a community blacklist.
        /// </summary>
        public Task<ApiRequest<GroupsGetBannedResponse>> GetBannedApi(int? groupId = null, int? offset = null, int? count = null, IEnumerable<BaseUserGroupFields> fields = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetBannedResponse>("groups.getBanned", null, request);
        }

        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        public Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetByIdApi(IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<GroupsFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_ids"] = RequestHelpers.ParseEnumerable(groupIds),
                ["group_id"] = groupId,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsGroupFull>>("groups.getById", null, request);
        }

        /// <summary>
        /// Returns Callback API confirmation code for the community.
        /// </summary>
        public Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCodeApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode", null, request);
        }

        public Task<ApiRequest<GroupsGetCallbackServersResponse>> GetCallbackServersApi(int? groupId = null, IEnumerable<int> serverIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["server_ids"] = RequestHelpers.ParseEnumerable(serverIds),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCallbackServersResponse>("groups.getCallbackServers", null, request);
        }

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] notifications settings.
        /// </summary>
        public Task<ApiRequest<GroupsCallbackSettings>> GetCallbackSettingsApi(int? groupId = null, int? serverId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["server_id"] = serverId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsCallbackSettings>("groups.getCallbackSettings", null, request);
        }

        /// <summary>
        /// Returns communities list for a catalog category.
        /// </summary>
        public Task<ApiRequest<GroupsGetCatalogResponse>> GetCatalogApi(int? categoryId = null, int? subcategoryId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["category_id"] = categoryId?.ToString(),
                ["subcategory_id"] = subcategoryId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCatalogResponse>("groups.getCatalog", null, request);
        }

        /// <summary>
        /// Returns categories list for communities catalog.
        /// </summary>
        public Task<ApiRequest<GroupsGetCatalogInfoResponse>> GetCatalogInfoApi(bool? extended = null, bool? subcategories = null)
        {
            var request = new Dictionary<string, string>
            {
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["subcategories"] = RequestHelpers.ParseBoolean(subcategories),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCatalogInfoResponse>("groups.getCatalogInfo", null, request);
        }

        /// <summary>
        /// Returns categories list for communities catalog.
        /// </summary>
        public Task<ApiRequest<GroupsGetCatalogInfoExtendedResponse>> GetCatalogInfoApi(bool? extended = null, bool? subcategories = null)
        {
            var request = new Dictionary<string, string>
            {
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["subcategories"] = RequestHelpers.ParseBoolean(subcategories),
            };

            return RequestManager.CreateRequestAsync<GroupsGetCatalogInfoExtendedResponse>("groups.getCatalogInfo", null, request);
        }

        /// <summary>
        /// Returns invited users list of a community.
        /// </summary>
        public Task<ApiRequest<GroupsGetInvitedUsersResponse>> GetInvitedUsersApi(int? groupId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<GroupsGetInvitedUsersResponse>("groups.getInvitedUsers", null, request);
        }

        /// <summary>
        /// Returns a list of invitations to join communities and events.
        /// </summary>
        public Task<ApiRequest<GroupsGetInvitesResponse>> GetInvitesApi(int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<GroupsGetInvitesResponse>("groups.getInvites", null, request);
        }

        /// <summary>
        /// Returns a list of invitations to join communities and events.
        /// </summary>
        public Task<ApiRequest<GroupsGetInvitesExtendedResponse>> GetInvitesApi(int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<GroupsGetInvitesExtendedResponse>("groups.getInvites", null, request);
        }

        /// <summary>
        /// Returns the data needed to query a Long Poll server for events.
        /// </summary>
        public Task<ApiRequest<GroupsLongPollServer>> GetLongPollServerApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsLongPollServer>("groups.getLongPollServer", null, request);
        }

        /// <summary>
        /// Returns Long Poll notification settings.
        /// </summary>
        public Task<ApiRequest<GroupsLongPollSettings>> GetLongPollSettingsApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsLongPollSettings>("groups.getLongPollSettings", null, request);
        }

        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        public Task<ApiRequest<GroupsGetMembersResponse>> GetMembersApi(string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersResponse>("groups.getMembers", null, request);
        }

        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        public Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersApi(string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFieldsResponse>("groups.getMembers", null, request);
        }

        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        public Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersApi(string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<GroupsGetMembersFilterResponse>("groups.getMembers", null, request);
        }

        /// <summary>
        /// Returns a list of requests to the community.
        /// </summary>
        public Task<ApiRequest<GroupsGetRequestsResponse>> GetRequestsApi(int? groupId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<GroupsGetRequestsResponse>("groups.getRequests", null, request);
        }

        /// <summary>
        /// Returns a list of requests to the community.
        /// </summary>
        public Task<ApiRequest<GroupsGetRequestsFieldsResponse>> GetRequestsApi(int? groupId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<GroupsGetRequestsFieldsResponse>("groups.getRequests", null, request);
        }

        /// <summary>
        /// Returns community settings.
        /// </summary>
        public Task<ApiRequest<GroupsGroupSettings>> GetSettingsApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GroupsGroupSettings>("groups.getSettings", null, request);
        }

        public Task<ApiRequest<GroupsGetTokenPermissionsResponse>> GetTokenPermissionsApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<GroupsGetTokenPermissionsResponse>("groups.getTokenPermissions", null, request);
        }

        /// <summary>
        /// Allows to invite friends to the community.
        /// </summary>
        public Task<ApiRequest<bool?>> InviteApi(int? groupId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.invite", null, request);
        }

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        public Task<ApiRequest<bool?>> IsMemberApi(string groupId = null, int? userId = null, IEnumerable<int> userIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.isMember", null, request);
        }

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        public Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberApi(string groupId = null, int? userId = null, IEnumerable<int> userIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatus>>("groups.isMember", null, request);
        }

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        public Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberApi(string groupId = null, int? userId = null, IEnumerable<int> userIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<GroupsIsMemberExtendedResponse>("groups.isMember", null, request);
        }

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        public Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberApi(string groupId = null, int? userId = null, IEnumerable<int> userIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId,
                ["user_id"] = userId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<GroupsMemberStatusFull>>("groups.isMember", null, request);
        }

        /// <summary>
        /// With this method you can join the group or public page, and also confirm your participation in an event.
        /// </summary>
        public Task<ApiRequest<bool?>> JoinApi(int? groupId = null, string notSure = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["not_sure"] = notSure,
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.join", null, request);
        }

        /// <summary>
        /// With this method you can leave a group, public page, or event.
        /// </summary>
        public Task<ApiRequest<bool?>> LeaveApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.leave", null, request);
        }

        /// <summary>
        /// Removes a user from the community.
        /// </summary>
        public Task<ApiRequest<bool?>> RemoveUserApi(int? groupId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.removeUser", null, request);
        }

        /// <summary>
        /// Allows to reorder links in the community.
        /// </summary>
        public Task<ApiRequest<bool?>> ReorderLinkApi(int? groupId = null, int? linkId = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["link_id"] = linkId?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.reorderLink", null, request);
        }

        /// <summary>
        /// Returns a list of communities matching the search criteria.
        /// </summary>
        public Task<ApiRequest<GroupsSearchResponse>> SearchApi(string q = null, string type = null, int? countryId = null, int? cityId = null, bool? future = null, bool? market = null, int? sort = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
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

            return RequestManager.CreateRequestAsync<GroupsSearchResponse>("groups.search", null, request);
        }

        /// <summary>
        /// Allow to set notifications settings for group.
        /// </summary>
        public Task<ApiRequest<bool?>> SetCallbackSettingsApi(int? groupId = null, int? serverId = null, string apiVersion = null, bool? messageNew = null, bool? messageReply = null, bool? messageAllow = null, bool? messageEdit = null, bool? messageDeny = null, bool? messageTypingState = null, bool? photoNew = null, bool? audioNew = null, bool? videoNew = null, bool? wallReplyNew = null, bool? wallReplyEdit = null, bool? wallReplyDelete = null, bool? wallReplyRestore = null, bool? wallPostNew = null, bool? wallRepost = null, bool? boardPostNew = null, bool? boardPostEdit = null, bool? boardPostRestore = null, bool? boardPostDelete = null, bool? photoCommentNew = null, bool? photoCommentEdit = null, bool? photoCommentDelete = null, bool? photoCommentRestore = null, bool? videoCommentNew = null, bool? videoCommentEdit = null, bool? videoCommentDelete = null, bool? videoCommentRestore = null, bool? marketCommentNew = null, bool? marketCommentEdit = null, bool? marketCommentDelete = null, bool? marketCommentRestore = null, bool? pollVoteNew = null, bool? groupJoin = null, bool? groupLeave = null, bool? groupChangeSettings = null, bool? groupChangePhoto = null, bool? groupOfficersEdit = null, bool? userBlock = null, bool? userUnblock = null, bool? leadFormsNew = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["server_id"] = serverId?.ToString(),
                ["api_version"] = apiVersion,
                ["message_new"] = RequestHelpers.ParseBoolean(messageNew),
                ["message_reply"] = RequestHelpers.ParseBoolean(messageReply),
                ["message_allow"] = RequestHelpers.ParseBoolean(messageAllow),
                ["message_edit"] = RequestHelpers.ParseBoolean(messageEdit),
                ["message_deny"] = RequestHelpers.ParseBoolean(messageDeny),
                ["message_typing_state"] = RequestHelpers.ParseBoolean(messageTypingState),
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
                ["user_unblock"] = RequestHelpers.ParseBoolean(userUnblock),
                ["lead_forms_new"] = RequestHelpers.ParseBoolean(leadFormsNew),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.setCallbackSettings", null, request);
        }

        /// <summary>
        /// Sets Long Poll notification settings.
        /// </summary>
        public Task<ApiRequest<bool?>> SetLongPollSettingsApi(int? groupId = null, bool? enabled = null, string apiVersion = null, bool? messageNew = null, bool? messageReply = null, bool? messageAllow = null, bool? messageDeny = null, bool? messageEdit = null, bool? messageTypingState = null, bool? photoNew = null, bool? audioNew = null, bool? videoNew = null, bool? wallReplyNew = null, bool? wallReplyEdit = null, bool? wallReplyDelete = null, bool? wallReplyRestore = null, bool? wallPostNew = null, bool? wallRepost = null, bool? boardPostNew = null, bool? boardPostEdit = null, bool? boardPostRestore = null, bool? boardPostDelete = null, bool? photoCommentNew = null, bool? photoCommentEdit = null, bool? photoCommentDelete = null, bool? photoCommentRestore = null, bool? videoCommentNew = null, bool? videoCommentEdit = null, bool? videoCommentDelete = null, bool? videoCommentRestore = null, bool? marketCommentNew = null, bool? marketCommentEdit = null, bool? marketCommentDelete = null, bool? marketCommentRestore = null, bool? pollVoteNew = null, bool? groupJoin = null, bool? groupLeave = null, bool? groupChangeSettings = null, bool? groupChangePhoto = null, bool? groupOfficersEdit = null, bool? userBlock = null, bool? userUnblock = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["enabled"] = RequestHelpers.ParseBoolean(enabled),
                ["api_version"] = apiVersion,
                ["message_new"] = RequestHelpers.ParseBoolean(messageNew),
                ["message_reply"] = RequestHelpers.ParseBoolean(messageReply),
                ["message_allow"] = RequestHelpers.ParseBoolean(messageAllow),
                ["message_deny"] = RequestHelpers.ParseBoolean(messageDeny),
                ["message_edit"] = RequestHelpers.ParseBoolean(messageEdit),
                ["message_typing_state"] = RequestHelpers.ParseBoolean(messageTypingState),
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
                ["user_unblock"] = RequestHelpers.ParseBoolean(userUnblock),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.setLongPollSettings", null, request);
        }

        public Task<ApiRequest<bool?>> UnbanApi(int? groupId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("groups.unban", null, request);
        }
    }
}
