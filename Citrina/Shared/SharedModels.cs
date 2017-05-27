using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountAccountCounters
    {
        public int? Friends { get; set; }
        public int? Messages { get; set; }
        public int? Photos { get; set; }
        public int? Videos { get; set; }
        public int? Gifts { get; set; }
        public int? Events { get; set; }
        public int? Groups { get; set; }
        public int? Notifications { get; set; }
        public int? AppRequests { get; set; }
        public int? FriendsSuggestions { get; set; }
    }

    public class AccountLookupResult
    {
        public IEnumerable<AccountUserXtrContact> Found { get; set; }
        public IEnumerable<AccountOtherContact> Other { get; set; }
    }

    public class AccountNameRequest
    {
        public int? Id { get; set; }
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class AccountOffer
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Instruction { get; set; }
        public string InstructionHtml { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string Tag { get; set; }
        public int? Price { get; set; }
    }

    public class AccountOtherContact
    {
        public string Contact { get; set; }
        public int? CommonCount { get; set; }
    }

    public class AccountPushConversations
    {
        public int? Count { get; set; }
        public IEnumerable<AccountPushConversationsItem> Items { get; set; }
    }

    public class AccountPushConversationsItem
    {
        public int? PeerId { get; set; }
        public bool? Sound { get; set; }
        public int? DisabledUntil { get; set; }
    }

    public class AccountPushParams
    {
        public IEnumerable<string> Msg { get; set; }
        public IEnumerable<string> Chat { get; set; }
        public IEnumerable<string> Friend { get; set; }
        public IEnumerable<string> FriendFound { get; set; }
        public IEnumerable<string> FriendAccepted { get; set; }
        public IEnumerable<string> Reply { get; set; }
        public IEnumerable<string> Comment { get; set; }
        public IEnumerable<string> Mention { get; set; }
        public IEnumerable<string> Like { get; set; }
        public IEnumerable<string> Repost { get; set; }
        public IEnumerable<string> WallPost { get; set; }
        public IEnumerable<string> WallPublish { get; set; }
        public IEnumerable<string> GroupInvite { get; set; }
        public IEnumerable<string> GroupAccepted { get; set; }
        public IEnumerable<string> EventSoon { get; set; }
        public IEnumerable<string> PhotosTag { get; set; }
        public IEnumerable<string> AppRequest { get; set; }
        public IEnumerable<string> SdkOpen { get; set; }
        public IEnumerable<string> NewPost { get; set; }
        public IEnumerable<string> Birthday { get; set; }
    }

    public class AccountPushSettings
    {
        public bool? Disabled { get; set; }
        public int? DisabledUntil { get; set; }
        public AccountPushConversations Conversations { get; set; }
        public AccountPushParams Settings { get; set; }
    }

    public class AccountUserSettings
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string ScreenName { get; set; }
        public int? Sex { get; set; }
        public int? Relation { get; set; }
        public UsersUserMin RelationPartner { get; set; }
        public int? RelationPending { get; set; }
        public IEnumerable<UsersUserMin> RelationRequests { get; set; }
        public string Bdate { get; set; }
        public int? BdateVisibility { get; set; }
        public string HomeTown { get; set; }
        public BaseCountry Country { get; set; }
        public BaseObject City { get; set; }
        public string Status { get; set; }
        public string Phone { get; set; }
        public AccountNameRequest NameRequest { get; set; }
    }

    public class AccountUserXtrContact : UsersUserFull
    {
        public string Contact { get; set; }
        public int? RequestSent { get; set; }
        public int? SortNum { get; set; }
    }

    public class AccountInfo
    {
        public string Country { get; set; }
        public bool? HttpsRequired { get; set; }
        public bool? OwnPostsDefault { get; set; }
        public bool? NoWallReplies { get; set; }
        public bool? Intro { get; set; }
        public int? Lang { get; set; }

        [JsonProperty("2fa_required")]
        public bool? TwoFactorRequired { get; set; }
    }

    public class AdsAccesses
    {
        public string ClientId { get; set; }
        public string Role { get; set; }
    }

    public class AdsAccount
    {
        public int? AccountId { get; set; }
        public string AccountType { get; set; }
        public bool? AccountStatus { get; set; }
        public string AccessRole { get; set; }
    }

    public class AdsAd
    {
        public int? Id { get; set; }
        public int? CampaignId { get; set; }
        public int? AdFormat { get; set; }
        public int? CostType { get; set; }
        public int? Cpc { get; set; }
        public int? Cpm { get; set; }
        public int? ImpressionsLimit { get; set; }
        public int? ImpressionsLimited { get; set; }
        public string AdPlatform { get; set; }
        public int? AllLimit { get; set; }
        public int? Category1Id { get; set; }
        public int? Category2Id { get; set; }
        public int? Status { get; set; }
        public string Name { get; set; }
        public int? Approved { get; set; }
        public bool? Video { get; set; }
        public bool? DisclaimerMedical { get; set; }
        public bool? DisclaimerSpecialist { get; set; }
        public bool? DisclaimerSupplements { get; set; }
    }

    public class AdsAdLayout
    {
        public int? Id { get; set; }
        public int? CampaignId { get; set; }
        public int? AdFormat { get; set; }
        public int? CostType { get; set; }
        public bool? Video { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LinkUrl { get; set; }
        public string LinkDomain { get; set; }
        public string PreviewLink { get; set; }
        public int? ImageSrc { get; set; }
        public int? ImageSrc2x { get; set; }
    }

    public class AdsCampaign
    {
        public int? Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int? Status { get; set; }
        public string DayLimit { get; set; }
        public string AllLimit { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
    }

    public class AdsCategory
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<BaseObjectWithName> Subcategories { get; set; }
    }

    public class AdsClient
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string DayLimit { get; set; }
        public string AllLimit { get; set; }
    }

    public class AdsCriteria
    {
        public int? Sex { get; set; }
        public int? AgeFrom { get; set; }
        public int? AgeTo { get; set; }
        public int? Birthday { get; set; }
        public int? Country { get; set; }
        public string Cities { get; set; }
        public string CitiesNot { get; set; }
        public string Statuses { get; set; }
        public string Groups { get; set; }
        public string Apps { get; set; }
        public string AppsNot { get; set; }
        public string Districts { get; set; }
        public string Stations { get; set; }
        public string Streets { get; set; }
        public string Schools { get; set; }
        public string Positions { get; set; }
        public string Religions { get; set; }
        public string Interests { get; set; }
        public string InterestCategories { get; set; }
        public string UserDevices { get; set; }
        public string UserOs { get; set; }
        public string UserBrowsers { get; set; }
        public string RetargetingGroups { get; set; }
        public string RetargetingGroupsNot { get; set; }
        public bool? Paying { get; set; }
        public bool? Travellers { get; set; }
        public int? SchoolFrom { get; set; }
        public int? SchoolTo { get; set; }
        public int? UniFrom { get; set; }
        public int? UniTo { get; set; }
    }

    public class AdsDemoStats
    {
        public int? Id { get; set; }
        public string Type { get; set; }
        public AdsDemostatsFormat Stats { get; set; }
    }

    public class AdsDemostatsFormat
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public int? Overall { get; set; }
        public IEnumerable<AdsStatsSex> Sex { get; set; }
        public IEnumerable<AdsStatsAge> Age { get; set; }
        public IEnumerable<AdsStatsSexAge> SexAge { get; set; }
        public IEnumerable<AdsStatsCities> Cities { get; set; }
    }

    public class AdsFloodStats
    {
        public int? Left { get; set; }
        public int? Refresh { get; set; }
    }

    public class AdsLinkStatus
    {
        public string Status { get; set; }
        public string Description { get; set; }
        public string RedirectUrl { get; set; }
    }

    public class AdsParagraphs
    {
        public string Paragraph { get; set; }
    }

    public class AdsRejectReason
    {
        public string Comment { get; set; }
        public IEnumerable<AdsRules> Rules { get; set; }
    }

    public class AdsRules
    {
        public string Title { get; set; }
        public IEnumerable<AdsParagraphs> Paragraphs { get; set; }
    }

    public class AdsStats
    {
        public int? Id { get; set; }
        public string Type { get; set; }
        public AdsStatsFormat Stats { get; set; }
    }

    public class AdsStatsFormat
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public int? Overall { get; set; }
        public int? Spent { get; set; }
        public int? Impressions { get; set; }
        public int? Clicks { get; set; }
        public int? Reach { get; set; }
        public int? VideoViews { get; set; }
        public int? VideoViewsHalf { get; set; }
        public int? VideoViewsFull { get; set; }
        public int? VideoClicksSite { get; set; }
        public int? JoinRate { get; set; }
    }

    public class AdsStatsAge
    {
        public double? ImpressionsRate { get; set; }
        public double? ClicksRate { get; set; }
        public string Value { get; set; }
    }

    public class AdsStatsCities
    {
        public double? ImpressionsRate { get; set; }
        public double? ClicksRate { get; set; }
        public int? Value { get; set; }
        public string Name { get; set; }
    }

    public class AdsStatsSex
    {
        public double? ImpressionsRate { get; set; }
        public double? ClicksRate { get; set; }
        public string Value { get; set; }
    }

    public class AdsStatsSexAge
    {
        public double? ImpressionsRate { get; set; }
        public double? ClicksRate { get; set; }
        public string Value { get; set; }
    }

    public class AdsTargStats
    {
        public int? AudienceCount { get; set; }
        public double? RecommendedCpc { get; set; }
        public double? RecommendedCpm { get; set; }
    }

    public class AdsTargSuggestions
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }

    public class AdsTargSuggestionsRegions
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class AdsTargSuggestionsCities
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
    }

    public class AdsTargSuggestionsSchools
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Type { get; set; }
        public string Parent { get; set; }
    }

    public class AdsTargSettings : AdsCriteria
    {
        public int? Id { get; set; }
        public int? CampaignId { get; set; }
    }

    public class AdsTargetGroup
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int? AudienceCount { get; set; }
        public int? Lifetime { get; set; }
        public string Pixel { get; set; }
    }

    public class AdsUsers
    {
        public int? UserId { get; set; }
        public IEnumerable<AdsAccesses> Accesses { get; set; }
    }

    public class AdsPostStats : StatsWallpostStat
    {
        public int? AdId { get; set; }
    }

    public class AppsApp
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string ScreenName { get; set; }
        public string Description { get; set; }
        public string Icon278 { get; set; }
        public string Icon150 { get; set; }
        public string Icon139 { get; set; }
        public string Icon75 { get; set; }
        public string Banner560 { get; set; }
        public string Banner1120 { get; set; }
        public string Type { get; set; }
        public string Section { get; set; }
        public string AuthorUrl { get; set; }
        public int? AuthorId { get; set; }
        public int? AuthorGroup { get; set; }
        public int? MembersCount { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? CatalogPosition { get; set; }
        public IEnumerable<PhotosPhoto> Screenshots { get; set; }
        public int? International { get; set; }
        public int? LeaderboardType { get; set; }
        public int? GenreId { get; set; }
        public string Genre { get; set; }
        public int? PlatformId { get; set; }
        public int? IsInCatalog { get; set; }
    }

    public class AppsLeaderboard
    {
        public int? Score { get; set; }
        public int? Level { get; set; }
        public int? Points { get; set; }
        public int? UserId { get; set; }
    }

    public class AudioAudioAlbum
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
    }

    public class AudioAudio
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string AccessKey { get; set; }
    }

    public class AudioAudioFull : AudioAudio
    {
        public int? Duration { get; set; }
        public DateTime? Date { get; set; }
        public int? AlbumId { get; set; }
        public int? LyricsId { get; set; }
        public int? GenreId { get; set; }
        public bool? NoSearch { get; set; }
    }

    public class AudioLyrics
    {
        public int? LyricsId { get; set; }
        public string Text { get; set; }
    }

    public class AudioAudioUploadResponse
    {
        public string Redirect { get; set; }
        public int? Server { get; set; }
        public string Audio { get; set; }
        public string Hash { get; set; }
    }

    public class BaseCommentsInfo
    {
        public int? Count { get; set; }
        public int? CanPost { get; set; }
    }

    public class BaseCountry
    {
        public int? Id { get; set; }
        public string Title { get; set; }
    }

    public class BaseError
    {
        public int? ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
        public IEnumerable<BaseRequestParam> RequestParams { get; set; }
    }

    public class BaseRequestParam
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class BaseGeo
    {
        public string Type { get; set; }
        public string Coordinates { get; set; }
        public BasePlace Place { get; set; }
        public int? Showmap { get; set; }
    }

    public class BaseLikesInfo
    {
        public int? Count { get; set; }
        public int? UserLikes { get; set; }
        public int? CanLike { get; set; }
        public int? CanPublish { get; set; }
    }

    public class BaseLikes
    {
        public bool? UserLikes { get; set; }
        public int? Count { get; set; }
    }

    public class BaseLink
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public PhotosPhoto Photo { get; set; }
        public bool? IsExternal { get; set; }
        public string PreviewUrl { get; set; }
        public string PreviewPage { get; set; }
        public BaseLinkButton Button { get; set; }
        public BaseLinkProduct Product { get; set; }
        public BaseLinkRating Rating { get; set; }
        public BaseLinkApplication Application { get; set; }
    }

    public class BaseLinkButton
    {
        public string Title { get; set; }
        public BaseLinkButtonAction Action { get; set; }
    }

    public class BaseLinkButtonAction
    {
        public string Type { get; set; }
        public string Url { get; set; }
    }

    public class BaseLinkProduct
    {
        public MarketPrice Price { get; set; }
    }

    public class BaseLinkApplication
    {
        public double? AppId { get; set; }
        public BaseLinkApplicationStore Store { get; set; }
    }

    public class BaseLinkApplicationStore
    {
        public double? Id { get; set; }
        public string Name { get; set; }
    }

    public class BaseLinkRating
    {
        public double? Stars { get; set; }
        public int? ReviewsCount { get; set; }
    }

    public class BaseObject
    {
        public int? Id { get; set; }
        public string Title { get; set; }
    }

    public class BaseObjectWithName
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }

    public class BaseObjectCount
    {
        public int? Count { get; set; }
    }

    public class BasePlace
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Created { get; set; }
        public string Icon { get; set; }
        public int? Checkins { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }

    public class BaseRepostsInfo
    {
        public int? Count { get; set; }
        public int? UserReposted { get; set; }
    }

    public class BaseSticker
    {
        public int? Id { get; set; }
        public int? ProductId { get; set; }
        public string Photo64 { get; set; }
        public string Photo128 { get; set; }
        public string Photo256 { get; set; }
        public string Photo352 { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }

    public class BaseUserId
    {
        public int? UserId { get; set; }
    }

    public class BoardTopicPoll
    {
        public int? PollId { get; set; }
        public int? OwnerId { get; set; }
        public int? Created { get; set; }
        public bool? IsClosed { get; set; }
        public string Question { get; set; }
        public string Votes { get; set; }
        public int? AnswerId { get; set; }
        public IEnumerable<PollsAnswer> Answers { get; set; }
    }

    public class BoardTopic
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int? Created { get; set; }
        public int? CreatedBy { get; set; }
        public int? Updated { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsFixed { get; set; }
        public int? Comments { get; set; }
    }

    public class BoardTopicComment
    {
        public int? Id { get; set; }
        public int? FromId { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }
        public IEnumerable<WallCommentAttachment> Attachments { get; set; }
        public int? RealOffset { get; set; }
    }

    public class BaseImage
    {
        public string Url { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }

    public class DatabaseCity : BaseObject
    {
        public string Area { get; set; }
        public string Region { get; set; }
        public bool? Important { get; set; }
    }

    public class DatabaseFaculty
    {
        public int? Id { get; set; }
        public string Title { get; set; }
    }

    public class DatabaseRegion
    {
        public int? Id { get; set; }
        public string Title { get; set; }
    }

    public class DatabaseSchool
    {
        public int? Id { get; set; }
        public string Title { get; set; }
    }

    public class DatabaseStreet
    {
        public int? Id { get; set; }
        public string Title { get; set; }
    }

    public class DatabaseUniversity
    {
        public int? Id { get; set; }
        public string Title { get; set; }
    }

    public class DocsDoc
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public int? Size { get; set; }
        public string Ext { get; set; }
        public string Url { get; set; }
        public DateTime? Date { get; set; }
        public int? Type { get; set; }
        public DocsDocPreview Preview { get; set; }
        public string AccessKey { get; set; }
    }

    public class DocsDocTypes
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int? Count { get; set; }
    }

    public class DocsDocUploadResponse
    {
        public string File { get; set; }
    }

    public class DocsDocPreview
    {
        public DocsDocPreviewPhoto Photo { get; set; }
        public DocsDocPreviewVideo Video { get; set; }
    }

    public class DocsDocPreviewPhoto
    {
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
    }

    public class DocsDocPreviewVideo
    {
        public string Src { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? Filesize { get; set; }
    }

    public class FaveFavesLink
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public string Photo200 { get; set; }
    }

    public class FriendsFriendsList
    {
        public string Name { get; set; }
        public int? Id { get; set; }
    }

    public class FriendsRequests
    {
        public int? UserId { get; set; }
        public string From { get; set; }
        public FriendsRequestsMutual Mutual { get; set; }
    }

    public class FriendsRequestsMutual
    {
        public int? Count { get; set; }
        public IEnumerable<int> Users { get; set; }
    }

    public class FriendsRequestsXtrMessage
    {
        public int? UserId { get; set; }
        public string From { get; set; }
        public FriendsRequestsMutual Mutual { get; set; }
        public string Message { get; set; }
    }

    public class FriendsFriendStatus
    {
        public int? UserId { get; set; }
        public int? FriendStatus { get; set; }
        public string RequestMessage { get; set; }
        public int? ReadState { get; set; }
        public string Sign { get; set; }
    }

    public class FriendsUserXtrLists : UsersUserFull
    {
        public IEnumerable<int> Lists { get; set; }
    }

    public class FriendsUserXtrPhone : UsersUserFull
    {
        public string Phone { get; set; }
    }

    public class GiftsLayout
    {
        public int? Id { get; set; }
        public string Thumb256 { get; set; }
        public string Thumb96 { get; set; }
        public string Thumb48 { get; set; }
    }

    public class GiftsGift
    {
        public int? Id { get; set; }
        public int? FromId { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
        public GiftsLayout Gift { get; set; }
        public int? Privacy { get; set; }
        public string GiftHash { get; set; }
    }

    public class GroupsBanInfo
    {
        public int? AdminId { get; set; }
        public DateTime? Date { get; set; }
        public int? Reason { get; set; }
        public string Comment { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class GroupsGroupsArray
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class GroupsGroupCategory
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<BaseObjectWithName> Subcategories { get; set; }
    }

    public class GroupsGroupCategoryFull
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<GroupsGroupCategory> Subcategories { get; set; }
        public int? PageCount { get; set; }
        public IEnumerable<GroupsGroup> PagePreviews { get; set; }
    }

    public class GroupsContactsItem
    {
        public int? UserId { get; set; }
        public string Desc { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class GroupsCountersGroup
    {
        public int? Photos { get; set; }
        public int? Albums { get; set; }
        public int? Topics { get; set; }
        public int? Videos { get; set; }
        public int? Audios { get; set; }
        public int? Docs { get; set; }
        public int? Market { get; set; }
    }

    public class GroupsCover
    {
        public bool? Enabled { get; set; }
        public IEnumerable<BaseImage> Images { get; set; }
    }

    public class GroupsGroup
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string ScreenName { get; set; }
        public int? IsClosed { get; set; }
        public string Type { get; set; }
        public bool? IsAdmin { get; set; }
        public int? AdminLevel { get; set; }
        public bool? IsMember { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public string Photo200 { get; set; }
    }

    public class GroupsGroupFull : GroupsGroup
    {
        public GroupsMarketInfo Market { get; set; }
        public int? MemberStatus { get; set; }
        public bool? IsFavorite { get; set; }
        public bool? IsSubscribed { get; set; }
        public BaseObject City { get; set; }
        public BaseCountry Country { get; set; }
        public bool? Verified { get; set; }
        public string Description { get; set; }
        public string WikiPage { get; set; }
        public int? MembersCount { get; set; }
        public GroupsCountersGroup Counters { get; set; }
        public GroupsCover Cover { get; set; }
        public bool? CanPost { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public string Activity { get; set; }
        public int? FixedPost { get; set; }
        public bool? CanCreateTopic { get; set; }
        public bool? CanUploadVideo { get; set; }
        public string Status { get; set; }
        public int? MainAlbumId { get; set; }
        public IEnumerable<GroupsLinksItem> Links { get; set; }
        public IEnumerable<GroupsContactsItem> Contacts { get; set; }
        public string Site { get; set; }
        public int? MainSection { get; set; }
        public bool? CanMessage { get; set; }
        public bool? IsMessagesAllowed { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Deactivated { get; set; }
        public int? AgeLimits { get; set; }
    }

    public class GroupsGroupXtrInvitedBy
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ScreenName { get; set; }
        public bool? IsClosed { get; set; }
        public string Type { get; set; }
        public bool? IsAdmin { get; set; }
        public int? AdminLevel { get; set; }
        public bool? IsMember { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public string Photo200 { get; set; }
        public int? InvitedBy { get; set; }
    }

    public class GroupsGroupLink
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public bool? EditTitle { get; set; }
        public string Desc { get; set; }
        public bool? ImageProcessing { get; set; }
    }

    public class GroupsLinksItem
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public int? EditTitle { get; set; }
        public int? Name { get; set; }
        public string Desc { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
    }

    public class GroupsMarketInfo
    {
        public bool? Enabled { get; set; }
        public int? PriceMin { get; set; }
        public int? PriceMax { get; set; }
        public int? MainAlbumId { get; set; }
        public int? ContactId { get; set; }
        public MarketCurrency Currency { get; set; }
        public string CurrencyText { get; set; }
    }

    public class GroupsMemberRole
    {
        public int? Id { get; set; }
        public string Role { get; set; }
    }

    public class GroupsMemberStatus
    {
        public bool? Member { get; set; }
        public int? UserId { get; set; }
    }

    public class GroupsMemberStatusFull
    {
        public bool? Member { get; set; }
        public int? UserId { get; set; }
        public bool? Invitation { get; set; }
        public bool? Request { get; set; }
    }

    public class GroupsGroupSettings
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public PlacesPlaceMin Place { get; set; }
        public int? Wall { get; set; }
        public int? Photos { get; set; }
        public int? Video { get; set; }
        public int? Audio { get; set; }
        public int? Docs { get; set; }
        public int? Topics { get; set; }
        public int? Wiki { get; set; }
        public bool? ObsceneFilter { get; set; }
        public bool? ObsceneStopwords { get; set; }
        public string ObsceneWords { get; set; }
        public int? Access { get; set; }
        public int? Subject { get; set; }
        public IEnumerable<GroupsSubjectItem> SubjectList { get; set; }
        public string Rss { get; set; }
        public string Website { get; set; }
    }

    public class GroupsSubjectItem
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }

    public class GroupsUserXtrBanInfo
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Deactivated { get; set; }
        public int? Hidden { get; set; }
        public int? Sex { get; set; }
        public string ScreenName { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public bool? Online { get; set; }
        public bool? OnlineMobile { get; set; }
        public int? OnlineApp { get; set; }
        public string Nickname { get; set; }
        public string MaidenName { get; set; }
        public string Domain { get; set; }
        public string Bdate { get; set; }
        public BaseObject City { get; set; }
        public BaseObject Country { get; set; }
        public int? Timezone { get; set; }
        public string Photo200 { get; set; }
        public string PhotoMax { get; set; }
        public string Photo200Orig { get; set; }
        public string Photo400Orig { get; set; }
        public string PhotoMaxOrig { get; set; }
        public string PhotoId { get; set; }
        public bool? HasPhoto { get; set; }
        public bool? HasMobile { get; set; }
        public bool? IsFriend { get; set; }
        public int? FriendStatus { get; set; }
        public bool? WallComments { get; set; }
        public bool? CanPost { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public bool? CanSeeAudio { get; set; }
        public bool? CanWritePrivateMessage { get; set; }
        public bool? CanSendFriendRequest { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string Skype { get; set; }
        public string Facebook { get; set; }
        public string FacebookName { get; set; }
        public string Twitter { get; set; }
        public string Livejournal { get; set; }
        public string Instagram { get; set; }
        public string Site { get; set; }
        public AudioAudioFull StatusAudio { get; set; }
        public string Status { get; set; }
        public string Activity { get; set; }
        public UsersLastSeen LastSeen { get; set; }
        public UsersExports Exports { get; set; }
        public UsersCropPhoto CropPhoto { get; set; }
        public bool? Verified { get; set; }
        public int? FollowersCount { get; set; }
        public bool? Blacklisted { get; set; }
        public bool? BlacklistedByMe { get; set; }
        public bool? IsFavorite { get; set; }
        public bool? IsHiddenFromFeed { get; set; }
        public int? CommonCount { get; set; }
        public UsersOccupation Occupation { get; set; }
        public IEnumerable<UsersCareer> Career { get; set; }
        public IEnumerable<UsersMilitary> Military { get; set; }
        public int? University { get; set; }
        public string UniversityName { get; set; }
        public int? Faculty { get; set; }
        public string FacultyName { get; set; }
        public int? Graduation { get; set; }
        public string EducationForm { get; set; }
        public string EducationStatus { get; set; }
        public string HomeTown { get; set; }
        public int? Relation { get; set; }
        public UsersUserMin RelationPartner { get; set; }
        public UsersPersonal Personal { get; set; }
        public string Interests { get; set; }
        public string Music { get; set; }
        public string Activities { get; set; }
        public string Movies { get; set; }
        public string Tv { get; set; }
        public string Books { get; set; }
        public string Games { get; set; }
        public IEnumerable<UsersUniversity> Universities { get; set; }
        public IEnumerable<UsersSchool> Schools { get; set; }
        public string About { get; set; }
        public IEnumerable<UsersRelative> Relatives { get; set; }
        public string Quotes { get; set; }
        public GroupsBanInfo BanInfo { get; set; }
    }

    public class GroupsUserXtrRole : UsersUserFull
    {
        public string Role { get; set; }
    }

    public class LeadsLead
    {
        public int? Limit { get; set; }
        public int? Spent { get; set; }
        public int? Cost { get; set; }
        public int? Impressions { get; set; }
        public int? Started { get; set; }
        public int? Completed { get; set; }
        public LeadsLeadDays Days { get; set; }
    }

    public class LeadsLeadDays
    {
        public int? Impressions { get; set; }
        public int? Started { get; set; }
        public int? Completed { get; set; }
        public int? Spent { get; set; }
    }

    public class LeadsStart
    {
        public bool? TestMode { get; set; }
        public string VkSid { get; set; }
    }

    public class LeadsChecked
    {
        public string Result { get; set; }
        public string Reason { get; set; }
        public string StartLink { get; set; }
        public string Sid { get; set; }
    }

    public class LeadsComplete
    {
        public int? Limit { get; set; }
        public int? Spent { get; set; }
        public int? Cost { get; set; }
        public bool? TestMode { get; set; }
        public bool? Success { get; set; }
    }

    public class LeadsEntry
    {
        public int? Uid { get; set; }
        public int? Aid { get; set; }
        public string Sid { get; set; }
        public DateTime? Date { get; set; }
        public int? Status { get; set; }
        public bool? TestMode { get; set; }
        public DateTime? StartDate { get; set; }
        public string Comment { get; set; }
    }

    public class MarketMarketAlbum
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public int? Count { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public PhotosPhoto Photo { get; set; }
    }

    public class MarketMarketCategory
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public MarketSection Section { get; set; }
    }

    public class MarketCurrency
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }

    public class MarketMarketItem
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public MarketPrice Price { get; set; }
        public MarketMarketCategory Category { get; set; }
        public DateTime? Date { get; set; }
        public string ThumbPhoto { get; set; }
        public int? Availability { get; set; }
    }

    public class MarketMarketItemFull : MarketMarketItem
    {
        public IEnumerable<PhotosPhoto> Photos { get; set; }
        public bool? CanComment { get; set; }
        public bool? CanRepost { get; set; }
        public BaseLikes Likes { get; set; }
        public int? ViewsCount { get; set; }
    }

    public class MarketPrice
    {
        public string Amount { get; set; }
        public MarketCurrency Currency { get; set; }
        public string Text { get; set; }
    }

    public class MarketSection
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }

    public class MessagesAttachmentsHistory
    {
        public string Type { get; set; }
        public PhotosPhoto Photo { get; set; }
        public VideoVideo Video { get; set; }
        public AudioAudioFull Audio { get; set; }
        public DocsDoc Doc { get; set; }
        public BaseLink Link { get; set; }
    }

    public class MessagesMessageAttachment
    {
        public PhotosPhoto Photo { get; set; }
        public AudioAudioFull Audio { get; set; }
        public VideoVideo Video { get; set; }
        public DocsDoc Doc { get; set; }
        public BaseLink Link { get; set; }
        public MarketMarketItem Market { get; set; }
        public MarketMarketAlbum MarketMarketAlbum { get; set; }
        public GiftsLayout Gift { get; set; }
        public BaseSticker Sticker { get; set; }
        public WallWallpostAttached Wall { get; set; }
        public WallWallComment WallReply { get; set; }
        public string Type { get; set; }
    }

    public class MessagesChat
    {
        public int? Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public int? AdminId { get; set; }
        public IEnumerable<int> Users { get; set; }
        public MessagesChatPushSettings PushSettings { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public string Photo200 { get; set; }
        public bool? Left { get; set; }
        public bool? Kicked { get; set; }
    }

    public class MessagesChatFull
    {
        public int? Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public int? AdminId { get; set; }
        public IEnumerable<MessagesUserXtrInvitedBy> Users { get; set; }
        public MessagesChatPushSettings PushSettings { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public string Photo200 { get; set; }
        public bool? Left { get; set; }
        public bool? Kicked { get; set; }
    }

    public class MessagesChatPushSettings
    {
        public bool? Sound { get; set; }
        public int? DisabledUntil { get; set; }
    }

    public class MessagesDialog
    {
        public int? Unread { get; set; }
        public MessagesMessage Message { get; set; }
        public int? InRead { get; set; }
        public int? OutRead { get; set; }
    }

    public class MessagesLastActivity
    {
        public bool? Online { get; set; }
        public DateTime? Time { get; set; }
    }

    public class MessagesLongpollParams
    {
        public string Key { get; set; }
        public string Server { get; set; }
        public int? Ts { get; set; }
        public int? Pts { get; set; }
    }

    public class MessagesLongpollMessages
    {
        public int? Count { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
    }

    public class MessagesMessage
    {
        public int? Id { get; set; }
        public DateTime? Date { get; set; }
        public bool? Out { get; set; }
        public int? UserId { get; set; }
        public int? FromId { get; set; }
        public int? RandomId { get; set; }
        public bool? Important { get; set; }
        public bool? Deleted { get; set; }
        public IEnumerable<MessagesMessage> FwdMessages { get; set; }
        public bool? ReadState { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public IEnumerable<MessagesMessageAttachment> Attachments { get; set; }
        public int? ChatId { get; set; }
        public IEnumerable<int> ChatActive { get; set; }
        public int? UsersCount { get; set; }
        public int? AdminId { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public string Photo200 { get; set; }
        public BaseGeo Geo { get; set; }
    }

    public class MessagesUserXtrInvitedBy : UsersUserXtrType
    {
        public int? InvitedBy { get; set; }
    }

    public class NewsfeedNewsfeedItem
    {
        public string Type { get; set; }
        public int? SourceId { get; set; }
        public DateTime? Date { get; set; }
    }

    public class NewsfeedItemAudio
    {
        public NewsfeedItemAudioAudio Audio { get; set; }
        public int? PostId { get; set; }
    }

    public class NewsfeedItemAudioAudio
    {
        public int? Count { get; set; }
        public IEnumerable<AudioAudioFull> Items { get; set; }
    }

    public class NewsfeedItemFriend
    {
        public object Friends { get; set; }
    }

    public class NewsfeedItemNote
    {
        public NewsfeedItemNoteNotes Notes { get; set; }
    }

    public class NewsfeedItemNoteNotes
    {
        public int? Count { get; set; }
        public IEnumerable<NewsfeedNewsfeedNote> Items { get; set; }
    }

    public class NewsfeedItemPhoto
    {
        public NewsfeedItemPhotoPhotos Photos { get; set; }
        public int? PostId { get; set; }
    }

    public class NewsfeedItemPhotoPhotos
    {
        public int? Count { get; set; }
        public IEnumerable<NewsfeedNewsfeedPhoto> Items { get; set; }
    }

    public class NewsfeedItemPhotoTag
    {
        public NewsfeedItemPhotoTagPhotoTags PhotoTags { get; set; }
        public int? PostId { get; set; }
    }

    public class NewsfeedItemPhotoTagPhotoTags
    {
        public int? Count { get; set; }
        public IEnumerable<NewsfeedNewsfeedPhoto> Items { get; set; }
    }

    public class NewsfeedItemTopic
    {
        public int? PostId { get; set; }
        public string Text { get; set; }
        public BaseCommentsInfo Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
    }

    public class NewsfeedItemVideo
    {
        public NewsfeedItemVideoVideo Video { get; set; }
    }

    public class NewsfeedItemVideoVideo
    {
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class NewsfeedItemWallpost
    {
        public int? PostId { get; set; }
        public string PostType { get; set; }
        public string Text { get; set; }
        public IEnumerable<WallWallpost> CopyHistory { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
        public WallPostSource PostSource { get; set; }
        public BaseCommentsInfo Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
    }

    public class NewsfeedList
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public bool? NoReposts { get; set; }
        public IEnumerable<int> SourceIds { get; set; }
    }

    public class NewsfeedNewsfeedNote
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public int? Comments { get; set; }
    }

    public class NewsfeedNewsfeedPhoto : PhotosPhoto
    {
        public BaseLikes Likes { get; set; }
        public BaseObjectCount Comments { get; set; }
        public bool? CanComment { get; set; }
        public bool? CanRepost { get; set; }
    }

    public class NotesNoteComment
    {
        public int? Id { get; set; }
        public int? Uid { get; set; }
        public int? Nid { get; set; }
        public int? Oid { get; set; }
        public DateTime? Date { get; set; }
        public string Message { get; set; }
        public int? ReplyTo { get; set; }
    }

    public class NotesNote
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public int? Comments { get; set; }
        public bool? CanComment { get; set; }
        public DateTime? Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string TextWiki { get; set; }
        public string ViewUrl { get; set; }
    }

    public class NotificationsNotificationsComment
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }
        public PhotosPhoto Photo { get; set; }
        public VideoVideo Video { get; set; }
        public WallWallpost Post { get; set; }
        public BoardTopic Topic { get; set; }
    }

    public class NotificationsNotification
    {
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public string Parent { get; set; }
        public NotificationsFeedback Feedback { get; set; }
        public NotificationsReply Reply { get; set; }
    }

    public class NotificationsFeedback
    {
        public int? Id { get; set; }
        public int? ToId { get; set; }
        public int? FromId { get; set; }
        public string Text { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
    }

    public class NotificationsReply
    {
        public int? Id { get; set; }
        public DateTime? Date { get; set; }
        public int? Text { get; set; }
    }

    public class OauthError
    {
        public string Error { get; set; }
        public string ErrorDescription { get; set; }
        public string RedirectUri { get; set; }
    }

    public class OrdersOrder
    {
        public int? Id { get; set; }
        public int? AppOrderId { get; set; }
        public string Status { get; set; }
        public int? UserId { get; set; }
        public int? ReceiverId { get; set; }
        public string Item { get; set; }
        public int? Amount { get; set; }
        public DateTime? Date { get; set; }
        public int? TransactionId { get; set; }
        public int? CancelTransactionId { get; set; }
    }

    public class OrdersAmount
    {
        public IEnumerable<OrdersAmountItem> Amounts { get; set; }
        public string Currency { get; set; }
    }

    public class OrdersAmountItem
    {
        public string Votes { get; set; }
        public int? Amount { get; set; }
        public string Description { get; set; }
    }

    public class PagesWikipage
    {
        public int? Id { get; set; }
        public int? GroupId { get; set; }
        public string Title { get; set; }
        public int? WhoCanView { get; set; }
        public int? WhoCanEdit { get; set; }
        public int? Views { get; set; }
        public int? EditorId { get; set; }
        public string EditorName { get; set; }
        public int? CreatorId { get; set; }
        public int? CreatorName { get; set; }
    }

    public class PagesWikipageFull
    {
        public int? Id { get; set; }
        public int? GroupId { get; set; }
        public string Title { get; set; }
        public bool? CurrentUserCanEdit { get; set; }
        public bool? CurrentUserCanEditAccess { get; set; }
        public int? WhoCanView { get; set; }
        public int? WhoCanEdit { get; set; }
        public int? Edited { get; set; }
        public int? Created { get; set; }
        public int? Views { get; set; }
        public int? EditorId { get; set; }
        public int? CreatorId { get; set; }
        public string Source { get; set; }
        public string Html { get; set; }
        public string ViewUrl { get; set; }
    }

    public class PagesWikipageVersion
    {
        public int? Id { get; set; }
        public int? Length { get; set; }
        public int? Edited { get; set; }
        public int? EditorId { get; set; }
        public string EditorName { get; set; }
    }

    public class PhotosPhotoAlbum
    {
        public int? Id { get; set; }
        public PhotosPhoto Thumb { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Created { get; set; }
        public int? Updated { get; set; }
        public int? Size { get; set; }
    }

    public class PhotosPhotoAlbumFull
    {
        public int? Id { get; set; }
        public int? ThumbId { get; set; }
        public string ThumbSrc { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Created { get; set; }
        public int? Updated { get; set; }
        public int? Size { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
        public bool? UploadByAdminsOnly { get; set; }
        public bool? CommentsDisabled { get; set; }
        public bool? CanUpload { get; set; }
        public bool? ThumbIsLast { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
    }

    public class PhotosCommentXtrPid
    {
        public int? Id { get; set; }
        public int? FromId { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public int? ReplyToUser { get; set; }
        public int? ReplyToComment { get; set; }
        public IEnumerable<WallCommentAttachment> Attachments { get; set; }
        public int? Pid { get; set; }
    }

    public class PhotosMarketAlbumUploadResponse
    {
        public int? Gid { get; set; }
        public int? Server { get; set; }
        public string Photo { get; set; }
        public string Hash { get; set; }
    }

    public class PhotosMarketUploadResponse
    {
        public int? GroupId { get; set; }
        public int? Server { get; set; }
        public string Photo { get; set; }
        public string Hash { get; set; }
        public string CropData { get; set; }
        public string CropHash { get; set; }
    }

    public class PhotosMessageUploadResponse
    {
        public int? Server { get; set; }
        public string Photo { get; set; }
        public string Hash { get; set; }
    }

    public class PhotosOwnerUploadResponse
    {
        public int? Server { get; set; }
        public string Photo { get; set; }
        public string Hash { get; set; }
    }

    public class PhotosPhoto
    {
        public int? Id { get; set; }
        public int? AlbumId { get; set; }
        public int? OwnerId { get; set; }
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        public string Photo75 { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
        public string Photo807 { get; set; }
        public string Photo1280 { get; set; }
        public string Photo2560 { get; set; }
        public int? PostId { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Text { get; set; }
        public DateTime? Date { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public string AccessKey { get; set; }
    }

    public class PhotosPhotoFull
    {
        public int? Id { get; set; }
        public int? AlbumId { get; set; }
        public int? OwnerId { get; set; }
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        public string Photo75 { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
        public string Photo807 { get; set; }
        public string Photo1280 { get; set; }
        public string Photo2560 { get; set; }
        public int? PostId { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Text { get; set; }
        public DateTime? Date { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public string AccessKey { get; set; }
        public BaseLikes Likes { get; set; }
        public BaseObjectCount Reposts { get; set; }
        public BaseObjectCount Comments { get; set; }
        public bool? CanComment { get; set; }
        public BaseObjectCount Tags { get; set; }
    }

    public class PhotosPhotoFullXtrRealOffset
    {
        public int? Id { get; set; }
        public int? AlbumId { get; set; }
        public int? OwnerId { get; set; }
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        public string Photo75 { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
        public string Photo807 { get; set; }
        public string Photo1280 { get; set; }
        public string Photo2560 { get; set; }
        public int? PostId { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Text { get; set; }
        public DateTime? Date { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public string AccessKey { get; set; }
        public BaseLikes Likes { get; set; }
        public BaseObjectCount Reposts { get; set; }
        public BaseObjectCount Comments { get; set; }
        public bool? CanComment { get; set; }
        public BaseObjectCount Tags { get; set; }
        public bool? Hidden { get; set; }
        public int? RealOffset { get; set; }
    }

    public class PhotosPhotoXtrRealOffset
    {
        public int? Id { get; set; }
        public int? AlbumId { get; set; }
        public int? OwnerId { get; set; }
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        public string Photo75 { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
        public string Photo807 { get; set; }
        public string Photo1280 { get; set; }
        public string Photo2560 { get; set; }
        public int? PostId { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Text { get; set; }
        public DateTime? Date { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public string AccessKey { get; set; }
        public bool? Hidden { get; set; }
        public int? RealOffset { get; set; }
    }

    public class PhotosPhotoXtrTagInfo
    {
        public int? Id { get; set; }
        public int? AlbumId { get; set; }
        public int? OwnerId { get; set; }
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        public string Photo75 { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
        public string Photo807 { get; set; }
        public string Photo1280 { get; set; }
        public string Photo2560 { get; set; }
        public int? PostId { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Text { get; set; }
        public DateTime? Date { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public string AccessKey { get; set; }
        public int? PlacerId { get; set; }
        public int? TagCreated { get; set; }
        public int? TagId { get; set; }
    }

    public class PhotosPhotoSizes
    {
        public string Src { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Type { get; set; }
    }

    public class PhotosPhotoTag
    {
        public int? UserId { get; set; }
        public int? Id { get; set; }
        public int? PlacerId { get; set; }
        public string TaggedName { get; set; }
        public DateTime? Date { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? X2 { get; set; }
        public double? Y2 { get; set; }
        public bool? Viewed { get; set; }
    }

    public class PhotosPhotoUpload
    {
        public string UploadUrl { get; set; }
        public int? AlbumId { get; set; }
        public int? UserId { get; set; }
    }

    public class PhotosPhotoUploadResponse
    {
        public int? Server { get; set; }
        public string PhotosList { get; set; }
        public int? Aid { get; set; }
        public string Hash { get; set; }
    }

    public class PhotosWallUploadResponse
    {
        public int? Server { get; set; }
        public string Photo { get; set; }
        public string Hash { get; set; }
    }

    public class PlacesCheckin
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? PlaceId { get; set; }
        public string Text { get; set; }
        public int? Distance { get; set; }
        public string PlaceTitle { get; set; }
        public int? PlaceCountry { get; set; }
        public int? PlaceCity { get; set; }
        public string PlaceType { get; set; }
        public string PlaceIcon { get; set; }
    }

    public class PlacesPlaceMin
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Created { get; set; }
        public string Icon { get; set; }
        public int? Checkins { get; set; }
        public string Type { get; set; }
        public int? Country { get; set; }
        public int? City { get; set; }
        public string Address { get; set; }
    }

    public class PlacesPlaceFull
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Created { get; set; }
        public string Icon { get; set; }
        public int? Checkins { get; set; }
        public string Type { get; set; }
        public int? Country { get; set; }
        public int? City { get; set; }
        public string Address { get; set; }
        public int? Distance { get; set; }
        public int? GroupId { get; set; }
        public string GroupPhoto { get; set; }
    }

    public class PlacesTypes
    {
        public int? Id { get; set; }
        public int? Title { get; set; }
        public string Icon { get; set; }
    }

    public class PollsAnswer
    {
        public int? Id { get; set; }
        public string Text { get; set; }
        public int? Votes { get; set; }
        public double? Rate { get; set; }
    }

    public class PollsPoll
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public int? Created { get; set; }
        public string Question { get; set; }
        public string Votes { get; set; }
        public int? AnswerId { get; set; }
        public IEnumerable<PollsAnswer> Answers { get; set; }
        public bool? Anonymous { get; set; }
    }

    public class PollsVoters
    {
        public int? AnswerId { get; set; }
        public PollsVotersUsers Users { get; set; }
    }

    public class PollsVotersUsers
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class SearchHint
    {
        public string Type { get; set; }
        public string Section { get; set; }
        public string Description { get; set; }
        public bool? Global { get; set; }
        public GroupsGroup Group { get; set; }
        public UsersUserMin Profile { get; set; }
    }

    public class SecureLevel
    {
        public int? Uid { get; set; }
        public int? Level { get; set; }
    }

    public class SecureSmsNotification
    {
        public int? Id { get; set; }
        public int? AppId { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
        public string Message { get; set; }
    }

    public class SecureTokenChecked
    {
        public bool? Success { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
        public int? Expire { get; set; }
    }

    public class SecureTransaction
    {
        public int? Id { get; set; }
        public int? UidFrom { get; set; }
        public int? UidTo { get; set; }
        public int? Votes { get; set; }
        public DateTime? Date { get; set; }
    }

    public class StatsPeriod
    {
        public string Day { get; set; }
        public int? Views { get; set; }
        public int? Visitors { get; set; }
        public int? Reach { get; set; }
        public int? ReachSubscribers { get; set; }
        public int? Subscribed { get; set; }
        public int? Unsubscribed { get; set; }
        public IEnumerable<StatsSex> Sex { get; set; }
        public IEnumerable<StatsAge> Age { get; set; }
        public IEnumerable<StatsSexAge> SexAge { get; set; }
        public IEnumerable<StatsCity> Cities { get; set; }
        public IEnumerable<StatsCountry> Countries { get; set; }
    }

    public class StatsAge
    {
        public int? Visitors { get; set; }
        public string Value { get; set; }
    }

    public class StatsCountry
    {
        public int? Visitors { get; set; }
        public int? Value { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class StatsCity
    {
        public int? Visitors { get; set; }
        public int? Value { get; set; }
        public string Name { get; set; }
    }

    public class StatsSex
    {
        public int? Visitors { get; set; }
        public string Value { get; set; }
    }

    public class StatsSexAge
    {
        public int? Visitors { get; set; }
        public string Value { get; set; }
    }

    public class StatsWallpostStat
    {
        public int? ReachSubscribers { get; set; }
        public int? ReachTotal { get; set; }
        public int? Links { get; set; }
        public int? ToGroup { get; set; }
        public int? JoinGroup { get; set; }
        public int? Report { get; set; }
        public int? Hide { get; set; }
        public int? Unsubscribe { get; set; }
    }

    public class StatusStatus
    {
        public string Text { get; set; }
        public AudioAudioFull Audio { get; set; }
    }

    public class UtilsDomainResolved
    {
        public string Type { get; set; }
        public int? ObjectId { get; set; }
    }

    public class UtilsLinkChecked
    {
        public string Status { get; set; }
        public string Link { get; set; }
    }

    public class UsersUsersArray
    {
        public int? Count { get; set; }
        public IEnumerable<int> Items { get; set; }
    }

    public class UsersUserCounters
    {
        public int? Albums { get; set; }
        public int? Videos { get; set; }
        public int? Audios { get; set; }
        public int? Notes { get; set; }
        public int? Photos { get; set; }
        public int? Groups { get; set; }
        public int? Gifts { get; set; }
        public int? Friends { get; set; }
        public int? OnlineFriends { get; set; }
        public int? UserPhotos { get; set; }
        public int? UserVideos { get; set; }
        public int? Followers { get; set; }
        public int? Subscriptions { get; set; }
        public int? Pages { get; set; }
    }

    public class UsersUser : UsersUserMin
    {
        public int? Sex { get; set; }
        public string ScreenName { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public bool? Online { get; set; }
        public bool? OnlineMobile { get; set; }
        public int? OnlineApp { get; set; }
    }

    public class UsersUserFullXtrType : UsersUserFull
    {
        public string Type { get; set; }
    }

    public class UsersUserXtrType : UsersUser
    {
        public string Type { get; set; }
    }

    public class UsersUserMin
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Deactivated { get; set; }
        public int? Hidden { get; set; }
    }

    public class UsersUserBroadcast : UsersUserMin
    {
        public AudioAudioFull StatusAudio { get; set; }
    }

    public class UsersUserFull : UsersUser
    {
        public string Nickname { get; set; }
        public string MaidenName { get; set; }
        public string Domain { get; set; }
        public string Bdate { get; set; }
        public BaseObject City { get; set; }
        public BaseCountry Country { get; set; }
        public int? Timezone { get; set; }
        public string Photo200 { get; set; }
        public string PhotoMax { get; set; }
        public string Photo200Orig { get; set; }
        public string Photo400Orig { get; set; }
        public string PhotoMaxOrig { get; set; }
        public string PhotoId { get; set; }
        public int? HasPhoto { get; set; }
        public bool? HasMobile { get; set; }
        public bool? IsFriend { get; set; }
        public int? FriendStatus { get; set; }
        public bool? WallComments { get; set; }
        public bool? CanPost { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public bool? CanSeeAudio { get; set; }
        public bool? CanWritePrivateMessage { get; set; }
        public bool? CanSendFriendRequest { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string Skype { get; set; }
        public string Facebook { get; set; }
        public string FacebookName { get; set; }
        public string Twitter { get; set; }
        public string Livejournal { get; set; }
        public string Instagram { get; set; }
        public string Site { get; set; }
        public AudioAudioFull StatusAudio { get; set; }
        public string Status { get; set; }
        public string Activity { get; set; }
        public UsersLastSeen LastSeen { get; set; }
        public UsersExports Exports { get; set; }
        public UsersCropPhoto CropPhoto { get; set; }
        public bool? Verified { get; set; }
        public int? FollowersCount { get; set; }
        public bool? Blacklisted { get; set; }
        public bool? BlacklistedByMe { get; set; }
        public bool? IsFavorite { get; set; }
        public bool? IsHiddenFromFeed { get; set; }
        public int? CommonCount { get; set; }
        public UsersOccupation Occupation { get; set; }
        public IEnumerable<UsersCareer> Career { get; set; }
        public IEnumerable<UsersMilitary> Military { get; set; }
        public int? University { get; set; }
        public string UniversityName { get; set; }
        public int? Faculty { get; set; }
        public string FacultyName { get; set; }
        public int? Graduation { get; set; }
        public string EducationForm { get; set; }
        public string EducationStatus { get; set; }
        public string HomeTown { get; set; }
        public int? Relation { get; set; }
        public UsersUserMin RelationPartner { get; set; }
        public UsersPersonal Personal { get; set; }
        public string Interests { get; set; }
        public string Music { get; set; }
        public string Activities { get; set; }
        public string Movies { get; set; }
        public string Tv { get; set; }
        public string Books { get; set; }
        public string Games { get; set; }
        public IEnumerable<UsersUniversity> Universities { get; set; }
        public IEnumerable<UsersSchool> Schools { get; set; }
        public string About { get; set; }
        public IEnumerable<UsersRelative> Relatives { get; set; }
        public string Quotes { get; set; }
    }

    public class UsersCareer
    {
        public int? GroupId { get; set; }
        public string Company { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? From { get; set; }
        public int? Until { get; set; }
        public string Position { get; set; }
    }

    public class UsersExports
    {
        public int? Twitter { get; set; }
        public int? Facebook { get; set; }
        public int? Livejournal { get; set; }
    }

    public class UsersMilitary
    {
        public string Unit { get; set; }
        public int? UnitId { get; set; }
        public int? CountryId { get; set; }
        public int? From { get; set; }
        public int? Until { get; set; }
    }

    public class UsersRelative
    {
        public int? Id { get; set; }
        public string Type { get; set; }
    }

    public class UsersUserLim
    {
        public int? Id { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public string NameGen { get; set; }
    }

    public class UsersLastSeen
    {
        public DateTime? Time { get; set; }
        public int? Platform { get; set; }
    }

    public class UsersUniversity
    {
        public int? Id { get; set; }
        public int? Country { get; set; }
        public int? City { get; set; }
        public string Name { get; set; }
        public int? Faculty { get; set; }
        public string FacultyName { get; set; }
        public int? Chair { get; set; }
        public string ChairName { get; set; }
        public int? Graduation { get; set; }
        public string EducationForm { get; set; }
        public string EducationStatus { get; set; }
    }

    public class UsersSchool
    {
        public string Id { get; set; }
        public int? Country { get; set; }
        public int? City { get; set; }
        public string Name { get; set; }
        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }
        public int? YearGraduated { get; set; }
        public string Class { get; set; }
        public int? Type { get; set; }
        public string TypeStr { get; set; }
    }

    public class UsersCropPhoto
    {
        public PhotosPhoto Photo { get; set; }
        public UsersCropPhotoCrop Crop { get; set; }
        public UsersCropPhotoRect Rect { get; set; }
    }

    public class UsersCropPhotoCrop
    {
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? X2 { get; set; }
        public double? Y2 { get; set; }
    }

    public class UsersCropPhotoRect
    {
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? X2 { get; set; }
        public double? Y2 { get; set; }
    }

    public class UsersOccupation
    {
        public string Type { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
    }

    public class UsersPersonal
    {
        public int? Political { get; set; }
        public IEnumerable<string> Langs { get; set; }
        public string Religion { get; set; }
        public string InspiredBy { get; set; }
        public int? PeopleMain { get; set; }
        public int? LifeMain { get; set; }
        public int? Smoking { get; set; }
        public int? Alcohol { get; set; }
    }

    public class UsersUserXtrCounters : UsersUserFull
    {
        public UsersUserCounters Counters { get; set; }
    }

    public class VideoVideoAlbum
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
    }

    public class VideoVideoAlbumFull
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public int? Count { get; set; }
        public string Photo160 { get; set; }
        public string Photo320 { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public int? IsSystem { get; set; }
    }

    public class VideoCatBlock
    {
        public IEnumerable<VideoCatElement> Items { get; set; }
        public string Next { get; set; }
        public string Name { get; set; }
        public int? Id { get; set; }
        public string View { get; set; }
        public bool? CanHide { get; set; }
        public string Type { get; set; }
    }

    public class VideoCatElement
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int? Duration { get; set; }
        public string Photo130 { get; set; }
        public string Photo160 { get; set; }
        public string Photo320 { get; set; }
        public string Photo640 { get; set; }
        public string Photo800 { get; set; }
        public DateTime? Date { get; set; }
        public int? Views { get; set; }
        public int? Comments { get; set; }
        public int? CanAdd { get; set; }
        public int? CanEdit { get; set; }
        public int? IsPrivate { get; set; }
        public int? Count { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }

    public class VideoSaveResult
    {
        public string UploadUrl { get; set; }
        public int? VideoId { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class VideoVideoTag
    {
        public int? UserId { get; set; }
        public int? Id { get; set; }
        public int? PlacerId { get; set; }
        public string TaggedName { get; set; }
        public DateTime? Date { get; set; }
        public bool? Viewed { get; set; }
    }

    public class VideoUploadResponse
    {
        public int? Size { get; set; }
        public int? VideoId { get; set; }
    }

    public class VideoVideo
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public int? Duration { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public int? Views { get; set; }
        public int? Comments { get; set; }
        public string Photo130 { get; set; }
        public string Photo320 { get; set; }
        public string Photo800 { get; set; }
        public string AccessKey { get; set; }
        public DateTime? AddingDate { get; set; }
        public string Player { get; set; }
        public bool? CanEdit { get; set; }
        public bool? CanAdd { get; set; }
        public bool? Processing { get; set; }
        public bool? Live { get; set; }
        public VideoVideoFiles Files { get; set; }
    }

    public class VideoVideoFiles
    {
        public string Mp240 { get; set; }
        public string Mp360 { get; set; }
        public string Mp480 { get; set; }
        public string Mp720 { get; set; }
        public string Mp1080 { get; set; }
        public string External { get; set; }
    }

    public class VideoVideoTagInfo
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public int? Duration { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public int? Views { get; set; }
        public int? Comments { get; set; }
        public string Photo130 { get; set; }
        public string Photo320 { get; set; }
        public string Photo800 { get; set; }
        public string AccessKey { get; set; }
        public DateTime? AddingDate { get; set; }
        public string Player { get; set; }
        public bool? CanEdit { get; set; }
        public bool? CanAdd { get; set; }
        public bool? Processing { get; set; }
        public bool? Live { get; set; }
        public VideoVideoFiles Files { get; set; }
        public int? PlacerId { get; set; }
        public int? TagCreated { get; set; }
        public int? TagId { get; set; }
    }

    public class VideoVideoFull
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public int? Duration { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public int? Views { get; set; }
        public int? Comments { get; set; }
        public string Photo130 { get; set; }
        public string Photo320 { get; set; }
        public string Photo800 { get; set; }
        public string AccessKey { get; set; }
        public DateTime? AddingDate { get; set; }
        public string Player { get; set; }
        public bool? CanEdit { get; set; }
        public bool? CanAdd { get; set; }
        public bool? Processing { get; set; }
        public bool? Live { get; set; }
        public VideoVideoFiles Files { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
        public bool? CanComment { get; set; }
        public bool? CanRepost { get; set; }
        public BaseLikes Likes { get; set; }
        public bool? Repeat { get; set; }
    }

    public class WallAppPost
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
    }

    public class WallAttachedNote
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public int? Comments { get; set; }
        public int? ReadComments { get; set; }
        public DateTime? Date { get; set; }
        public string Title { get; set; }
        public string ViewUrl { get; set; }
    }

    public class WallCommentAttachment
    {
        public PhotosPhoto Photo { get; set; }
        public AudioAudioFull Audio { get; set; }
        public VideoVideo Video { get; set; }
        public DocsDoc Doc { get; set; }
        public BaseLink Link { get; set; }
        public WallAttachedNote Note { get; set; }
        public PagesWikipageFull Page { get; set; }
        public MarketMarketAlbum MarketMarketAlbum { get; set; }
        public MarketMarketItem Market { get; set; }
        public BaseSticker Sticker { get; set; }
        public string Type { get; set; }
    }

    public class WallGraffiti
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Photo200 { get; set; }
        public string Photo586 { get; set; }
    }

    public class WallPostSource
    {
        public string Type { get; set; }
        public string Platform { get; set; }
        public string Data { get; set; }
        public string Url { get; set; }
    }

    public class WallPostedPhoto
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string Photo130 { get; set; }
        public string Photo604 { get; set; }
    }

    public class WallWallComment
    {
        public int? Id { get; set; }
        public int? FromId { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public int? ReplyToUser { get; set; }
        public int? ReplyToComment { get; set; }
        public IEnumerable<WallCommentAttachment> Attachments { get; set; }
        public int? RealOffset { get; set; }
    }

    public class WallWallpost
    {
        public int? Id { get; set; }
        public int? FromId { get; set; }
        public int? OwnerId { get; set; }
        public DateTime? Date { get; set; }
        public string PostType { get; set; }
        public string Text { get; set; }
        public int? SignerId { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
        public WallPostSource PostSource { get; set; }
    }

    public class WallWallpostAttached
    {
        public int? Id { get; set; }
        public int? FromId { get; set; }
        public int? ToId { get; set; }
        public DateTime? Date { get; set; }
        public string PostType { get; set; }
        public string Text { get; set; }
        public int? CanDelete { get; set; }
        public int? SignerId { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
        public WallPostSource PostSource { get; set; }
        public BaseCommentsInfo Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
        public int? CopyOwnerId { get; set; }
        public int? CopyPostId { get; set; }
        public string CopyText { get; set; }
    }

    public class WallWallpostAttachment
    {
        public PhotosPhoto Photo { get; set; }
        public WallPostedPhoto PostedPhoto { get; set; }
        public AudioAudioFull Audio { get; set; }
        public VideoVideo Video { get; set; }
        public DocsDoc Doc { get; set; }
        public BaseLink Link { get; set; }
        public WallGraffiti Graffiti { get; set; }
        public WallAttachedNote Note { get; set; }
        public WallAppPost App { get; set; }
        public PollsPoll Poll { get; set; }
        public PagesWikipageFull Page { get; set; }
        public PhotosPhotoAlbum Album { get; set; }
        public IEnumerable<string> PhotosList { get; set; }
        public MarketMarketAlbum MarketMarketAlbum { get; set; }
        public MarketMarketItem Market { get; set; }
        public string Type { get; set; }
    }

    public class WallWallpostToId
    {
        public int? Id { get; set; }
        public int? FromId { get; set; }
        public int? ToId { get; set; }
        public DateTime? Date { get; set; }
        public int? PostId { get; set; }
        public string PostType { get; set; }
        public string Text { get; set; }
        public int? SignerId { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
        public WallPostSource PostSource { get; set; }
        public BaseCommentsInfo Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
        public int? CopyOwnerId { get; set; }
        public int? CopyPostId { get; set; }
    }

    public class WallWallpostFull : WallWallpost
    {
        public IEnumerable<WallWallpost> CopyHistory { get; set; }
        public int? CanEdit { get; set; }
        public int? CreatedBy { get; set; }
        public int? CanDelete { get; set; }
        public int? CanPin { get; set; }
        public int? IsPinned { get; set; }
        public BaseCommentsInfo Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
    }

    public class WidgetsWidgetComment
    {
        public int? Id { get; set; }
        public int? FromId { get; set; }
        public int? ToId { get; set; }
        public DateTime? Date { get; set; }
        public UsersUserFull User { get; set; }
        public int? PostType { get; set; }
        public string Text { get; set; }
        public int? CanDelete { get; set; }
        public WidgetsCommentMedia Media { get; set; }
        public IEnumerable<WallCommentAttachment> Attachments { get; set; }
        public WallPostSource PostSource { get; set; }
        public WidgetsCommentReplies Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
    }

    public class WidgetsCommentMedia
    {
        public string Type { get; set; }
        public int? OwnerId { get; set; }
        public int? ItemId { get; set; }
        public string ThumbSrc { get; set; }
    }

    public class WidgetsCommentReplies
    {
        public int? Count { get; set; }
        public int? CanPost { get; set; }
        public IEnumerable<WidgetsCommentRepliesItem> Replies { get; set; }
    }

    public class WidgetsCommentRepliesItem
    {
        public int? Cid { get; set; }
        public int? Uid { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }
        public WidgetsWidgetLikes Likes { get; set; }
        public UsersUserFull User { get; set; }
    }

    public class WidgetsWidgetLikes
    {
        public int? Count { get; set; }
    }

    public class WidgetsWidgetPage
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Url { get; set; }
        public BaseObjectCount Likes { get; set; }
        public BaseObjectCount Comments { get; set; }
        public DateTime? Date { get; set; }
        public string PageId { get; set; }
    }
}