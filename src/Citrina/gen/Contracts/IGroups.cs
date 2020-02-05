using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IGroupsApi
    {
        Task<ApiRequest<GroupsAddress>> AddAddressApi(int? groupId = null, string title = null, string address = null, string additionalAddress = null, int? countryId = null, int? cityId = null, int? metroId = null, double? latitude = null, double? longitude = null, string phone = null, string workInfoStatus = null, string timetable = null, bool? isMainAddress = null);

        Task<ApiRequest<GroupsAddCallbackServerResponse>> AddCallbackServerApi(int? groupId = null, string url = null, string title = null, string secretKey = null);

        /// <summary>
        /// Allows to add a link to the community.
        /// </summary>
        Task<ApiRequest<GroupsGroupLink>> AddLinkApi(int? groupId = null, string link = null, string text = null);

        /// <summary>
        /// Allows to approve join request to the community.
        /// </summary>
        Task<ApiRequest<bool?>> ApproveRequestApi(int? groupId = null, int? userId = null);

        Task<ApiRequest<bool?>> BanApi(int? groupId = null, int? ownerId = null, int? endDate = null, int? reason = null, string comment = null, bool? commentVisible = null);

        /// <summary>
        /// Creates a new community.
        /// </summary>
        Task<ApiRequest<GroupsGroup>> CreateApi(string title = null, string description = null, string type = null, int? publicCategory = null, int? subtype = null);

        Task<ApiRequest<bool?>> DeleteCallbackServerApi(int? groupId = null, int? serverId = null);

        /// <summary>
        /// Allows to delete a link from the community.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteLinkApi(int? groupId = null, int? linkId = null);

        Task<ApiRequest<bool?>> DisableOnlineApi(int? groupId = null);

        /// <summary>
        /// Edits a community.
        /// </summary>
        Task<ApiRequest<bool?>> EditApi(int? groupId = null, string title = null, string description = null, string screenName = null, int? access = null, string website = null, string subject = null, string email = null, string phone = null, string rss = null, int? eventStartDate = null, int? eventFinishDate = null, int? eventGroupId = null, int? publicCategory = null, int? publicSubcategory = null, string publicDate = null, int? wall = null, int? topics = null, int? photos = null, int? video = null, int? audio = null, bool? links = null, bool? events = null, bool? places = null, bool? contacts = null, int? docs = null, int? wiki = null, bool? messages = null, bool? articles = null, bool? addresses = null, int? ageLimits = null, bool? market = null, bool? marketComments = null, IEnumerable<int> marketCountry = null, IEnumerable<int> marketCity = null, int? marketCurrency = null, int? marketContact = null, int? marketWiki = null, bool? obsceneFilter = null, bool? obsceneStopwords = null, IEnumerable<string> obsceneWords = null, int? mainSection = null, int? secondarySection = null, int? country = null, int? city = null);

        Task<ApiRequest<GroupsAddress>> EditAddressApi(int? groupId = null, int? addressId = null, string title = null, string address = null, string additionalAddress = null, int? countryId = null, int? cityId = null, int? metroId = null, double? latitude = null, double? longitude = null, string phone = null, string workInfoStatus = null, string timetable = null, bool? isMainAddress = null);

        Task<ApiRequest<bool?>> EditCallbackServerApi(int? groupId = null, int? serverId = null, string url = null, string title = null, string secretKey = null);

        /// <summary>
        /// Allows to edit a link in the community.
        /// </summary>
        Task<ApiRequest<bool?>> EditLinkApi(int? groupId = null, int? linkId = null, string text = null);

        /// <summary>
        /// Allows to add, remove or edit the community manager.
        /// </summary>
        Task<ApiRequest<bool?>> EditManagerApi(int? groupId = null, int? userId = null, string role = null, bool? isContact = null, string contactPosition = null, string contactPhone = null, string contactEmail = null);

        Task<ApiRequest<bool?>> EnableOnlineApi(int? groupId = null);

        /// <summary>
        /// Returns a list of the communities to which a user belongs.
        /// </summary>
        Task<ApiRequest<GroupsGetResponse>> GetApi(int? userId = null, bool? extended = null, IEnumerable<GroupsFilter> filter = null, IEnumerable<GroupsFields> fields = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns a list of the communities to which a user belongs.
        /// </summary>
        Task<ApiRequest<GroupsGetExtendedResponse>> GetApi(int? userId = null, bool? extended = null, IEnumerable<GroupsFilter> filter = null, IEnumerable<GroupsFields> fields = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns a list of community addresses.
        /// </summary>
        Task<ApiRequest<GroupsGetAddressesResponse>> GetAddressesApi(int? groupId = null, IEnumerable<int> addressIds = null, double? latitude = null, double? longitude = null, int? offset = null, int? count = null, IEnumerable<AddressesFields> fields = null);

        /// <summary>
        /// Returns a list of users on a community blacklist.
        /// </summary>
        Task<ApiRequest<GroupsGetBannedResponse>> GetBannedApi(int? groupId = null, int? offset = null, int? count = null, IEnumerable<BaseUserGroupFields> fields = null, int? ownerId = null);

        /// <summary>
        /// Returns information about communities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsGroupFull>>> GetByIdApi(IEnumerable<string> groupIds = null, string groupId = null, IEnumerable<GroupsFields> fields = null);

        /// <summary>
        /// Returns Callback API confirmation code for the community.
        /// </summary>
        Task<ApiRequest<GroupsGetCallbackConfirmationCodeResponse>> GetCallbackConfirmationCodeApi(int? groupId = null);

        Task<ApiRequest<GroupsGetCallbackServersResponse>> GetCallbackServersApi(int? groupId = null, IEnumerable<int> serverIds = null);

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] notifications settings.
        /// </summary>
        Task<ApiRequest<GroupsCallbackSettings>> GetCallbackSettingsApi(int? groupId = null, int? serverId = null);

        /// <summary>
        /// Returns communities list for a catalog category.
        /// </summary>
        Task<ApiRequest<GroupsGetCatalogResponse>> GetCatalogApi(int? categoryId = null, int? subcategoryId = null);

        /// <summary>
        /// Returns categories list for communities catalog.
        /// </summary>
        Task<ApiRequest<GroupsGetCatalogInfoResponse>> GetCatalogInfoApi(bool? extended = null, bool? subcategories = null);

        /// <summary>
        /// Returns categories list for communities catalog.
        /// </summary>
        Task<ApiRequest<GroupsGetCatalogInfoExtendedResponse>> GetCatalogInfoApi(bool? extended = null, bool? subcategories = null);

        /// <summary>
        /// Returns invited users list of a community.
        /// </summary>
        Task<ApiRequest<GroupsGetInvitedUsersResponse>> GetInvitedUsersApi(int? groupId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string nameCase = null);

        /// <summary>
        /// Returns a list of invitations to join communities and events.
        /// </summary>
        Task<ApiRequest<GroupsGetInvitesResponse>> GetInvitesApi(int? offset = null, int? count = null, bool? extended = null);

        /// <summary>
        /// Returns a list of invitations to join communities and events.
        /// </summary>
        Task<ApiRequest<GroupsGetInvitesExtendedResponse>> GetInvitesApi(int? offset = null, int? count = null, bool? extended = null);

        /// <summary>
        /// Returns the data needed to query a Long Poll server for events.
        /// </summary>
        Task<ApiRequest<GroupsLongPollServer>> GetLongPollServerApi(int? groupId = null);

        /// <summary>
        /// Returns Long Poll notification settings.
        /// </summary>
        Task<ApiRequest<GroupsLongPollSettings>> GetLongPollSettingsApi(int? groupId = null);

        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersResponse>> GetMembersApi(string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string filter = null);

        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFieldsResponse>> GetMembersApi(string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string filter = null);

        /// <summary>
        /// Returns a list of community members.
        /// </summary>
        Task<ApiRequest<GroupsGetMembersFilterResponse>> GetMembersApi(string groupId = null, string sort = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string filter = null);

        /// <summary>
        /// Returns a list of requests to the community.
        /// </summary>
        Task<ApiRequest<GroupsGetRequestsResponse>> GetRequestsApi(int? groupId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns a list of requests to the community.
        /// </summary>
        Task<ApiRequest<GroupsGetRequestsFieldsResponse>> GetRequestsApi(int? groupId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns community settings.
        /// </summary>
        Task<ApiRequest<GroupsGroupSettings>> GetSettingsApi(int? groupId = null);

        Task<ApiRequest<GroupsGetTokenPermissionsResponse>> GetTokenPermissionsApi();

        /// <summary>
        /// Allows to invite friends to the community.
        /// </summary>
        Task<ApiRequest<bool?>> InviteApi(int? groupId = null, int? userId = null);

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<bool?>> IsMemberApi(string groupId = null, int? userId = null, IEnumerable<int> userIds = null, bool? extended = null);

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatus>>> IsMemberApi(string groupId = null, int? userId = null, IEnumerable<int> userIds = null, bool? extended = null);

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<GroupsIsMemberExtendedResponse>> IsMemberApi(string groupId = null, int? userId = null, IEnumerable<int> userIds = null, bool? extended = null);

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// </summary>
        Task<ApiRequest<IEnumerable<GroupsMemberStatusFull>>> IsMemberApi(string groupId = null, int? userId = null, IEnumerable<int> userIds = null, bool? extended = null);

        /// <summary>
        /// With this method you can join the group or public page, and also confirm your participation in an event.
        /// </summary>
        Task<ApiRequest<bool?>> JoinApi(int? groupId = null, string notSure = null);

        /// <summary>
        /// With this method you can leave a group, public page, or event.
        /// </summary>
        Task<ApiRequest<bool?>> LeaveApi(int? groupId = null);

        /// <summary>
        /// Removes a user from the community.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveUserApi(int? groupId = null, int? userId = null);

        /// <summary>
        /// Allows to reorder links in the community.
        /// </summary>
        Task<ApiRequest<bool?>> ReorderLinkApi(int? groupId = null, int? linkId = null, int? after = null);

        /// <summary>
        /// Returns a list of communities matching the search criteria.
        /// </summary>
        Task<ApiRequest<GroupsSearchResponse>> SearchApi(string q = null, string type = null, int? countryId = null, int? cityId = null, bool? future = null, bool? market = null, int? sort = null, int? offset = null, int? count = null);

        /// <summary>
        /// Allow to set notifications settings for group.
        /// </summary>
        Task<ApiRequest<bool?>> SetCallbackSettingsApi(int? groupId = null, int? serverId = null, string apiVersion = null, bool? messageNew = null, bool? messageReply = null, bool? messageAllow = null, bool? messageEdit = null, bool? messageDeny = null, bool? messageTypingState = null, bool? photoNew = null, bool? audioNew = null, bool? videoNew = null, bool? wallReplyNew = null, bool? wallReplyEdit = null, bool? wallReplyDelete = null, bool? wallReplyRestore = null, bool? wallPostNew = null, bool? wallRepost = null, bool? boardPostNew = null, bool? boardPostEdit = null, bool? boardPostRestore = null, bool? boardPostDelete = null, bool? photoCommentNew = null, bool? photoCommentEdit = null, bool? photoCommentDelete = null, bool? photoCommentRestore = null, bool? videoCommentNew = null, bool? videoCommentEdit = null, bool? videoCommentDelete = null, bool? videoCommentRestore = null, bool? marketCommentNew = null, bool? marketCommentEdit = null, bool? marketCommentDelete = null, bool? marketCommentRestore = null, bool? pollVoteNew = null, bool? groupJoin = null, bool? groupLeave = null, bool? groupChangeSettings = null, bool? groupChangePhoto = null, bool? groupOfficersEdit = null, bool? userBlock = null, bool? userUnblock = null, bool? leadFormsNew = null);

        /// <summary>
        /// Sets Long Poll notification settings.
        /// </summary>
        Task<ApiRequest<bool?>> SetLongPollSettingsApi(int? groupId = null, bool? enabled = null, string apiVersion = null, bool? messageNew = null, bool? messageReply = null, bool? messageAllow = null, bool? messageDeny = null, bool? messageEdit = null, bool? messageTypingState = null, bool? photoNew = null, bool? audioNew = null, bool? videoNew = null, bool? wallReplyNew = null, bool? wallReplyEdit = null, bool? wallReplyDelete = null, bool? wallReplyRestore = null, bool? wallPostNew = null, bool? wallRepost = null, bool? boardPostNew = null, bool? boardPostEdit = null, bool? boardPostRestore = null, bool? boardPostDelete = null, bool? photoCommentNew = null, bool? photoCommentEdit = null, bool? photoCommentDelete = null, bool? photoCommentRestore = null, bool? videoCommentNew = null, bool? videoCommentEdit = null, bool? videoCommentDelete = null, bool? videoCommentRestore = null, bool? marketCommentNew = null, bool? marketCommentEdit = null, bool? marketCommentDelete = null, bool? marketCommentRestore = null, bool? pollVoteNew = null, bool? groupJoin = null, bool? groupLeave = null, bool? groupChangeSettings = null, bool? groupChangePhoto = null, bool? groupOfficersEdit = null, bool? userBlock = null, bool? userUnblock = null);

        Task<ApiRequest<bool?>> UnbanApi(int? groupId = null, int? ownerId = null);
    }
}
