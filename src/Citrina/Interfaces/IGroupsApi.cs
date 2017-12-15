using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IGroupsApi
    {
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<bool?>> IsMember(UserAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(UserAccessToken accessToken, string groupId = null, int? userId = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(UserAccessToken accessToken, string groupId = null, int? userId = null, bool? extended = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(UserAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<bool?>> IsMember(GroupAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(GroupAccessToken accessToken, string groupId = null, int? userId = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(GroupAccessToken accessToken, string groupId = null, int? userId = null, bool? extended = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(GroupAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<bool?>> IsMember(string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(string groupId = null, int? userId = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(string groupId = null, int? userId = null, bool? extended = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<bool?>> IsMember(ServiceAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberUserIds(ServiceAccessToken accessToken, string groupId = null, int? userId = null, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberExtended(ServiceAccessToken accessToken, string groupId = null, int? userId = null, bool? extended = null);
        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberUserIdsExtended(ServiceAccessToken accessToken, string groupId = null, int? userId = null);
        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(UserAccessToken accessToken, IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(GroupAccessToken accessToken, IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of the communities to which a user belongs.
        /// </summary>
        Task<ApiRequest<GroupsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, IEnumerable<string> filter = null, IEnumerable<string> fields = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of the communities to which a user belongs.
        /// </summary>
        Task<ApiRequest<GroupsGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? userId = null, bool? extended = null, IEnumerable<string> filter = null, IEnumerable<string> fields = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(UserAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(UserAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(UserAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(GroupAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(GroupAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(GroupAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(string groupId = null, string sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersResponse>> GetMembers(ServiceAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersFields(ServiceAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersFilter(ServiceAccessToken accessToken, string groupId = null, string sort = null, int? offset = null, int? count = null, string filter = null);
        /// <summary>
        /// With this method you can join the group or public page, and also confirm your participation in an event.
        /// </summary>
        Task<ApiRequest<bool?>> Join(UserAccessToken accessToken, int? groupId = null, string notSure = null);
        /// <summary>
        /// With this method you can leave a group, public page, or event.
        /// </summary>
        Task<ApiRequest<bool?>> Leave(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns a list of communities matching the search criteria.
        /// </summary>
        Task<ApiRequest<GroupsSearchResponse>> Search(UserAccessToken accessToken, string q = null, string type = null, int? countryId = null, int? cityId = null, bool? future = null, bool? market = null, int? sort = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns communities list for a catalog category.
        /// </summary>
        Task<ApiRequest<GroupsGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, int? categoryId = null, int? subcategoryId = null);
        /// <summary>
        /// Returns categories list for communities catalog
        /// </summary>
        Task<ApiRequest<GroupsGetCatalogInfoResponse>> GetCatalogInfo(UserAccessToken accessToken, bool? subcategories = null);
        /// <summary>
        /// Returns categories list for communities catalog
        /// </summary>
        Task<ApiRequest<GroupsGetCatalogInfoExtendedResponse>> GetCatalogInfoExtended(UserAccessToken accessToken, bool? extended = null, bool? subcategories = null);
        /// <summary>
        /// Returns a list of invitations to join communities and events.
        /// </summary>
        Task<ApiRequest<GroupsGetInvitesResponse>> GetInvites(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of invitations to join communities and events.
        /// </summary>
        Task<ApiRequest<GroupsGetInvitesExtendedResponse>> GetInvitesExtended(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null);
        /// <summary>
        /// Returns invited users list of a community
        /// </summary>
        Task<ApiRequest<GroupsGetInvitedUsersResponse>> GetInvitedUsers(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Adds a user to a community blacklist.
        /// </summary>
        Task<ApiRequest<bool?>> BanUser(UserAccessToken accessToken, int? groupId = null, int? userId = null, DateTime? endDate = null, int? reason = null, string comment = null, bool? commentVisible = null);
        /// <summary>
        /// Removes a user from a community blacklist.
        /// </summary>
        Task<ApiRequest<bool?>> UnbanUser(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Returns a list of users on a community blacklist.
        /// </summary>
        Task<ApiRequest<GroupsGetBannedResponse>> GetBanned(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, int? userId = null);
        /// <summary>
        /// Creates a new community.
        /// </summary>
        Task<ApiRequest<GroupsGroup>> Create(UserAccessToken accessToken, string title = null, string description = null, string type = null, int? publicCategory = null, int? subtype = null);
        /// <summary>
        /// Edits a community.
        /// </summary>
        Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? groupId = null, string title = null, string description = null, string screenName = null, int? access = null, string website = null, string subject = null, string email = null, string phone = null, string rss = null, DateTime? eventStartDate = null, DateTime? eventFinishDate = null, int? eventGroupId = null, int? publicCategory = null, int? publicSubcategory = null, string publicDate = null, int? wall = null, int? topics = null, int? photos = null, int? video = null, int? audio = null, bool? links = null, bool? events = null, bool? places = null, bool? contacts = null, int? docs = null, int? wiki = null, bool? messages = null, int? ageLimits = null, bool? market = null, bool? marketComments = null, IEnumerable<int?> marketCountry = null, IEnumerable<int?> marketCity = null, int? marketCurrency = null, int? marketContact = null, int? marketWiki = null, bool? obsceneFilter = null, bool? obsceneStopwords = null, IEnumerable<string> obsceneWords = null);
        /// <summary>
        /// Edits the place in community.
        /// </summary>
        Task<ApiRequest<GroupsEditPlaceResponse>> EditPlace(UserAccessToken accessToken, int? groupId = null, string title = null, string address = null, int? countryId = null, int? cityId = null, double? latitude = null, double? longitude = null);
        /// <summary>
        /// Returns community settings.
        /// </summary>
        Task<ApiRequest<GroupsGroupSettings>> GetSettings(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns a list of requests to the community.
        /// </summary>
        Task<ApiRequest<GroupsGetRequestsResponse>> GetRequests(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of requests to the community.
        /// </summary>
        Task<ApiRequest<GroupsGetRequestsFieldsResponse>> GetRequestsFields(UserAccessToken accessToken, int? groupId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to add, remove or edit the community manager.
        /// </summary>
        Task<ApiRequest<bool?>> EditManager(UserAccessToken accessToken, int? groupId = null, int? userId = null, string role = null, bool? isContact = null, string contactPosition = null, string contactPhone = null, string contactEmail = null);
        /// <summary>
        /// Allows to invite friends to the community.
        /// </summary>
        Task<ApiRequest<bool?>> Invite(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Allows to add a link to the community.
        /// </summary>
        Task<ApiRequest<bool?>> AddLink(UserAccessToken accessToken, int? groupId = null, string link = null, string text = null);
        /// <summary>
        /// Allows to delete a link from the community.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteLink(UserAccessToken accessToken, int? groupId = null, int? linkId = null);
        /// <summary>
        /// Allows to edit a link in the community.
        /// </summary>
        Task<ApiRequest<bool?>> EditLink(UserAccessToken accessToken, int? groupId = null, int? linkId = null, string text = null);
        /// <summary>
        /// Allows to reorder links in the community.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderLink(UserAccessToken accessToken, int? groupId = null, int? linkId = null, int? after = null);
        /// <summary>
        /// Removes a user from the community.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveUser(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Allows to approve join request to the community.
        /// </summary>
        Task<ApiRequest<bool?>> ApproveRequest(UserAccessToken accessToken, int? groupId = null, int? userId = null);
        /// <summary>
        /// Returns Callback API confirmation code for the community.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns Callback API confirmation code for the community.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCode(GroupAccessToken accessToken, int? groupId = null);

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] server settings for the community.
        /// </summary>
        [Obsolete]
        Task<ApiRequest<GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(UserAccessToken accessToken, int? groupId = null);

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] server settings for the community.
        /// </summary>
        [Obsolete]
        Task<ApiRequest<GroupsGetCallbackServerSettingsResponse>> GetCallbackServerSettings(GroupAccessToken accessToken, int? groupId = null);

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] notifications settings.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackSettingsResponse>> GetCallbackSettings(UserAccessToken accessToken, int? groupId = null, int? serverId = null);

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] notifications settings.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackSettingsResponse>> GetCallbackSettings(GroupAccessToken accessToken, int? groupId = null, int? serverId = null);

        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server URL for the community.
        /// </summary>
        [Obsolete]
        Task<ApiRequest<GroupsSetCallbackServerResponse>> SetCallbackServer(UserAccessToken accessToken, int? groupId = null, string serverUrl = null);

        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server URL for the community.
        /// </summary>
        [Obsolete]
        Task<ApiRequest<GroupsSetCallbackServerResponse>> SetCallbackServer(GroupAccessToken accessToken, int? groupId = null, string serverUrl = null);

        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server settings.
        /// </summary>
        [Obsolete]
        Task<ApiRequest<bool?>> SetCallbackServerSettings(UserAccessToken accessToken, int? groupId = null, string secretKey = null);

        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server settings.
        /// </summary>
        [Obsolete]
        Task<ApiRequest<bool?>> SetCallbackServerSettings(GroupAccessToken accessToken, int? groupId = null, string secretKey = null);

        /// <summary>
        /// Allow to set notifications settings for group.
        /// </summary>
        Task<ApiRequest<bool?>> SetCallbackSettings(
            UserAccessToken accessToken,
            int? groupId = null,
            int? serverId = null,
            bool? messageNew = null,
            bool? messageReply = null,
            bool? messageAllow = null,
            bool? messageDeny = null,
            bool? photoNew = null,
            bool? audioNew = null,
            bool? videoNew = null,
            bool? wallReplyNew = null,
            bool? wallReplyEdit = null,
            bool? wallReplyDelete = null,
            bool? wallReplyRestore = null,
            bool? wallPostNew = null,
            bool? wallRepost = null,
            bool? boardPostNew = null,
            bool? boardPostEdit = null,
            bool? boardPostRestore = null,
            bool? boardPostDelete = null,
            bool? photoCommentNew = null,
            bool? photoCommentEdit = null,
            bool? photoCommentDelete = null,
            bool? photoCommentRestore = null,
            bool? videoCommentNew = null,
            bool? videoCommentEdit = null,
            bool? videoCommentDelete = null,
            bool? videoCommentRestore = null,
            bool? marketCommentNew = null,
            bool? marketCommentEdit = null,
            bool? marketCommentDelete = null,
            bool? marketCommentRestore = null,
            bool? pollVoteNew = null,
            bool? groupJoin = null,
            bool? groupLeave = null,
            bool? groupChangeSettings = null,
            bool? groupChangePhoto = null,
            bool? groupOfficersEdit = null,
            bool? userBlock = null,
            bool? userUnblock = null);

        /// <summary>
        /// Allow to set notifications settings for group.
        /// </summary>
        Task<ApiRequest<bool?>> SetCallbackSettings(
            GroupAccessToken accessToken,
            int? groupId = null,
            int? serverId = null,
            bool? messageNew = null,
            bool? messageReply = null,
            bool? messageAllow = null,
            bool? messageDeny = null,
            bool? photoNew = null,
            bool? audioNew = null,
            bool? videoNew = null,
            bool? wallReplyNew = null,
            bool? wallReplyEdit = null,
            bool? wallReplyDelete = null,
            bool? wallReplyRestore = null,
            bool? wallPostNew = null,
            bool? wallRepost = null,
            bool? boardPostNew = null,
            bool? boardPostEdit = null,
            bool? boardPostRestore = null,
            bool? boardPostDelete = null,
            bool? photoCommentNew = null,
            bool? photoCommentEdit = null,
            bool? photoCommentDelete = null,
            bool? photoCommentRestore = null,
            bool? videoCommentNew = null,
            bool? videoCommentEdit = null,
            bool? videoCommentDelete = null,
            bool? videoCommentRestore = null,
            bool? marketCommentNew = null,
            bool? marketCommentEdit = null,
            bool? marketCommentDelete = null,
            bool? marketCommentRestore = null,
            bool? pollVoteNew = null,
            bool? groupJoin = null,
            bool? groupLeave = null,
            bool? groupChangeSettings = null,
            bool? groupChangePhoto = null,
            bool? groupOfficersEdit = null,
            bool? userBlock = null,
            bool? userUnblock = null);
    }
}
