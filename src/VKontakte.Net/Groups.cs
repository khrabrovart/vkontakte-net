using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class GroupsAddress
    {
        public string AdditionalAddress { get; set; } 

        public string Address { get; set; } 

        public int? CityId { get; set; } 

        public int? CountryId { get; set; } 

        public int? Distance { get; set; } 

        public int? Id { get; set; } 

        public double? Latitude { get; set; } 

        public double? Longitude { get; set; } 

        public int? MetroStationId { get; set; } 

        public string Phone { get; set; } 

        public int? TimeOffset { get; set; } 

        public GroupsAddressTimetable Timetable { get; set; } 

        public string Title { get; set; } 

        public GroupsAddressWorkInfoStatus WorkInfoStatus { get; set; } 
    }

    public class GroupsAddressesInfo
    {
        public bool? IsEnabled { get; set; } 

        public int? MainAddressId { get; set; } 
    }

    public class GroupsAddressTimetable
    {
        public GroupsAddressTimetableDay Fri { get; set; } 

        public GroupsAddressTimetableDay Mon { get; set; } 

        public GroupsAddressTimetableDay Sat { get; set; } 

        public GroupsAddressTimetableDay Sun { get; set; } 

        public GroupsAddressTimetableDay Thu { get; set; } 

        public GroupsAddressTimetableDay Tue { get; set; } 

        public GroupsAddressTimetableDay Wed { get; set; } 
    }

    public class GroupsAddressTimetableDay
    {
        public int? BreakCloseTime { get; set; } 

        public int? BreakOpenTime { get; set; } 

        public int? CloseTime { get; set; } 

        public int? OpenTime { get; set; } 
    }

    public class GroupsAddressWorkInfoStatus
    {
    }

    public class GroupsBanInfo
    {
        public int? AdminId { get; set; } 

        public string Comment { get; set; } 

        public int? Date { get; set; } 

        public int? EndDate { get; set; } 

        public GroupsBanInfoReason Reason { get; set; } 
    }

    public class GroupsBanInfoReason
    {
    }

    public class GroupsCallbackSettings
    {
        public string ApiVersion { get; set; } 

        public GroupsLongPollEvents Events { get; set; } 
    }

    public class GroupsContactsItem
    {
        public string Desc { get; set; } 

        public string Email { get; set; } 

        public string Phone { get; set; } 

        public int? UserId { get; set; } 
    }

    public class GroupsCountersGroup
    {
        public int? Addresses { get; set; } 

        public int? Albums { get; set; } 

        public int? Audios { get; set; } 

        public int? Docs { get; set; } 

        public int? Market { get; set; } 

        public int? Photos { get; set; } 

        public int? Topics { get; set; } 

        public int? Videos { get; set; } 
    }

    public class GroupsCover
    {
        public bool? Enabled { get; set; } 

        public IEnumerable<object> Images { get; set; } 
    }

    public class GroupsFields
    {
    }

    public class GroupsFilter
    {
    }

    public class GroupsGroup
    {
        public GroupsGroupAdminLevel AdminLevel { get; set; } 

        public string Deactivated { get; set; } 

        public int? FinishDate { get; set; } 

        public int? Id { get; set; } 

        public bool? IsAdmin { get; set; } 

        public bool? IsAdvertiser { get; set; } 

        public GroupsGroupIsClosed IsClosed { get; set; } 

        public bool? IsMember { get; set; } 

        public string Name { get; set; } 

        public string Photo100 { get; set; } 

        public string Photo200 { get; set; } 

        public string Photo50 { get; set; } 

        public string ScreenName { get; set; } 

        public int? StartDate { get; set; } 

        public GroupsGroupType Type { get; set; } 
    }

    public class GroupsGroupAccess
    {
    }

    public class GroupsGroupAdminLevel
    {
    }

    public class GroupsGroupAgeLimits
    {
    }

    public class GroupsGroupAudio
    {
    }

    public class GroupsGroupBanInfo
    {
        public string Comment { get; set; } 

        public int? EndDate { get; set; } 
    }

    public class GroupsGroupCategory
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public IEnumerable<object> Subcategories { get; set; } 
    }

    public class GroupsGroupCategoryFull
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public int? PageCount { get; set; } 

        public IEnumerable<object> PagePreviews { get; set; } 

        public IEnumerable<object> Subcategories { get; set; } 
    }

    public class GroupsGroupCategoryType
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 
    }

    public class GroupsGroupDocs
    {
    }

    public class GroupsGroupFull
    {
    }

    public class GroupsGroupFullAgeLimits
    {
    }

    public class GroupsGroupFullMainSection
    {
    }

    public class GroupsGroupFullMemberStatus
    {
    }

    public class GroupsGroupIsClosed
    {
    }

    public class GroupsGroupLink
    {
        public string Desc { get; set; } 

        public bool? EditTitle { get; set; } 

        public int? Id { get; set; } 

        public bool? ImageProcessing { get; set; } 

        public string Url { get; set; } 
    }

    public class GroupsGroupMarketCurrency
    {
    }

    public class GroupsGroupPhotos
    {
    }

    public class GroupsGroupPublicCategoryList
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public IEnumerable<object> SubtypesList { get; set; } 
    }

    public class GroupsGroupRole
    {
    }

    public class GroupsGroupsArray
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class GroupsGroupSettings
    {
        public int? Access { get; set; } 

        public string Address { get; set; } 

        public int? Audio { get; set; } 

        public string Description { get; set; } 

        public int? Docs { get; set; } 

        public bool? ObsceneFilter { get; set; } 

        public bool? ObsceneStopwords { get; set; } 

        public string ObsceneWords { get; set; } 

        public int? Photos { get; set; } 

        public int? PublicCategory { get; set; } 

        public IEnumerable<object> PublicCategoryList { get; set; } 

        public int? PublicSubcategory { get; set; } 

        public string Rss { get; set; } 

        public int? Subject { get; set; } 

        public IEnumerable<object> SubjectList { get; set; } 

        public string Title { get; set; } 

        public int? Topics { get; set; } 

        public int? Video { get; set; } 

        public int? Wall { get; set; } 

        public string Website { get; set; } 

        public int? Wiki { get; set; } 
    }

    public class GroupsGroupSubject
    {
    }

    public class GroupsGroupTopics
    {
    }

    public class GroupsGroupType
    {
    }

    public class GroupsGroupVideo
    {
    }

    public class GroupsGroupWall
    {
    }

    public class GroupsGroupWiki
    {
    }

    public class GroupsGroupXtrInvitedBy
    {
        public GroupsGroupXtrInvitedByAdminLevel AdminLevel { get; set; } 

        public string Id { get; set; } 

        public int? InvitedBy { get; set; } 

        public bool? IsAdmin { get; set; } 

        public bool? IsClosed { get; set; } 

        public bool? IsMember { get; set; } 

        public string Name { get; set; } 

        public string Photo100 { get; set; } 

        public string Photo200 { get; set; } 

        public string Photo50 { get; set; } 

        public string ScreenName { get; set; } 

        public GroupsGroupXtrInvitedByType Type { get; set; } 
    }

    public class GroupsGroupXtrInvitedByAdminLevel
    {
    }

    public class GroupsGroupXtrInvitedByType
    {
    }

    public class GroupsLinksItem
    {
        public string Desc { get; set; } 

        public bool? EditTitle { get; set; } 

        public int? Id { get; set; } 

        public string Name { get; set; } 

        public string Photo100 { get; set; } 

        public string Photo50 { get; set; } 

        public string Url { get; set; } 
    }

    public class GroupsLongPollEvents
    {
        public bool? AudioNew { get; set; } 

        public bool? BoardPostDelete { get; set; } 

        public bool? BoardPostEdit { get; set; } 

        public bool? BoardPostNew { get; set; } 

        public bool? BoardPostRestore { get; set; } 

        public bool? GroupChangePhoto { get; set; } 

        public bool? GroupChangeSettings { get; set; } 

        public bool? GroupJoin { get; set; } 

        public bool? GroupLeave { get; set; } 

        public bool? GroupOfficersEdit { get; set; } 

        public bool? LeadFormsNew { get; set; } 

        public bool? MarketCommentDelete { get; set; } 

        public bool? MarketCommentEdit { get; set; } 

        public bool? MarketCommentNew { get; set; } 

        public bool? MarketCommentRestore { get; set; } 

        public bool? MessageAllow { get; set; } 

        public bool? MessageDeny { get; set; } 

        public bool? MessageNew { get; set; } 

        public bool? MessageRead { get; set; } 

        public bool? MessageReply { get; set; } 

        public bool? MessageTypingState { get; set; } 

        public bool? MessagesEdit { get; set; } 

        public bool? PhotoCommentDelete { get; set; } 

        public bool? PhotoCommentEdit { get; set; } 

        public bool? PhotoCommentNew { get; set; } 

        public bool? PhotoCommentRestore { get; set; } 

        public bool? PhotoNew { get; set; } 

        public bool? PollVoteNew { get; set; } 

        public bool? UserBlock { get; set; } 

        public bool? UserUnblock { get; set; } 

        public bool? VideoCommentDelete { get; set; } 

        public bool? VideoCommentEdit { get; set; } 

        public bool? VideoCommentNew { get; set; } 

        public bool? VideoCommentRestore { get; set; } 

        public bool? VideoNew { get; set; } 

        public bool? WallPostNew { get; set; } 

        public bool? WallReplyDelete { get; set; } 

        public bool? WallReplyEdit { get; set; } 

        public bool? WallReplyNew { get; set; } 

        public bool? WallReplyRestore { get; set; } 

        public bool? WallRepost { get; set; } 
    }

    public class GroupsLongPollServer
    {
        public string Key { get; set; } 

        public string Server { get; set; } 

        public int? Ts { get; set; } 
    }

    public class GroupsLongPollSettings
    {
        public string ApiVersion { get; set; } 

        public GroupsLongPollEvents Events { get; set; } 

        public bool? IsEnabled { get; set; } 
    }

    public class GroupsMarketInfo
    {
        public int? ContactId { get; set; } 

        public MarketCurrency Currency { get; set; } 

        public string CurrencyText { get; set; } 

        public bool? Enabled { get; set; } 

        public int? MainAlbumId { get; set; } 

        public int? PriceMax { get; set; } 

        public int? PriceMin { get; set; } 
    }

    public class GroupsMemberRole
    {
        public int? Id { get; set; } 

        public GroupsMemberRoleStatus Role { get; set; } 
    }

    public class GroupsMemberRoleStatus
    {
    }

    public class GroupsMemberStatus
    {
        public bool? Member { get; set; } 

        public int? UserId { get; set; } 
    }

    public class GroupsMemberStatusFull
    {
        public bool? Invitation { get; set; } 

        public bool? Member { get; set; } 

        public bool? Request { get; set; } 

        public int? UserId { get; set; } 
    }

    public class GroupsOnlineStatus
    {
        public int? Minutes { get; set; } 

        public GroupsOnlineStatusType Status { get; set; } 
    }

    public class GroupsOnlineStatusType
    {
    }

    public class GroupsOwnerXtrBanInfo
    {
        public GroupsBanInfo BanInfo { get; set; } 

        public GroupsGroup Group { get; set; } 

        public UsersUser Profile { get; set; } 

        public GroupsOwnerXtrBanInfoType Type { get; set; } 
    }

    public class GroupsOwnerXtrBanInfoType
    {
    }

    public class GroupsRoleOptions
    {
    }

    public class GroupsSubjectItem
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 
    }

    public class GroupsUserXtrRole
    {
    }
}
