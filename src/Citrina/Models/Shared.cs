using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountAccountCounters
    {
        /// <summary>
        /// New friends requests number
        /// </summary>
        public int? Friends { get; set; }
        /// <summary>
        /// New messages number
        /// </summary>
        public int? Messages { get; set; }
        /// <summary>
        /// New photo tags number
        /// </summary>
        public int? Photos { get; set; }
        /// <summary>
        /// New video tags number
        /// </summary>
        public int? Videos { get; set; }
        /// <summary>
        /// New gifts number
        /// </summary>
        public int? Gifts { get; set; }
        /// <summary>
        /// New events number
        /// </summary>
        public int? Events { get; set; }
        /// <summary>
        /// New groups number
        /// </summary>
        public int? Groups { get; set; }
        /// <summary>
        /// New notifications number
        /// </summary>
        public int? Notifications { get; set; }
        /// <summary>
        /// New app requests number
        /// </summary>
        public int? AppRequests { get; set; }
        /// <summary>
        /// New friends suggestions number
        /// </summary>
        public int? FriendsSuggestions { get; set; }
    }

    public class AccountInfo
    {
        /// <summary>
        /// Country code
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Information whether HTTPS-only is enabled
        /// </summary>
        public bool? HttpsRequired { get; set; }
        /// <summary>
        /// Information whether only owners posts should be shown
        /// </summary>
        public bool? OwnPostsDefault { get; set; }
        /// <summary>
        /// Information whether wall comments should be hidden
        /// </summary>
        public bool? NoWallReplies { get; set; }
        /// <summary>
        /// Information whether user has been processed intro 
        /// </summary>
        public bool? Intro { get; set; }
        /// <summary>
        /// Language ID
        /// </summary>
        public int? Lang { get; set; }
        /// <summary>
        /// Two factor authentication is enabled
        /// </summary>
        [JsonProperty("2fa_required")]
        public bool? _2faRequired { get; set; }
    }

    public class AccountLookupResult
    {
        public IEnumerable<AccountUserXtrContact> Found { get; set; }
        public IEnumerable<AccountOtherContact> Other { get; set; }
    }

    public class AccountNameRequest
    {
        /// <summary>
        /// Request ID needed to cancel the request
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Request status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// First name in request
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name in request
        /// </summary>
        public string LastName { get; set; }
    }

    public class AccountOffer
    {
        /// <summary>
        /// Offer ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Offer title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Instruction how to process the offer
        /// </summary>
        public string Instruction { get; set; }
        /// <summary>
        /// Instruction how to process the offer (HTML format)
        /// </summary>
        public string InstructionHtml { get; set; }
        /// <summary>
        /// Offer short description
        /// </summary>
        public string ShortDescription { get; set; }
        /// <summary>
        /// Offer description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// URL of the preview image
        /// </summary>
        public string Img { get; set; }
        /// <summary>
        /// Offer tag
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// Offer price
        /// </summary>
        public int? Price { get; set; }
    }

    public class AccountOtherContact
    {
        /// <summary>
        /// Contact
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// Mutual friends count
        /// </summary>
        public int? CommonCount { get; set; }
    }

    public class AccountPushConversations
    {
        /// <summary>
        /// Items count
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<AccountPushConversationsItem> Items { get; set; }
    }

    public class AccountPushConversationsItem
    {
        /// <summary>
        /// Peer ID
        /// </summary>
        public int? PeerId { get; set; }
        /// <summary>
        /// Information whether the sound are enabled
        /// </summary>
        public bool? Sound { get; set; }
        /// <summary>
        /// Time until that notifications are disabled in seconds
        /// </summary>
        public DateTime? DisabledUntil { get; set; }
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
        /// <summary>
        /// Information whether notifications are disabled
        /// </summary>
        public bool? Disabled { get; set; }
        /// <summary>
        /// Time until that notifications are disabled in Unixtime
        /// </summary>
        public DateTime? DisabledUntil { get; set; }
        public AccountPushConversations Conversations { get; set; }
        public AccountPushParams Settings { get; set; }
    }

    public class AccountUserSettings
    {
        /// <summary>
        /// User first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// User last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// User maiden name
        /// </summary>
        public string MaidenName { get; set; }
        /// <summary>
        /// Domain name of the user's page
        /// </summary>
        public string ScreenName { get; set; }
        /// <summary>
        /// User sex
        /// </summary>
        public int? Sex { get; set; }
        /// <summary>
        /// User relationship status
        /// </summary>
        public int? Relation { get; set; }
        public UsersUserMin RelationPartner { get; set; }
        /// <summary>
        /// Information whether relation status is pending
        /// </summary>
        public int? RelationPending { get; set; }
        public IEnumerable<UsersUserMin> RelationRequests { get; set; }
        /// <summary>
        /// User's date of birth
        /// </summary>
        public string Bdate { get; set; }
        /// <summary>
        /// Information whether user's birthdate are hidden
        /// </summary>
        public int? BdateVisibility { get; set; }
        /// <summary>
        /// User's hometown
        /// </summary>
        public string HomeTown { get; set; }
        public BaseCountry Country { get; set; }
        public BaseObject City { get; set; }
        /// <summary>
        /// User status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// User phone number with some hidden digits
        /// </summary>
        public string Phone { get; set; }
        public AccountNameRequest NameRequest { get; set; }
    }

    public class AccountUserXtrContact : UsersUserFull
    {
        public string Contact { get; set; }
        public int? RequestSent { get; set; }
        public int? SortNum { get; set; }
    }

    public class AdsAccesses
    {
        /// <summary>
        /// Client ID
        /// </summary>
        public string ClientId { get; set; }
        public string Role { get; set; }
    }

    public class AdsAccount
    {
        /// <summary>
        /// Account ID
        /// </summary>
        public int? AccountId { get; set; }
        /// <summary>
        /// Account type
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// Information whether account is active
        /// </summary>
        public bool? AccountStatus { get; set; }
        public string AccessRole { get; set; }
    }

    public class AdsAd
    {
        /// <summary>
        /// Ad ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Campaign ID
        /// </summary>
        public int? CampaignId { get; set; }
        /// <summary>
        /// Ad format
        /// </summary>
        public int? AdFormat { get; set; }
        /// <summary>
        /// Cost type
        /// </summary>
        public int? CostType { get; set; }
        /// <summary>
        /// Cost of a click, kopecks
        /// </summary>
        public int? Cpc { get; set; }
        /// <summary>
        /// Cost of 1000 impressions, kopecks
        /// </summary>
        public int? Cpm { get; set; }
        /// <summary>
        /// Impressions limit
        /// </summary>
        public int? ImpressionsLimit { get; set; }
        /// <summary>
        /// Information whether impressions are limited
        /// </summary>
        public int? ImpressionsLimited { get; set; }
        /// <summary>
        /// Ad platform
        /// </summary>
        public string AdPlatform { get; set; }
        /// <summary>
        /// Total limit
        /// </summary>
        public int? AllLimit { get; set; }
        /// <summary>
        /// Category ID
        /// </summary>
        public int? Category1Id { get; set; }
        /// <summary>
        /// Additional category ID
        /// </summary>
        public int? Category2Id { get; set; }
        /// <summary>
        /// Ad atatus
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Ad title
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Review status
        /// </summary>
        public int? Approved { get; set; }
        /// <summary>
        /// Information whether the ad is a video
        /// </summary>
        public bool? Video { get; set; }
        /// <summary>
        /// Information whether disclaimer is enabled
        /// </summary>
        public bool? DisclaimerMedical { get; set; }
        /// <summary>
        /// Information whether disclaimer is enabled
        /// </summary>
        public bool? DisclaimerSpecialist { get; set; }
        /// <summary>
        /// Information whether disclaimer is enabled
        /// </summary>
        public bool? DisclaimerSupplements { get; set; }
    }

    public class AdsAdLayout
    {
        /// <summary>
        /// Ad ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Campaign ID
        /// </summary>
        public int? CampaignId { get; set; }
        /// <summary>
        /// Ad format
        /// </summary>
        public int? AdFormat { get; set; }
        /// <summary>
        /// Cost type
        /// </summary>
        public int? CostType { get; set; }
        /// <summary>
        /// Information whether the ad is a video
        /// </summary>
        public bool? Video { get; set; }
        /// <summary>
        /// Ad title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Ad description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// URL of advertised object
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>
        /// Domain of advertised object
        /// </summary>
        public string LinkDomain { get; set; }
        /// <summary>
        /// link to preview an ad as it is shown on the website
        /// </summary>
        public string PreviewLink { get; set; }
        /// <summary>
        /// Image URL
        /// </summary>
        public int? ImageSrc { get; set; }
        /// <summary>
        /// URL of the preview image in double size
        /// </summary>
        public int? ImageSrc2x { get; set; }
    }

    public class AdsCampaign
    {
        /// <summary>
        /// Campaign ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Campaign type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Campaign title
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Campaign status
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Campaign's day limit, rubles
        /// </summary>
        public string DayLimit { get; set; }
        /// <summary>
        /// Campaign's total limit, rubles
        /// </summary>
        public string AllLimit { get; set; }
        /// <summary>
        /// Campaign start time, as Unixtime
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// Campaign stop time, as Unixtime
        /// </summary>
        public DateTime? StopTime { get; set; }
    }

    public class AdsCategory
    {
        /// <summary>
        /// Category ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }
        public IEnumerable<BaseObjectWithName> Subcategories { get; set; }
    }

    public class AdsClient
    {
        /// <summary>
        /// Client ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Client name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Client's day limit, rubles
        /// </summary>
        public string DayLimit { get; set; }
        /// <summary>
        /// Client's total limit, rubles
        /// </summary>
        public string AllLimit { get; set; }
    }

    public class AdsCriteria
    {
        /// <summary>
        /// Sex
        /// </summary>
        public int? Sex { get; set; }
        /// <summary>
        /// Age from
        /// </summary>
        public int? AgeFrom { get; set; }
        /// <summary>
        /// Age to
        /// </summary>
        public int? AgeTo { get; set; }
        /// <summary>
        /// Days to birthday
        /// </summary>
        public int? Birthday { get; set; }
        /// <summary>
        /// Country ID
        /// </summary>
        public int? Country { get; set; }
        /// <summary>
        /// Cities IDs
        /// </summary>
        public string Cities { get; set; }
        /// <summary>
        /// Cities IDs to except
        /// </summary>
        public string CitiesNot { get; set; }
        /// <summary>
        /// Relationship statuses
        /// </summary>
        public string Statuses { get; set; }
        /// <summary>
        /// Communities IDs
        /// </summary>
        public string Groups { get; set; }
        /// <summary>
        /// Apps IDs
        /// </summary>
        public string Apps { get; set; }
        /// <summary>
        /// Apps IDs to except
        /// </summary>
        public string AppsNot { get; set; }
        /// <summary>
        /// Districts IDs
        /// </summary>
        public string Districts { get; set; }
        /// <summary>
        /// Stations IDs
        /// </summary>
        public string Stations { get; set; }
        /// <summary>
        /// Streets IDs
        /// </summary>
        public string Streets { get; set; }
        /// <summary>
        /// Schools IDs
        /// </summary>
        public string Schools { get; set; }
        /// <summary>
        /// Positions IDs
        /// </summary>
        public string Positions { get; set; }
        /// <summary>
        /// Religions IDs
        /// </summary>
        public string Religions { get; set; }
        /// <summary>
        /// Interests
        /// </summary>
        public string Interests { get; set; }
        /// <summary>
        /// Interests categories IDs
        /// </summary>
        public string InterestCategories { get; set; }
        /// <summary>
        /// Devices
        /// </summary>
        public string UserDevices { get; set; }
        /// <summary>
        /// Operating systems
        /// </summary>
        public string UserOs { get; set; }
        /// <summary>
        /// Browsers
        /// </summary>
        public string UserBrowsers { get; set; }
        /// <summary>
        /// Retargeting groups IDs
        /// </summary>
        public string RetargetingGroups { get; set; }
        /// <summary>
        /// Retargeting groups IDs to except
        /// </summary>
        public string RetargetingGroupsNot { get; set; }
        /// <summary>
        /// Information whether the user has proceeded VK payments before
        /// </summary>
        public bool? Paying { get; set; }
        /// <summary>
        /// Travellers only
        /// </summary>
        public bool? Travellers { get; set; }
        /// <summary>
        /// School graduation year from
        /// </summary>
        public int? SchoolFrom { get; set; }
        /// <summary>
        /// School graduation year to
        /// </summary>
        public int? SchoolTo { get; set; }
        /// <summary>
        /// University graduation year from
        /// </summary>
        public int? UniFrom { get; set; }
        /// <summary>
        /// University graduation year to
        /// </summary>
        public int? UniTo { get; set; }
    }

    public class AdsDemoStats
    {
        /// <summary>
        /// Object ID
        /// </summary>
        public int? Id { get; set; }
        public string Type { get; set; }
        public AdsDemostatsFormat Stats { get; set; }
    }

    public class AdsDemostatsFormat
    {
        /// <summary>
        /// Day as YYYY-MM-DD
        /// </summary>
        public string Day { get; set; }
        /// <summary>
        /// Month as YYYY-MM
        /// </summary>
        public string Month { get; set; }
        /// <summary>
        /// 1 if period=overall
        /// </summary>
        public int? Overall { get; set; }
        public IEnumerable<AdsStatsSex> Sex { get; set; }
        public IEnumerable<AdsStatsAge> Age { get; set; }
        public IEnumerable<AdsStatsSexAge> SexAge { get; set; }
        public IEnumerable<AdsStatsCities> Cities { get; set; }
    }

    public class AdsFloodStats
    {
        /// <summary>
        /// Requests left
        /// </summary>
        public int? Left { get; set; }
        /// <summary>
        /// Time to refresh in seconds
        /// </summary>
        public int? Refresh { get; set; }
    }

    public class AdsLinkStatus
    {
        /// <summary>
        /// Link status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Reject reason
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// URL
        /// </summary>
        public string RedirectUrl { get; set; }
    }

    public class AdsParagraphs
    {
        /// <summary>
        /// Rules paragraph
        /// </summary>
        public string Paragraph { get; set; }
    }

    public class AdsPostStats : StatsWallpostStat
    {
        /// <summary>
        /// Object ID
        /// </summary>
        public int? AdId { get; set; }
    }

    public class AdsRejectReason
    {
        /// <summary>
        /// Comment text
        /// </summary>
        public string Comment { get; set; }
        public IEnumerable<AdsRules> Rules { get; set; }
    }

    public class AdsRules
    {
        /// <summary>
        /// Comment
        /// </summary>
        public string Title { get; set; }
        public IEnumerable<AdsParagraphs> Paragraphs { get; set; }
    }

    public class AdsStats
    {
        /// <summary>
        /// Object ID
        /// </summary>
        public int? Id { get; set; }
        public string Type { get; set; }
        public AdsStatsFormat Stats { get; set; }
    }

    public class AdsStatsAge
    {
        /// <summary>
        /// Impressions rate
        /// </summary>
        public double? ImpressionsRate { get; set; }
        /// <summary>
        /// Clicks rate
        /// </summary>
        public double? ClicksRate { get; set; }
        /// <summary>
        /// Age interval
        /// </summary>
        public string Value { get; set; }
    }

    public class AdsStatsCities
    {
        /// <summary>
        /// Impressions rate
        /// </summary>
        public double? ImpressionsRate { get; set; }
        /// <summary>
        /// Clicks rate
        /// </summary>
        public double? ClicksRate { get; set; }
        /// <summary>
        /// City ID
        /// </summary>
        public int? Value { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        public string Name { get; set; }
    }

    public class AdsStatsFormat
    {
        /// <summary>
        /// Day as YYYY-MM-DD
        /// </summary>
        public string Day { get; set; }
        /// <summary>
        /// Month as YYYY-MM
        /// </summary>
        public string Month { get; set; }
        /// <summary>
        /// 1 if period=overall
        /// </summary>
        public int? Overall { get; set; }
        /// <summary>
        /// Spent funds
        /// </summary>
        public int? Spent { get; set; }
        /// <summary>
        /// Impressions number
        /// </summary>
        public int? Impressions { get; set; }
        /// <summary>
        /// Clicks number
        /// </summary>
        public int? Clicks { get; set; }
        /// <summary>
        /// Reach 
        /// </summary>
        public int? Reach { get; set; }
        /// <summary>
        /// Video views number
        /// </summary>
        public int? VideoViews { get; set; }
        /// <summary>
        /// Video views (half of video)
        /// </summary>
        public int? VideoViewsHalf { get; set; }
        /// <summary>
        /// Video views (full video)
        /// </summary>
        public int? VideoViewsFull { get; set; }
        /// <summary>
        /// Clickthoughs to the advertised site
        /// </summary>
        public int? VideoClicksSite { get; set; }
        /// <summary>
        /// Events number
        /// </summary>
        public int? JoinRate { get; set; }
    }

    public class AdsStatsSex
    {
        /// <summary>
        /// Impressions rate
        /// </summary>
        public double? ImpressionsRate { get; set; }
        /// <summary>
        /// Clicks rate
        /// </summary>
        public double? ClicksRate { get; set; }
        /// <summary>
        /// Sex
        /// </summary>
        public string Value { get; set; }
    }

    public class AdsStatsSexAge
    {
        /// <summary>
        /// Impressions rate
        /// </summary>
        public double? ImpressionsRate { get; set; }
        /// <summary>
        /// Clicks rate
        /// </summary>
        public double? ClicksRate { get; set; }
        /// <summary>
        /// Sex and age interval
        /// </summary>
        public string Value { get; set; }
    }

    public class AdsTargSettings : AdsCriteria
    {
        /// <summary>
        /// Ad ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Campaign ID
        /// </summary>
        public int? CampaignId { get; set; }
    }

    public class AdsTargStats
    {
        /// <summary>
        /// Audience
        /// </summary>
        public int? AudienceCount { get; set; }
        /// <summary>
        /// Recommended CPC value
        /// </summary>
        public double? RecommendedCpc { get; set; }
        /// <summary>
        /// Recommended CPM value
        /// </summary>
        public double? RecommendedCpm { get; set; }
    }

    public class AdsTargSuggestions
    {
        /// <summary>
        /// Object ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Object name
        /// </summary>
        public string Name { get; set; }
    }

    public class AdsTargSuggestionsCities
    {
        /// <summary>
        /// Object ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Object name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Parent object
        /// </summary>
        public string Parent { get; set; }
    }

    public class AdsTargSuggestionsRegions
    {
        /// <summary>
        /// Object ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Object name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Object type
        /// </summary>
        public string Type { get; set; }
    }

    public class AdsTargSuggestionsSchools
    {
        /// <summary>
        /// School ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// School title
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Full school title
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// School type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        public string Parent { get; set; }
    }

    public class AdsTargetGroup
    {
        /// <summary>
        /// Group ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Group name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Site domain
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// Audience
        /// </summary>
        public int? AudienceCount { get; set; }
        /// <summary>
        /// Number of days for user to be in group
        /// </summary>
        public int? Lifetime { get; set; }
        /// <summary>
        /// Pixel code
        /// </summary>
        public string Pixel { get; set; }
    }

    public class AdsUsers
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        public IEnumerable<AdsAccesses> Accesses { get; set; }
    }

    public class AppsApp
    {
        /// <summary>
        /// Application ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Application title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Screen name
        /// </summary>
        public string ScreenName { get; set; }
        /// <summary>
        /// Application description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// URL of the app icon with 279 px in width
        /// </summary>
        public string Icon278 { get; set; }
        /// <summary>
        /// URL of the app icon with 150 px in width
        /// </summary>
        public string Icon150 { get; set; }
        /// <summary>
        /// URL of the app icon with 139 px in width
        /// </summary>
        public string Icon139 { get; set; }
        /// <summary>
        /// URL of the app icon with 75 px in width
        /// </summary>
        public string Icon75 { get; set; }
        /// <summary>
        /// URL of the app banner with 560 px in width
        /// </summary>
        public string Banner560 { get; set; }
        /// <summary>
        /// URL of the app banner with 1120 px in width
        /// </summary>
        public string Banner1120 { get; set; }
        /// <summary>
        /// Application type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Application section name
        /// </summary>
        public string Section { get; set; }
        /// <summary>
        /// Application author's URL
        /// </summary>
        public string AuthorUrl { get; set; }
        /// <summary>
        /// Application author's ID
        /// </summary>
        public int? AuthorId { get; set; }
        /// <summary>
        /// Official community's ID
        /// </summary>
        public int? AuthorGroup { get; set; }
        /// <summary>
        /// Members number
        /// </summary>
        public int? MembersCount { get; set; }
        /// <summary>
        /// Date when the application has been published in Unixtime
        /// </summary>
        public DateTime? PublishedDate { get; set; }
        /// <summary>
        /// Catalog position
        /// </summary>
        public int? CatalogPosition { get; set; }
        public IEnumerable<PhotosPhoto> Screenshots { get; set; }
        /// <summary>
        /// Information whether the application is multilanguage
        /// </summary>
        public int? International { get; set; }
        /// <summary>
        /// Leaderboard type
        /// </summary>
        public int? LeaderboardType { get; set; }
        /// <summary>
        /// Genre ID
        /// </summary>
        public int? GenreId { get; set; }
        /// <summary>
        /// Genre name
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Application ID in store
        /// </summary>
        public int? PlatformId { get; set; }
        /// <summary>
        /// Information whther application is in mobile catalog
        /// </summary>
        public int? IsInCatalog { get; set; }
    }

    public class AppsLeaderboard
    {
        /// <summary>
        /// Score number
        /// </summary>
        public int? Score { get; set; }
        /// <summary>
        /// Level
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// Points number
        /// </summary>
        public int? Points { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
    }

    public class AudioAudio
    {
        /// <summary>
        /// Audio ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Audio owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Artist name
        /// </summary>
        public string Artist { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// URL of mp3 file
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Access key for the audio
        /// </summary>
        public string AccessKey { get; set; }
    }

    public class AudioAudioFull : AudioAudio
    {
        /// <summary>
        /// Duration in seconds
        /// </summary>
        public int? Duration { get; set; }
        /// <summary>
        /// Date when uploaded
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Album ID
        /// </summary>
        public int? AlbumId { get; set; }
        /// <summary>
        /// Lyrics ID
        /// </summary>
        public int? LyricsId { get; set; }
        /// <summary>
        /// Genre ID
        /// </summary>
        public int? GenreId { get; set; }
        /// <summary>
        /// Information whether the audio is hidden from search
        /// </summary>
        public bool? NoSearch { get; set; }
    }

    public class AudioAudioUploadResponse
    {
        /// <summary>
        /// Redirect URL
        /// </summary>
        public string Redirect { get; set; }
        /// <summary>
        /// Upload server number
        /// </summary>
        public int? Server { get; set; }
        /// <summary>
        /// Uploaded aduio data
        /// </summary>
        public string Audio { get; set; }
        /// <summary>
        /// Uploading hash
        /// </summary>
        public string Hash { get; set; }
    }

    public class AudioLyrics
    {
        /// <summary>
        /// Lyrics ID
        /// </summary>
        public int? LyricsId { get; set; }
        /// <summary>
        /// Lyrics text
        /// </summary>
        public string Text { get; set; }
    }

    public class BaseCommentsInfo
    {
        /// <summary>
        /// Comments number
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Information whether current user can comment the post
        /// </summary>
        public bool? CanPost { get; set; }
        public bool? GroupsCanPost { get; set; }
    }

    public class BaseCountry
    {
        /// <summary>
        /// Country ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Country title
        /// </summary>
        public string Title { get; set; }
    }

    public class BaseError
    {
        /// <summary>
        /// Error code
        /// </summary>
        public int? ErrorCode { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMsg { get; set; }
        public IEnumerable<BaseRequestParam> RequestParams { get; set; }
    }

    public class BaseGeo
    {
        /// <summary>
        /// Place type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// String with coordinates
        /// </summary>
        public string Coordinates { get; set; }
        public BasePlace Place { get; set; }
        /// <summary>
        /// Information whether a map is showed
        /// </summary>
        public int? Showmap { get; set; }
    }

    public class BaseImage
    {
        /// <summary>
        /// Image url
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Image width
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Image height
        /// </summary>
        public int? Height { get; set; }
    }

    public class BaseLikes
    {
        /// <summary>
        /// Information whether current user likes the photo
        /// </summary>
        public bool? UserLikes { get; set; }
        /// <summary>
        /// Likes number
        /// </summary>
        public int? Count { get; set; }
    }

    public class BaseLikesInfo
    {
        /// <summary>
        /// Likes number
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Information whether current uer has liked the post
        /// </summary>
        public int? UserLikes { get; set; }
        /// <summary>
        /// Information whether current user can like the post
        /// </summary>
        public int? CanLike { get; set; }
        /// <summary>
        /// Information whether current user can repost
        /// </summary>
        public int? CanPublish { get; set; }
    }

    public class BaseLink
    {
        /// <summary>
        /// Link URL
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Link title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Link caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// Link description
        /// </summary>
        public string Description { get; set; }
        public PhotosPhoto Photo { get; set; }
        /// <summary>
        /// URL of the page with article preview
        /// </summary>
        public string PreviewUrl { get; set; }
        /// <summary>
        /// String ID of the page with article preview
        /// </summary>
        public string PreviewPage { get; set; }
        public BaseLinkButton Button { get; set; }
        public BaseLinkProduct Product { get; set; }
        public BaseLinkRating Rating { get; set; }
        public BaseLinkApplication Application { get; set; }
    }

    public class BaseLinkApplication
    {
        /// <summary>
        /// Application Id
        /// </summary>
        public double? AppId { get; set; }
        public BaseLinkApplicationStore Store { get; set; }
    }

    public class BaseLinkApplicationStore
    {
        /// <summary>
        /// Store Id
        /// </summary>
        public double? Id { get; set; }
        /// <summary>
        /// Store name
        /// </summary>
        public string Name { get; set; }
    }

    public class BaseLinkButton
    {
        /// <summary>
        /// Button title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Button action
        /// </summary>
        public BaseLinkButtonAction Action { get; set; }
    }

    public class BaseLinkButtonAction
    {
        public string Type { get; set; }
        /// <summary>
        /// Action URL
        /// </summary>
        public string Url { get; set; }
    }

    public class BaseLinkProduct
    {
        public MarketPrice Price { get; set; }
    }

    public class BaseLinkRating
    {
        /// <summary>
        /// Count of stars
        /// </summary>
        public double? Stars { get; set; }
        /// <summary>
        /// Count of reviews
        /// </summary>
        public int? ReviewsCount { get; set; }
    }

    public class BaseObject
    {
        /// <summary>
        /// Object ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Object title
        /// </summary>
        public string Title { get; set; }
    }

    public class BaseObjectCount
    {
        /// <summary>
        /// Items count
        /// </summary>
        public int? Count { get; set; }
    }

    public class BaseObjectWithName
    {
        /// <summary>
        /// Object ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Object name
        /// </summary>
        public string Name { get; set; }
    }

    public class BasePlace
    {
        /// <summary>
        /// Place ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Place title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Place latitude
        /// </summary>
        public double? Latitude { get; set; }
        /// <summary>
        /// Place longitude
        /// </summary>
        public double? Longitude { get; set; }
        /// <summary>
        /// Date of the place creation in Unixtime
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// URL of the place's icon
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// Checkins number
        /// </summary>
        public int? Checkins { get; set; }
        /// <summary>
        /// Place type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Country name
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Place address
        /// </summary>
        public string Address { get; set; }
    }

    public class BaseRepostsInfo
    {
        /// <summary>
        /// Reposts number
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Information whether current user has reposted the post
        /// </summary>
        public int? UserReposted { get; set; }
    }

    public class BaseRequestParam
    {
        /// <summary>
        /// Parameter name
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Parameter value
        /// </summary>
        public string Value { get; set; }
    }

    public class BaseSticker
    {
        /// <summary>
        /// Sticker ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Collection ID
        /// </summary>
        public int? ProductId { get; set; }
        /// <summary>
        /// URL of the preview image with 64 px in height
        /// </summary>
        public string Photo64 { get; set; }
        /// <summary>
        /// URL of the preview image with 128 px in height
        /// </summary>
        public string Photo128 { get; set; }
        /// <summary>
        /// URL of the preview image with 256 px in height
        /// </summary>
        public string Photo256 { get; set; }
        /// <summary>
        /// URL of the preview image with 352 px in height
        /// </summary>
        public string Photo352 { get; set; }
        /// <summary>
        /// Width in px
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Hieght in px
        /// </summary>
        public int? Height { get; set; }
    }

    public class BaseUserId
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
    }

    public class BoardTopic
    {
        /// <summary>
        /// Topic ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Topic title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Date when the topic has been created in Unixtime
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// Creator ID
        /// </summary>
        public int? CreatedBy { get; set; }
        /// <summary>
        /// Date when the topic has been updated in Unixtime
        /// </summary>
        public DateTime? Updated { get; set; }
        /// <summary>
        /// ID of user who updated the topic
        /// </summary>
        public int? UpdatedBy { get; set; }
        /// <summary>
        /// Information whether the topic is closed
        /// </summary>
        public bool? IsClosed { get; set; }
        /// <summary>
        /// Information whether the topic is fixed
        /// </summary>
        public bool? IsFixed { get; set; }
        /// <summary>
        /// Comments number
        /// </summary>
        public int? Comments { get; set; }
    }

    public class BoardTopicComment
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Author ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Text { get; set; }
        public IEnumerable<WallCommentAttachment> Attachments { get; set; }
        /// <summary>
        /// Real position of the comment
        /// </summary>
        public int? RealOffset { get; set; }
    }

    public class BoardTopicPoll
    {
        /// <summary>
        /// Poll ID
        /// </summary>
        public int? PollId { get; set; }
        /// <summary>
        /// Poll owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Date when poll has been created in Unixtime
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// Information whether the poll is closed
        /// </summary>
        public bool? IsClosed { get; set; }
        /// <summary>
        /// Poll question
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// Votes number
        /// </summary>
        public string Votes { get; set; }
        /// <summary>
        /// Current user's answer ID
        /// </summary>
        public int? AnswerId { get; set; }
        public IEnumerable<PollsAnswer> Answers { get; set; }
    }

    public class DatabaseCity : BaseObject
    {
        /// <summary>
        /// Area title
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// Region title
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// Information whether the city is included in important cities list
        /// </summary>
        public bool? Important { get; set; }
    }

    public class DatabaseFaculty
    {
        /// <summary>
        /// Faculty ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Faculty title
        /// </summary>
        public string Title { get; set; }
    }

    public class DatabaseRegion
    {
        /// <summary>
        /// Region ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Region title
        /// </summary>
        public string Title { get; set; }
    }

    public class DatabaseSchool
    {
        /// <summary>
        /// School ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// School title
        /// </summary>
        public string Title { get; set; }
    }

    public class DatabaseStreet
    {
        /// <summary>
        /// Street ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Street title
        /// </summary>
        public string Title { get; set; }
    }

    public class DatabaseUniversity
    {
        /// <summary>
        /// University ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// University title
        /// </summary>
        public string Title { get; set; }
    }

    public class DocsDoc
    {
        /// <summary>
        /// Document ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Document owner ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Document title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// File size in bites
        /// </summary>
        public int? Size { get; set; }
        /// <summary>
        /// File extension
        /// </summary>
        public string Ext { get; set; }
        /// <summary>
        /// File URL
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Date when file has been uploaded in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Document type
        /// </summary>
        public int? Type { get; set; }
        public DocsDocPreview Preview { get; set; }
        /// <summary>
        /// Access key for the document
        /// </summary>
        public string AccessKey { get; set; }
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
        /// <summary>
        /// Video URL
        /// </summary>
        public string Src { get; set; }
        /// <summary>
        /// Video's width in pixels
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Video's height in pixels
        /// </summary>
        public int? Height { get; set; }
        /// <summary>
        /// Video file size in bites
        /// </summary>
        public int? Filesize { get; set; }
    }

    public class DocsDocTypes
    {
        /// <summary>
        /// Doc type ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Doc type title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Number of docs
        /// </summary>
        public int? Count { get; set; }
    }

    public class DocsDocUploadResponse
    {
        /// <summary>
        /// Uploaded file data
        /// </summary>
        public string File { get; set; }
    }

    public class FaveFavesLink
    {
        /// <summary>
        /// Link ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Link URL
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Link title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Link description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// URL of the preview image with 50 px in width
        /// </summary>
        public string Photo50 { get; set; }
        /// <summary>
        /// URL of the preview image with 100 px in width
        /// </summary>
        public string Photo100 { get; set; }
        /// <summary>
        /// URL of the preview image with 200 px in width
        /// </summary>
        public string Photo200 { get; set; }
    }

    public class FriendsFriendStatus
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Friend status with the user
        /// </summary>
        public int? FriendStatus { get; set; }
        /// <summary>
        /// Message sent with request
        /// </summary>
        public string RequestMessage { get; set; }
        /// <summary>
        /// Information whether request is unviewed
        /// </summary>
        public int? ReadState { get; set; }
        /// <summary>
        /// MD5 hash for the result validation
        /// </summary>
        public string Sign { get; set; }
    }

    public class FriendsFriendsList
    {
        /// <summary>
        /// List title
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// List ID
        /// </summary>
        public int? Id { get; set; }
    }

    public class FriendsMutualFriend
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Total mutual friends number
        /// </summary>
        public int? CommonCount { get; set; }
        public IEnumerable<int?> CommonFriends { get; set; }
    }

    public class FriendsRequests
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// ID of the user by whom friend has been suggested
        /// </summary>
        public string From { get; set; }
        public FriendsRequestsMutual Mutual { get; set; }
    }

    public class FriendsRequestsMutual
    {
        /// <summary>
        /// Total mutual friends number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Users { get; set; }
    }

    public class FriendsRequestsXtrMessage
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// ID of the user by whom friend has been suggested
        /// </summary>
        public string From { get; set; }
        public FriendsRequestsMutual Mutual { get; set; }
        /// <summary>
        /// Message sent with a request
        /// </summary>
        public string Message { get; set; }
    }

    public class FriendsUserXtrLists : UsersUserFull
    {
        public IEnumerable<int?> Lists { get; set; }
    }

    public class FriendsUserXtrPhone : UsersUserFull
    {
        /// <summary>
        /// User phone
        /// </summary>
        public string Phone { get; set; }
    }

    public class GiftsGift
    {
        /// <summary>
        /// Gift ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Gift sender ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Date when gist has been sent in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        public GiftsLayout Gift { get; set; }
        /// <summary>
        /// Gift privacy
        /// </summary>
        public int? Privacy { get; set; }
        /// <summary>
        /// Hash
        /// </summary>
        public string GiftHash { get; set; }
    }

    public class GiftsLayout
    {
        /// <summary>
        /// Gift ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// URL of the preview image with 256 px in width
        /// </summary>
        public string Thumb256 { get; set; }
        /// <summary>
        /// URL of the preview image with 96 px in width
        /// </summary>
        public string Thumb96 { get; set; }
        /// <summary>
        /// URL of the preview image with 48 px in width
        /// </summary>
        public string Thumb48 { get; set; }
    }

    public class GroupsBanInfo
    {
        /// <summary>
        /// Administrator ID
        /// </summary>
        public int? AdminId { get; set; }
        /// <summary>
        /// Date when user has been added to blacklist in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Ban reason
        /// </summary>
        public int? Reason { get; set; }
        /// <summary>
        /// Comment for a ban
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Date when user will be removed from blacklist in Unixtime
        /// </summary>
        public DateTime? EndDate { get; set; }
    }

    public class GroupsContactsItem
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Contact description
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// Contact email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Contact phone
        /// </summary>
        public string Phone { get; set; }
    }

    public class GroupsCountersGroup
    {
        /// <summary>
        /// Photos number
        /// </summary>
        public int? Photos { get; set; }
        /// <summary>
        /// Photo albums number
        /// </summary>
        public int? Albums { get; set; }
        /// <summary>
        /// Topics number
        /// </summary>
        public int? Topics { get; set; }
        /// <summary>
        /// Videos number
        /// </summary>
        public int? Videos { get; set; }
        /// <summary>
        /// Audios number
        /// </summary>
        public int? Audios { get; set; }
        /// <summary>
        /// Docs number
        /// </summary>
        public int? Docs { get; set; }
        /// <summary>
        /// Market items number
        /// </summary>
        public int? Market { get; set; }
    }

    public class GroupsCover
    {
        /// <summary>
        /// Information whether cover is enabled
        /// </summary>
        public bool? Enabled { get; set; }
        public IEnumerable<BaseImage> Images { get; set; }
    }

    public class GroupsGroup
    {
        /// <summary>
        /// Community ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Community name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Domain of the community page
        /// </summary>
        public string ScreenName { get; set; }
        /// <summary>
        /// Information whether community is banned
        /// </summary>
        public string Deactivated { get; set; }
        /// <summary>
        /// Information whether community is closed
        /// </summary>
        public int? IsClosed { get; set; }
        /// <summary>
        /// Community type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Information whether current user is administrator
        /// </summary>
        public bool? IsAdmin { get; set; }
        /// <summary>
        /// Level of current user's credentials as manager
        /// </summary>
        public int? AdminLevel { get; set; }
        /// <summary>
        /// Information whether current user is member
        /// </summary>
        public bool? IsMember { get; set; }
        /// <summary>
        /// URL of square photo of the community with 50 pixels in width
        /// </summary>
        public string Photo50 { get; set; }
        /// <summary>
        /// URL of square photo of the community with 100 pixels in width
        /// </summary>
        public string Photo100 { get; set; }
        /// <summary>
        /// URL of square photo of the community with 200 pixels in width
        /// </summary>
        public string Photo200 { get; set; }
    }

    public class GroupsGroupBanInfo
    {
        /// <summary>
        /// End date of ban in Unixtime
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Ban comment
        /// </summary>
        public string Comment { get; set; }
    }

    public class GroupsGroupCategory
    {
        /// <summary>
        /// Category ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }
        public IEnumerable<BaseObjectWithName> Subcategories { get; set; }
    }

    public class GroupsGroupCategoryFull
    {
        /// <summary>
        /// Category ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }
        public IEnumerable<GroupsGroupCategory> Subcategories { get; set; }
        /// <summary>
        /// Pages number
        /// </summary>
        public int? PageCount { get; set; }
        public IEnumerable<GroupsGroup> PagePreviews { get; set; }
    }

    public class GroupsGroupFull : GroupsGroup
    {
        public GroupsMarketInfo Market { get; set; }
        /// <summary>
        /// Current user's member status
        /// </summary>
        public int? MemberStatus { get; set; }
        /// <summary>
        /// Information whether community is in faves
        /// </summary>
        public bool? IsFavorite { get; set; }
        /// <summary>
        /// Information whether current user is subscribed
        /// </summary>
        public bool? IsSubscribed { get; set; }
        public BaseObject City { get; set; }
        public BaseCountry Country { get; set; }
        /// <summary>
        /// Information whether community is verified
        /// </summary>
        public bool? Verified { get; set; }
        /// <summary>
        /// Community description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Community's main wiki page title
        /// </summary>
        public string WikiPage { get; set; }
        /// <summary>
        /// Community members number
        /// </summary>
        public int? MembersCount { get; set; }
        public GroupsCountersGroup Counters { get; set; }
        public GroupsCover Cover { get; set; }
        /// <summary>
        /// Information whether current user can post on community's wall
        /// </summary>
        public bool? CanPost { get; set; }
        /// <summary>
        /// Information whether current user can see all posts on community's wall
        /// </summary>
        public bool? CanSeeAllPosts { get; set; }
        /// <summary>
        /// Type of group, start date of event or category of public page
        /// </summary>
        public string Activity { get; set; }
        /// <summary>
        /// Fixed post ID
        /// </summary>
        public int? FixedPost { get; set; }
        /// <summary>
        /// Information whether current user can create topic
        /// </summary>
        public bool? CanCreateTopic { get; set; }
        /// <summary>
        /// Information whether current user can upload video
        /// </summary>
        public bool? CanUploadVideo { get; set; }
        /// <summary>
        /// Information whether community has photo
        /// </summary>
        public bool? HasPhoto { get; set; }
        /// <summary>
        /// Community status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Community's main photo album ID
        /// </summary>
        public int? MainAlbumId { get; set; }
        public IEnumerable<GroupsLinksItem> Links { get; set; }
        public IEnumerable<GroupsContactsItem> Contacts { get; set; }
        /// <summary>
        /// Community's website
        /// </summary>
        public string Site { get; set; }
        /// <summary>
        /// Main section of community
        /// </summary>
        public int? MainSection { get; set; }
        /// <summary>
        /// Information whether current user can send a message to community
        /// </summary>
        public bool? CanMessage { get; set; }
        /// <summary>
        /// Information whether current user can send a message to community
        /// </summary>
        public bool? IsMessagesAllowed { get; set; }
        /// <summary>
        /// Start date of event in Unixtime
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Finish date of event in Unixtime
        /// </summary>
        public DateTime? FinishDate { get; set; }
        /// <summary>
        /// Information whether age limit
        /// </summary>
        public int? AgeLimits { get; set; }
        /// <summary>
        /// User ban info
        /// </summary>
        public GroupsGroupBanInfo BanInfo { get; set; }
    }

    public class GroupsGroupLink
    {
        /// <summary>
        /// Link ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Link URL
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Information whether the title can be edited
        /// </summary>
        public bool? EditTitle { get; set; }
        /// <summary>
        /// Link description
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// Information whether the image on processing
        /// </summary>
        public bool? ImageProcessing { get; set; }
    }

    public class GroupsGroupSettings
    {
        /// <summary>
        /// Community title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Community description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Community's page domain
        /// </summary>
        public string Address { get; set; }
        public PlacesPlaceMin Place { get; set; }
        /// <summary>
        /// Wall settings
        /// </summary>
        public int? Wall { get; set; }
        /// <summary>
        /// Photos settings
        /// </summary>
        public int? Photos { get; set; }
        /// <summary>
        /// Video settings
        /// </summary>
        public int? Video { get; set; }
        /// <summary>
        /// Audio settings
        /// </summary>
        public int? Audio { get; set; }
        /// <summary>
        /// Docs settings
        /// </summary>
        public int? Docs { get; set; }
        /// <summary>
        /// Topics settings
        /// </summary>
        public int? Topics { get; set; }
        /// <summary>
        /// Wiki settings
        /// </summary>
        public int? Wiki { get; set; }
        /// <summary>
        /// Information whether the obscene filter is enabled
        /// </summary>
        public bool? ObsceneFilter { get; set; }
        /// <summary>
        /// Information whether the stopwords filter is enabled
        /// </summary>
        public bool? ObsceneStopwords { get; set; }
        /// <summary>
        /// The list of stop words
        /// </summary>
        public string ObsceneWords { get; set; }
        /// <summary>
        /// Community access settings
        /// </summary>
        public int? Access { get; set; }
        /// <summary>
        /// Community subject ID
        /// </summary>
        public int? Subject { get; set; }
        public IEnumerable<GroupsSubjectItem> SubjectList { get; set; }
        /// <summary>
        /// URL of the RSS feed
        /// </summary>
        public string Rss { get; set; }
        /// <summary>
        /// Community website
        /// </summary>
        public string Website { get; set; }
    }

    public class GroupsGroupXtrInvitedBy
    {
        /// <summary>
        /// Community ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Community name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Domain of the community page
        /// </summary>
        public string ScreenName { get; set; }
        /// <summary>
        /// Information whether community is closed
        /// </summary>
        public bool? IsClosed { get; set; }
        /// <summary>
        /// Community type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Information whether current user is manager
        /// </summary>
        public bool? IsAdmin { get; set; }
        /// <summary>
        /// Level of current user's credentials as manager
        /// </summary>
        public int? AdminLevel { get; set; }
        /// <summary>
        /// Information whether current user is member
        /// </summary>
        public bool? IsMember { get; set; }
        /// <summary>
        /// URL of square photo of the community with 50 pixels in width
        /// </summary>
        public string Photo50 { get; set; }
        /// <summary>
        /// URL of square photo of the community with 100 pixels in width
        /// </summary>
        public string Photo100 { get; set; }
        /// <summary>
        /// URL of square photo of the community with 200 pixels in width
        /// </summary>
        public string Photo200 { get; set; }
        /// <summary>
        /// Inviter ID
        /// </summary>
        public int? InvitedBy { get; set; }
    }

    public class GroupsGroupsArray
    {
        /// <summary>
        /// Communities number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class GroupsLinksItem
    {
        /// <summary>
        /// Link ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Link URL
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Information whether the link title can be edited
        /// </summary>
        public bool? EditTitle { get; set; }
        /// <summary>
        /// Link title
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Link description
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// URL of square image of the link with 50 pixels in width
        /// </summary>
        public string Photo50 { get; set; }
        /// <summary>
        /// URL of square image of the link with 100 pixels in width
        /// </summary>
        public string Photo100 { get; set; }
    }

    public class GroupsMarketInfo
    {
        /// <summary>
        /// Information whether the market is enabled
        /// </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// Minimum price
        /// </summary>
        public int? PriceMin { get; set; }
        /// <summary>
        /// Maximum price
        /// </summary>
        public int? PriceMax { get; set; }
        /// <summary>
        /// Main market album ID
        /// </summary>
        public int? MainAlbumId { get; set; }
        /// <summary>
        /// Contact person ID
        /// </summary>
        public int? ContactId { get; set; }
        public MarketCurrency Currency { get; set; }
        /// <summary>
        /// Currency name
        /// </summary>
        public string CurrencyText { get; set; }
    }

    public class GroupsMemberRole
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// User's credentials as community admin
        /// </summary>
        public string Role { get; set; }
    }

    public class GroupsMemberStatus
    {
        /// <summary>
        /// Information whether user is a member of the group
        /// </summary>
        public bool? Member { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
    }

    public class GroupsMemberStatusFull
    {
        /// <summary>
        /// Information whether user is a member of the group
        /// </summary>
        public bool? Member { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Information whether user has been invited to the group
        /// </summary>
        public bool? Invitation { get; set; }
        /// <summary>
        /// Information whether user has send request to the group
        /// </summary>
        public bool? Request { get; set; }
    }

    public class GroupsSubjectItem
    {
        /// <summary>
        /// Subject ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Subject title
        /// </summary>
        public string Name { get; set; }
    }

    public class GroupsUserXtrBanInfo
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// User first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// User last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Returns if a profile is deleted or blocked
        /// </summary>
        public string Deactivated { get; set; }
        /// <summary>
        /// Returns if a profile is hidden.
        /// </summary>
        public int? Hidden { get; set; }
        /// <summary>
        /// User sex
        /// </summary>
        public int? Sex { get; set; }
        /// <summary>
        /// Domain name of the user's page
        /// </summary>
        public string ScreenName { get; set; }
        /// <summary>
        /// URL of square photo of the user with 50 pixels in width
        /// </summary>
        public string Photo50 { get; set; }
        /// <summary>
        /// URL of square photo of the user with 100 pixels in width
        /// </summary>
        public string Photo100 { get; set; }
        /// <summary>
        /// Information whether the user is online
        /// </summary>
        public bool? Online { get; set; }
        /// <summary>
        /// Information whether the user is online in mobile site or application
        /// </summary>
        public bool? OnlineMobile { get; set; }
        /// <summary>
        /// Application ID
        /// </summary>
        public int? OnlineApp { get; set; }
        /// <summary>
        /// User nickname
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// User maiden name
        /// </summary>
        public string MaidenName { get; set; }
        /// <summary>
        /// Domain name of the user's page
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// User's date of birth
        /// </summary>
        public string Bdate { get; set; }
        public BaseObject City { get; set; }
        public BaseObject Country { get; set; }
        /// <summary>
        /// User's timezone
        /// </summary>
        public int? Timezone { get; set; }
        /// <summary>
        /// URL of square photo of the user with 200 pixels in width
        /// </summary>
        public string Photo200 { get; set; }
        /// <summary>
        /// URL of square photo of the user with maximum width
        /// </summary>
        public string PhotoMax { get; set; }
        /// <summary>
        /// URL of user's photo with 200 pixels in width
        /// </summary>
        public string Photo200Orig { get; set; }
        /// <summary>
        /// URL of user's photo with 400 pixels in width
        /// </summary>
        public string Photo400Orig { get; set; }
        /// <summary>
        /// URL of user's photo of maximum size
        /// </summary>
        public string PhotoMaxOrig { get; set; }
        /// <summary>
        /// ID of the user's main photo
        /// </summary>
        public string PhotoId { get; set; }
        /// <summary>
        /// Information whether the user has main photo
        /// </summary>
        public bool? HasPhoto { get; set; }
        /// <summary>
        /// Information whether the user specified his phone number
        /// </summary>
        public bool? HasMobile { get; set; }
        /// <summary>
        /// Information whether the user is a friend of current user
        /// </summary>
        public bool? IsFriend { get; set; }
        /// <summary>
        /// Friend status for current user
        /// </summary>
        public int? FriendStatus { get; set; }
        /// <summary>
        /// Information whether current user can comment wall posts
        /// </summary>
        public bool? WallComments { get; set; }
        /// <summary>
        /// Information whether current user can post on the user's wall
        /// </summary>
        public bool? CanPost { get; set; }
        /// <summary>
        /// Information whether current user can see other users' audio on the wall
        /// </summary>
        public bool? CanSeeAllPosts { get; set; }
        /// <summary>
        /// Information whether current user can see the user's audio
        /// </summary>
        public bool? CanSeeAudio { get; set; }
        /// <summary>
        /// Information whether current user can write private message
        /// </summary>
        public bool? CanWritePrivateMessage { get; set; }
        /// <summary>
        /// Information whether current user can send a friend request
        /// </summary>
        public bool? CanSendFriendRequest { get; set; }
        /// <summary>
        /// Information whether current user can see
        /// </summary>
        public string MobilePhone { get; set; }
        /// <summary>
        /// User's mobile phone number
        /// </summary>
        public string HomePhone { get; set; }
        /// <summary>
        /// User's Skype nickname
        /// </summary>
        public string Skype { get; set; }
        /// <summary>
        /// User's Facebook account
        /// </summary>
        public string Facebook { get; set; }
        /// <summary>
        /// User's Facebook name
        /// </summary>
        public string FacebookName { get; set; }
        /// <summary>
        /// User's Twitter account
        /// </summary>
        public string Twitter { get; set; }
        /// <summary>
        /// User's Livejournal account
        /// </summary>
        public string Livejournal { get; set; }
        /// <summary>
        /// User's Instagram account
        /// </summary>
        public string Instagram { get; set; }
        /// <summary>
        /// User's website
        /// </summary>
        public string Site { get; set; }
        public AudioAudioFull StatusAudio { get; set; }
        /// <summary>
        /// User's status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// User's status
        /// </summary>
        public string Activity { get; set; }
        public UsersLastSeen LastSeen { get; set; }
        public UsersExports Exports { get; set; }
        public UsersCropPhoto CropPhoto { get; set; }
        /// <summary>
        /// Information whether the user is verified
        /// </summary>
        public bool? Verified { get; set; }
        /// <summary>
        /// Number of user's followers
        /// </summary>
        public int? FollowersCount { get; set; }
        /// <summary>
        /// Information whether current user is in the requested user's blacklist.
        /// </summary>
        public bool? Blacklisted { get; set; }
        /// <summary>
        /// Information whether the requested user is in current user's blacklist
        /// </summary>
        public bool? BlacklistedByMe { get; set; }
        /// <summary>
        /// Information whether the requested user is in faves of current user
        /// </summary>
        public bool? IsFavorite { get; set; }
        /// <summary>
        /// Information whether the requested user is hidden from current user's newsfeed
        /// </summary>
        public bool? IsHiddenFromFeed { get; set; }
        /// <summary>
        /// Number of common friends with current user
        /// </summary>
        public int? CommonCount { get; set; }
        public UsersOccupation Occupation { get; set; }
        public IEnumerable<UsersCareer> Career { get; set; }
        public IEnumerable<UsersMilitary> Military { get; set; }
        /// <summary>
        /// University ID
        /// </summary>
        public int? University { get; set; }
        /// <summary>
        /// University name
        /// </summary>
        public string UniversityName { get; set; }
        /// <summary>
        /// Faculty ID
        /// </summary>
        public int? Faculty { get; set; }
        /// <summary>
        /// Faculty name
        /// </summary>
        public string FacultyName { get; set; }
        /// <summary>
        /// Graduation year
        /// </summary>
        public int? Graduation { get; set; }
        /// <summary>
        /// Education form
        /// </summary>
        public string EducationForm { get; set; }
        /// <summary>
        /// User's education status
        /// </summary>
        public string EducationStatus { get; set; }
        /// <summary>
        /// User hometown
        /// </summary>
        public string HomeTown { get; set; }
        /// <summary>
        /// User relationship status
        /// </summary>
        public int? Relation { get; set; }
        public UsersUserMin RelationPartner { get; set; }
        public UsersPersonal Personal { get; set; }
        /// <summary>
        /// User's interests
        /// </summary>
        public string Interests { get; set; }
        /// <summary>
        /// User's favorite music
        /// </summary>
        public string Music { get; set; }
        /// <summary>
        /// User's activities
        /// </summary>
        public string Activities { get; set; }
        /// <summary>
        /// User's favorite movies
        /// </summary>
        public string Movies { get; set; }
        /// <summary>
        /// User's favorite tv shows
        /// </summary>
        public string Tv { get; set; }
        /// <summary>
        /// User's favorite books
        /// </summary>
        public string Books { get; set; }
        /// <summary>
        /// User's favorite games
        /// </summary>
        public string Games { get; set; }
        public IEnumerable<UsersUniversity> Universities { get; set; }
        public IEnumerable<UsersSchool> Schools { get; set; }
        /// <summary>
        /// About me field
        /// </summary>
        public string About { get; set; }
        public IEnumerable<UsersRelative> Relatives { get; set; }
        /// <summary>
        /// Favorite quotes
        /// </summary>
        public string Quotes { get; set; }
        public GroupsBanInfo BanInfo { get; set; }
    }

    public class GroupsUserXtrRole : UsersUserFull
    {
        public string Role { get; set; }
    }

    public class LeadsChecked
    {
        /// <summary>
        /// Information whether user can start the lead
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// Reason why user can't start the lead
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// URL user should open to start the lead
        /// </summary>
        public string StartLink { get; set; }
        /// <summary>
        /// Session ID
        /// </summary>
        public string Sid { get; set; }
    }

    public class LeadsComplete
    {
        /// <summary>
        /// Offer limit
        /// </summary>
        public int? Limit { get; set; }
        /// <summary>
        /// Amount of spent votes
        /// </summary>
        public int? Spent { get; set; }
        /// <summary>
        /// Offer cost
        /// </summary>
        public int? Cost { get; set; }
        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        public bool? TestMode { get; set; }
        public bool? Success { get; set; }
    }

    public class LeadsEntry
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? Uid { get; set; }
        /// <summary>
        /// Application ID
        /// </summary>
        public int? Aid { get; set; }
        /// <summary>
        /// Session string ID
        /// </summary>
        public string Sid { get; set; }
        /// <summary>
        /// Date when the action has been started in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Action type
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        public bool? TestMode { get; set; }
        /// <summary>
        /// Start date in Unixtime (for status=2)
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Comment { get; set; }
    }

    public class LeadsLead
    {
        /// <summary>
        /// Lead limit
        /// </summary>
        public int? Limit { get; set; }
        /// <summary>
        /// Amount of spent votes
        /// </summary>
        public int? Spent { get; set; }
        /// <summary>
        /// Offer cost
        /// </summary>
        public int? Cost { get; set; }
        /// <summary>
        /// Impressions number
        /// </summary>
        public int? Impressions { get; set; }
        /// <summary>
        /// Started offers number
        /// </summary>
        public int? Started { get; set; }
        /// <summary>
        /// Completed offers number
        /// </summary>
        public int? Completed { get; set; }
        public LeadsLeadDays Days { get; set; }
    }

    public class LeadsLeadDays
    {
        /// <summary>
        /// Impressions number
        /// </summary>
        public int? Impressions { get; set; }
        /// <summary>
        /// Started offers number
        /// </summary>
        public int? Started { get; set; }
        /// <summary>
        /// Completed offers number
        /// </summary>
        public int? Completed { get; set; }
        /// <summary>
        /// Amount of spent votes
        /// </summary>
        public int? Spent { get; set; }
    }

    public class LeadsStart
    {
        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        public bool? TestMode { get; set; }
        /// <summary>
        /// Session data
        /// </summary>
        public string VkSid { get; set; }
    }

    public class MarketCurrency
    {
        /// <summary>
        /// Currency ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Currency sign
        /// </summary>
        public string Name { get; set; }
    }

    public class MarketMarketAlbum
    {
        /// <summary>
        /// Market album ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Market album owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Market album title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Items number
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Date when album has been updated last time in Unixtime
        /// </summary>
        public DateTime? UpdatedTime { get; set; }
        public PhotosPhoto Photo { get; set; }
    }

    public class MarketMarketCategory
    {
        /// <summary>
        /// Category ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }
        public MarketSection Section { get; set; }
    }

    public class MarketMarketItem
    {
        /// <summary>
        /// Item ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Item owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Item title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        public string Description { get; set; }
        public MarketPrice Price { get; set; }
        public MarketMarketCategory Category { get; set; }
        /// <summary>
        /// Date when the item has been created in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// URL of the preview image
        /// </summary>
        public string ThumbPhoto { get; set; }
        /// <summary>
        /// Information whether the item is available
        /// </summary>
        public int? Availability { get; set; }
    }

    public class MarketMarketItemFull : MarketMarketItem
    {
        public IEnumerable<PhotosPhoto> Photos { get; set; }
        /// <summary>
        /// Information whether current use can comment the item
        /// </summary>
        public bool? CanComment { get; set; }
        /// <summary>
        /// Information whether current use can repost the item
        /// </summary>
        public bool? CanRepost { get; set; }
        public BaseLikes Likes { get; set; }
        /// <summary>
        /// Views number
        /// </summary>
        public int? ViewsCount { get; set; }
    }

    public class MarketPrice
    {
        /// <summary>
        /// Amount
        /// </summary>
        public string Amount { get; set; }
        public MarketCurrency Currency { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }
    }

    public class MarketSection
    {
        /// <summary>
        /// Section ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Section name
        /// </summary>
        public string Name { get; set; }
    }

    public class MessagesChat
    {
        /// <summary>
        /// Chat ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Chat type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Chat title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Chat creator ID
        /// </summary>
        public int? AdminId { get; set; }
        public IEnumerable<int?> Users { get; set; }
        public MessagesChatPushSettings PushSettings { get; set; }
        /// <summary>
        /// URL of the preview image with 50 px in width
        /// </summary>
        public string Photo50 { get; set; }
        /// <summary>
        /// URL of the preview image with 100 px in width
        /// </summary>
        public string Photo100 { get; set; }
        /// <summary>
        /// URL of the preview image with 200 px in width
        /// </summary>
        public string Photo200 { get; set; }
        /// <summary>
        /// Shows that user has been left the chat
        /// </summary>
        public bool? Left { get; set; }
        /// <summary>
        /// Shows that user has been kicked from the chat
        /// </summary>
        public bool? Kicked { get; set; }
    }

    public class MessagesChatFull
    {
        /// <summary>
        /// Chat ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Chat type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Chat title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Chat creator ID
        /// </summary>
        public int? AdminId { get; set; }
        public IEnumerable<MessagesUserXtrInvitedBy> Users { get; set; }
        public MessagesChatPushSettings PushSettings { get; set; }
        /// <summary>
        /// URL of the preview image with 50 px in width
        /// </summary>
        public string Photo50 { get; set; }
        /// <summary>
        /// URL of the preview image with 100 px in width
        /// </summary>
        public string Photo100 { get; set; }
        /// <summary>
        /// URL of the preview image with 200 px in width
        /// </summary>
        public string Photo200 { get; set; }
        /// <summary>
        /// Shows that user has been left the chat
        /// </summary>
        public bool? Left { get; set; }
        /// <summary>
        /// Shows that user has been kicked from the chat
        /// </summary>
        public bool? Kicked { get; set; }
    }

    public class MessagesChatPushSettings
    {
        /// <summary>
        /// Information whether the sound is on
        /// </summary>
        public bool? Sound { get; set; }
        /// <summary>
        /// Time until that notifications are disabled
        /// </summary>
        public DateTime? DisabledUntil { get; set; }
    }

    public class MessagesDialog
    {
        /// <summary>
        /// Information whether unread messages are in the dialog
        /// </summary>
        public int? Unread { get; set; }
        public MessagesMessage Message { get; set; }
        /// <summary>
        /// ID of the last message read by current user
        /// </summary>
        public int? InRead { get; set; }
        /// <summary>
        /// ID of the last message read by the others
        /// </summary>
        public int? OutRead { get; set; }
        /// <summary>
        /// Is it an important dialog
        /// </summary>
        public bool? Important { get; set; }
        /// <summary>
        /// Is it an unanswered dialog
        /// </summary>
        public bool? Unanswered { get; set; }
    }

    public class MessagesHistoryAttachment
    {
        /// <summary>
        /// Message ID
        /// </summary>
        public int? MessageId { get; set; }
        public MessagesHistoryMessageAttachment Attachment { get; set; }
    }

    public class MessagesHistoryMessageAttachment
    {
        /// <summary>
        /// Attachments type
        /// </summary>
        public string Type { get; set; }
        public PhotosPhoto Photo { get; set; }
        public VideoVideo Video { get; set; }
        public AudioAudioFull Audio { get; set; }
        public DocsDoc Doc { get; set; }
        public BaseLink Link { get; set; }
        public BaseLink Market { get; set; }
        public BaseLink Wall { get; set; }
        public BaseLink Share { get; set; }
    }

    public class MessagesLastActivity
    {
        /// <summary>
        /// Information whether user is online
        /// </summary>
        public bool? Online { get; set; }
        /// <summary>
        /// Time when user was online in Unixtime
        /// </summary>
        public DateTime? Time { get; set; }
    }

    public class MessagesLongpollMessages
    {
        /// <summary>
        /// Total number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<MessagesMessage> Items { get; set; }
    }

    public class MessagesLongpollParams
    {
        /// <summary>
        /// Key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Server URL
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        public DateTime? Ts { get; set; }
        /// <summary>
        /// Persistent timestamp
        /// </summary>
        public DateTime? Pts { get; set; }
    }

    public class MessagesMessage
    {
        /// <summary>
        /// Message ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Date when the message has been sent in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Information whether the message is outcoming
        /// </summary>
        public bool? Out { get; set; }
        /// <summary>
        /// Message author's ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Message author's ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// ID used for sending messages. It returned only for outgoing messages
        /// </summary>
        public int? RandomId { get; set; }
        /// <summary>
        /// Is it an important message
        /// </summary>
        public bool? Important { get; set; }
        /// <summary>
        /// Is it an deleted message
        /// </summary>
        public bool? Deleted { get; set; }
        /// <summary>
        /// Whether the message contains smiles
        /// </summary>
        public bool? Emoji { get; set; }
        /// <summary>
        /// Forwarded messages
        /// </summary>
        public IEnumerable<MessagesMessage> FwdMessages { get; set; }
        /// <summary>
        /// Information whether the messages is read
        /// </summary>
        public bool? ReadState { get; set; }
        /// <summary>
        /// Message title or chat title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Message text
        /// </summary>
        public string Body { get; set; }
        public IEnumerable<MessagesMessageAttachment> Attachments { get; set; }
        /// <summary>
        /// Chat ID
        /// </summary>
        public int? ChatId { get; set; }
        public IEnumerable<int?> ChatActive { get; set; }
        /// <summary>
        /// Push settings for the chat
        /// </summary>
        public MessagesChatPushSettings PushSettings { get; set; }
        /// <summary>
        /// Action type
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// User or email ID has been invited to the chat or kicked from the chat
        /// </summary>
        public int? ActionMid { get; set; }
        /// <summary>
        /// Email has been invited or kicked
        /// </summary>
        public string ActionEmail { get; set; }
        /// <summary>
        /// Action text
        /// </summary>
        public string ActionText { get; set; }
        /// <summary>
        /// Chat users number
        /// </summary>
        public int? UsersCount { get; set; }
        /// <summary>
        /// Chat administrator ID
        /// </summary>
        public int? AdminId { get; set; }
        /// <summary>
        /// URL of the preview image with 50px in width
        /// </summary>
        public string Photo50 { get; set; }
        /// <summary>
        /// URL of the preview image with 100px in width
        /// </summary>
        public string Photo100 { get; set; }
        /// <summary>
        /// URL of the preview image with 200px in width
        /// </summary>
        public string Photo200 { get; set; }
        public BaseGeo Geo { get; set; }
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
        /// <summary>
        /// Attachment type
        /// </summary>
        public string Type { get; set; }
    }

    public class MessagesUserXtrInvitedBy : UsersUserXtrType
    {
        /// <summary>
        /// ID of the inviter
        /// </summary>
        public int? InvitedBy { get; set; }
    }

    public class NewsfeedItemAudio
    {
        public NewsfeedItemAudioAudio Audio { get; set; }
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
    }

    public class NewsfeedItemAudioAudio
    {
        /// <summary>
        /// Audios number
        /// </summary>
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
        /// <summary>
        /// Notes number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<NewsfeedNewsfeedNote> Items { get; set; }
    }

    public class NewsfeedItemPhoto
    {
        public NewsfeedItemPhotoPhotos Photos { get; set; }
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
    }

    public class NewsfeedItemPhotoPhotos
    {
        /// <summary>
        /// Photos number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<NewsfeedNewsfeedPhoto> Items { get; set; }
    }

    public class NewsfeedItemPhotoTag
    {
        public NewsfeedItemPhotoTagPhotoTags PhotoTags { get; set; }
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
    }

    public class NewsfeedItemPhotoTagPhotoTags
    {
        /// <summary>
        /// Tags number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<NewsfeedNewsfeedPhoto> Items { get; set; }
    }

    public class NewsfeedItemTopic
    {
        /// <summary>
        /// Topic post ID
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Post text
        /// </summary>
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
        /// <summary>
        /// Tags number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<VideoVideo> Items { get; set; }
    }

    public class NewsfeedItemWallpost
    {
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Post type
        /// </summary>
        public string PostType { get; set; }
        /// <summary>
        /// Post text
        /// </summary>
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
        /// <summary>
        /// List ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// List title
        /// </summary>
        public string Title { get; set; }
    }

    public class NewsfeedListFull : NewsfeedList
    {
        /// <summary>
        /// Information whether reposts hiding is enabled
        /// </summary>
        public bool? NoReposts { get; set; }
        public IEnumerable<int?> SourceIds { get; set; }
    }

    public class NewsfeedNewsfeedItem
    {
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Post type
        /// </summary>
        public string PostType { get; set; }
        /// <summary>
        /// Post text
        /// </summary>
        public string Text { get; set; }
        public IEnumerable<WallWallpost> CopyHistory { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
        public WallPostSource PostSource { get; set; }
        public BaseCommentsInfo Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
        public NewsfeedItemPhotoPhotos Photos { get; set; }
        public NewsfeedItemPhotoTagPhotoTags PhotoTags { get; set; }
        public object Friends { get; set; }
        public NewsfeedItemNoteNotes Notes { get; set; }
        public NewsfeedItemAudioAudio Audio { get; set; }
        public NewsfeedItemVideoVideo Video { get; set; }
        public string Type { get; set; }
        public int? SourceId { get; set; }
        public DateTime? Date { get; set; }
        public bool? MarkedAsAds { get; set; }
    }

    public class NewsfeedNewsfeedNote
    {
        /// <summary>
        /// Note ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// integer
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Note title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Comments Number
        /// </summary>
        public int? Comments { get; set; }
    }

    public class NewsfeedNewsfeedPhoto : PhotosPhoto
    {
        public BaseLikes Likes { get; set; }
        public BaseObjectCount Comments { get; set; }
        /// <summary>
        /// Information whether current user can comment the photo
        /// </summary>
        public bool? CanComment { get; set; }
        /// <summary>
        /// Information whether current user can repost the photo
        /// </summary>
        public bool? CanRepost { get; set; }
    }

    public class NotesNote
    {
        /// <summary>
        /// Note ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Note owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Comments number
        /// </summary>
        public int? Comments { get; set; }
        /// <summary>
        /// Information whether current user can comment the note
        /// </summary>
        public bool? CanComment { get; set; }
        /// <summary>
        /// Date when the note has been created in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Note title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Note text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Note text in wiki format
        /// </summary>
        public string TextWiki { get; set; }
        /// <summary>
        /// URL of the page with note preview
        /// </summary>
        public string ViewUrl { get; set; }
    }

    public class NotesNoteComment
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Comment author's ID
        /// </summary>
        public int? Uid { get; set; }
        /// <summary>
        /// Note ID
        /// </summary>
        public int? Nid { get; set; }
        /// <summary>
        /// Note ID
        /// </summary>
        public int? Oid { get; set; }
        /// <summary>
        /// Date when the comment has beed added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// ID of replied comment 
        /// </summary>
        public int? ReplyTo { get; set; }
    }

    public class NotificationsFeedback
    {
        /// <summary>
        /// Item ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Wall owner's ID
        /// </summary>
        public int? ToId { get; set; }
        /// <summary>
        /// Reply author's ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// Reply text
        /// </summary>
        public string Text { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
    }

    public class NotificationsNotification
    {
        /// <summary>
        /// Notification type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Date when the event has been occured
        /// </summary>
        public DateTime? Date { get; set; }
        public string Parent { get; set; }
        public NotificationsFeedback Feedback { get; set; }
        public NotificationsReply Reply { get; set; }
    }

    public class NotificationsNotificationsComment
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Author ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Text { get; set; }
        public PhotosPhoto Photo { get; set; }
        public VideoVideo Video { get; set; }
        public WallWallpost Post { get; set; }
        public BoardTopic Topic { get; set; }
    }

    public class NotificationsReply
    {
        /// <summary>
        /// Reply ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Date when the reply has been created in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Reply text
        /// </summary>
        public int? Text { get; set; }
    }

    public class OauthError
    {
        /// <summary>
        /// Error type
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// Error description
        /// </summary>
        public string ErrorDescription { get; set; }
        /// <summary>
        /// URI for validation
        /// </summary>
        public string RedirectUri { get; set; }
    }

    public class OrdersAmount
    {
        public IEnumerable<OrdersAmountItem> Amounts { get; set; }
        /// <summary>
        /// Currency name
        /// </summary>
        public string Currency { get; set; }
    }

    public class OrdersAmountItem
    {
        /// <summary>
        /// Votes number
        /// </summary>
        public string Votes { get; set; }
        /// <summary>
        /// Votes amount in user's currency
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Amount description
        /// </summary>
        public string Description { get; set; }
    }

    public class OrdersOrder
    {
        /// <summary>
        /// Order ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// App order ID
        /// </summary>
        public int? AppOrderId { get; set; }
        /// <summary>
        /// Order status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Receiver ID
        /// </summary>
        public int? ReceiverId { get; set; }
        /// <summary>
        /// Order item
        /// </summary>
        public string Item { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Date of creation in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TransactionId { get; set; }
        /// <summary>
        /// Cancel transaction ID
        /// </summary>
        public int? CancelTransactionId { get; set; }
    }

    public class PagesWikipage
    {
        /// <summary>
        /// Page ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Community ID
        /// </summary>
        public int? GroupId { get; set; }
        /// <summary>
        /// Page title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// View settings of the page
        /// </summary>
        public int? WhoCanView { get; set; }
        /// <summary>
        /// Edit settings of the page
        /// </summary>
        public int? WhoCanEdit { get; set; }
        /// <summary>
        /// Views number
        /// </summary>
        public int? Views { get; set; }
        /// <summary>
        /// Last editor ID
        /// </summary>
        public int? EditorId { get; set; }
        /// <summary>
        /// Last editor name
        /// </summary>
        public string EditorName { get; set; }
        /// <summary>
        /// Page creator ID
        /// </summary>
        public int? CreatorId { get; set; }
        /// <summary>
        /// Page creator name
        /// </summary>
        public int? CreatorName { get; set; }
    }

    public class PagesWikipageFull
    {
        /// <summary>
        /// Page ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Community ID
        /// </summary>
        public int? GroupId { get; set; }
        /// <summary>
        /// Page title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Information whether current user can edit the page
        /// </summary>
        public bool? CurrentUserCanEdit { get; set; }
        /// <summary>
        /// Information whether current user can edit the page access settings
        /// </summary>
        public bool? CurrentUserCanEditAccess { get; set; }
        /// <summary>
        /// View settings of the page
        /// </summary>
        public int? WhoCanView { get; set; }
        /// <summary>
        /// Edit settings of the page
        /// </summary>
        public int? WhoCanEdit { get; set; }
        /// <summary>
        /// Date when the page has been edited in Unixtime
        /// </summary>
        public DateTime? Edited { get; set; }
        /// <summary>
        /// Date when the page has been created in Unixtime
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// Views number
        /// </summary>
        public int? Views { get; set; }
        /// <summary>
        /// Last editor ID
        /// </summary>
        public int? EditorId { get; set; }
        /// <summary>
        /// Page creator ID
        /// </summary>
        public int? CreatorId { get; set; }
        /// <summary>
        /// Page content, wiki
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// Page content, HTML
        /// </summary>
        public string Html { get; set; }
        /// <summary>
        /// URL of the page preview
        /// </summary>
        public string ViewUrl { get; set; }
    }

    public class PagesWikipageVersion
    {
        /// <summary>
        /// Version ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Page size in bytes
        /// </summary>
        public int? Length { get; set; }
        /// <summary>
        /// Date when the page has been edited in Unixtime
        /// </summary>
        public DateTime? Edited { get; set; }
        /// <summary>
        /// Last editor ID
        /// </summary>
        public int? EditorId { get; set; }
        /// <summary>
        /// Last editor name
        /// </summary>
        public string EditorName { get; set; }
    }

    public class PhotosCommentXtrPid
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Author ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Text { get; set; }
        public BaseLikesInfo Likes { get; set; }
        /// <summary>
        /// Replied user ID
        /// </summary>
        public int? ReplyToUser { get; set; }
        /// <summary>
        /// Replied comment ID
        /// </summary>
        public int? ReplyToComment { get; set; }
        public IEnumerable<WallCommentAttachment> Attachments { get; set; }
        /// <summary>
        /// Photo ID
        /// </summary>
        public int? Pid { get; set; }
    }

    public class PhotosMarketAlbumUploadResponse
    {
        /// <summary>
        /// Community ID
        /// </summary>
        public int? Gid { get; set; }
        /// <summary>
        /// Upload server number
        /// </summary>
        public int? Server { get; set; }
        /// <summary>
        /// Uploaded photo data
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Uploading hash
        /// </summary>
        public string Hash { get; set; }
    }

    public class PhotosMarketUploadResponse
    {
        /// <summary>
        /// Community ID
        /// </summary>
        public int? GroupId { get; set; }
        /// <summary>
        /// Upload server number
        /// </summary>
        public int? Server { get; set; }
        /// <summary>
        /// Uploaded photo data
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Uploading hash
        /// </summary>
        public string Hash { get; set; }
        /// <summary>
        /// Crop data
        /// </summary>
        public string CropData { get; set; }
        /// <summary>
        /// Crop hash
        /// </summary>
        public string CropHash { get; set; }
    }

    public class PhotosMessageUploadResponse
    {
        /// <summary>
        /// Upload server number
        /// </summary>
        public int? Server { get; set; }
        /// <summary>
        /// Uploaded photo data
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Uploading hash
        /// </summary>
        public string Hash { get; set; }
    }

    public class PhotosOwnerUploadResponse
    {
        /// <summary>
        /// Upload server number
        /// </summary>
        public int? Server { get; set; }
        /// <summary>
        /// Uploaded photo data
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Uploading hash
        /// </summary>
        public string Hash { get; set; }
        public int? Mid { get; set; }
        public string MessageCode { get; set; }
        public int? ProfileAid { get; set; }
    }

    public class PhotosPhoto
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Album ID
        /// </summary>
        public int? AlbumId { get; set; }
        /// <summary>
        /// Photo owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// ID of the user who have uploaded the photo
        /// </summary>
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        /// <summary>
        /// URL of image with 75 px width
        /// </summary>
        public string Photo75 { get; set; }
        /// <summary>
        /// URL of image with 130 px width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of image with 604 px width
        /// </summary>
        public string Photo604 { get; set; }
        /// <summary>
        /// URL of image with 807 px width
        /// </summary>
        public string Photo807 { get; set; }
        /// <summary>
        /// URL of image with 1280 px width
        /// </summary>
        public string Photo1280 { get; set; }
        /// <summary>
        /// URL of image with 2560 px width
        /// </summary>
        public string Photo2560 { get; set; }
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Original photo width
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Original photo height
        /// </summary>
        public int? Height { get; set; }
        /// <summary>
        /// Photo caption
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Date when uploaded
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Latitude
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// Longitude
        /// </summary>
        public double? Long { get; set; }
        /// <summary>
        /// Access key for the photo
        /// </summary>
        public string AccessKey { get; set; }
    }

    public class PhotosPhotoAlbum
    {
        /// <summary>
        /// Photo album ID
        /// </summary>
        public int? Id { get; set; }
        public PhotosPhoto Thumb { get; set; }
        /// <summary>
        /// Album owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Photo album title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Photo album description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Date when the album has been created in Unixtime
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// Date when the album has been updated last time in Unixtime
        /// </summary>
        public DateTime? Updated { get; set; }
        /// <summary>
        /// Photos number
        /// </summary>
        public int? Size { get; set; }
    }

    public class PhotosPhotoAlbumFull
    {
        /// <summary>
        /// Photo album ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Thumb photo ID
        /// </summary>
        public int? ThumbId { get; set; }
        /// <summary>
        /// URL of the thumb image
        /// </summary>
        public string ThumbSrc { get; set; }
        /// <summary>
        /// Album owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Photo album title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Photo album description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Date when the album has been created in Unixtime
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// Date when the album has been updated last time in Unixtime
        /// </summary>
        public DateTime? Updated { get; set; }
        /// <summary>
        /// Photos number
        /// </summary>
        public int? Size { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
        /// <summary>
        /// Information whether only community administrators can upload photos
        /// </summary>
        public bool? UploadByAdminsOnly { get; set; }
        /// <summary>
        /// Information whether album comments are disabled
        /// </summary>
        public bool? CommentsDisabled { get; set; }
        /// <summary>
        /// Information whether current user can upload photo to the album
        /// </summary>
        public bool? CanUpload { get; set; }
        /// <summary>
        /// Information whether the album thumb is last photo
        /// </summary>
        public bool? ThumbIsLast { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
    }

    public class PhotosPhotoFull
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Album ID
        /// </summary>
        public int? AlbumId { get; set; }
        /// <summary>
        /// Photo owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// ID of the user who have uploaded the photo
        /// </summary>
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        /// <summary>
        /// URL of image with 75 px width
        /// </summary>
        public string Photo75 { get; set; }
        /// <summary>
        /// URL of image with 130 px width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of image with 604 px width
        /// </summary>
        public string Photo604 { get; set; }
        /// <summary>
        /// URL of image with 807 px width
        /// </summary>
        public string Photo807 { get; set; }
        /// <summary>
        /// URL of image with 1280 px width
        /// </summary>
        public string Photo1280 { get; set; }
        /// <summary>
        /// URL of image with 2560 px width
        /// </summary>
        public string Photo2560 { get; set; }
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Original photo width
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Original photo height
        /// </summary>
        public int? Height { get; set; }
        /// <summary>
        /// Photo caption
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Date when uploaded
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Latitude
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// Longitude
        /// </summary>
        public double? Long { get; set; }
        /// <summary>
        /// Access key for the photo
        /// </summary>
        public string AccessKey { get; set; }
        public BaseLikes Likes { get; set; }
        public BaseObjectCount Reposts { get; set; }
        public BaseObjectCount Comments { get; set; }
        /// <summary>
        /// Information whether current user can comment the photo
        /// </summary>
        public bool? CanComment { get; set; }
        public BaseObjectCount Tags { get; set; }
    }

    public class PhotosPhotoFullXtrRealOffset
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Album ID
        /// </summary>
        public int? AlbumId { get; set; }
        /// <summary>
        /// Photo owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// ID of the user who have uploaded the photo
        /// </summary>
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        /// <summary>
        /// URL of image with 75 px width
        /// </summary>
        public string Photo75 { get; set; }
        /// <summary>
        /// URL of image with 130 px width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of image with 604 px width
        /// </summary>
        public string Photo604 { get; set; }
        /// <summary>
        /// URL of image with 807 px width
        /// </summary>
        public string Photo807 { get; set; }
        /// <summary>
        /// URL of image with 1280 px width
        /// </summary>
        public string Photo1280 { get; set; }
        /// <summary>
        /// URL of image with 2560 px width
        /// </summary>
        public string Photo2560 { get; set; }
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Original photo width
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Original photo height
        /// </summary>
        public int? Height { get; set; }
        /// <summary>
        /// Photo caption
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Date when uploaded
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Latitude
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// Longitude
        /// </summary>
        public double? Long { get; set; }
        /// <summary>
        /// Access key for the photo
        /// </summary>
        public string AccessKey { get; set; }
        public BaseLikes Likes { get; set; }
        public BaseObjectCount Reposts { get; set; }
        public BaseObjectCount Comments { get; set; }
        public bool? CanComment { get; set; }
        public BaseObjectCount Tags { get; set; }
        /// <summary>
        /// Returns if the photo is hidden above the wall
        /// </summary>
        public bool? Hidden { get; set; }
        /// <summary>
        /// Real position of the photo
        /// </summary>
        public int? RealOffset { get; set; }
    }

    public class PhotosPhotoSizes
    {
        /// <summary>
        /// URL of the image
        /// </summary>
        public string Src { get; set; }
        /// <summary>
        /// Width in px
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Height in px
        /// </summary>
        public int? Height { get; set; }
        /// <summary>
        /// Size type
        /// </summary>
        public string Type { get; set; }
    }

    public class PhotosPhotoTag
    {
        /// <summary>
        /// Tagged user ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Tag ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// ID of the tag creator
        /// </summary>
        public int? PlacerId { get; set; }
        /// <summary>
        /// Tag description
        /// </summary>
        public string TaggedName { get; set; }
        /// <summary>
        /// Date when tag has been added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Coordinate X of the left upper corner
        /// </summary>
        public double? X { get; set; }
        /// <summary>
        /// Coordinate Y of the left upper corner
        /// </summary>
        public double? Y { get; set; }
        /// <summary>
        /// Coordinate X of the right lower corner
        /// </summary>
        public double? X2 { get; set; }
        /// <summary>
        /// Coordinate Y of the right lower corner
        /// </summary>
        public double? Y2 { get; set; }
        /// <summary>
        /// Information whether the tag is reviewed
        /// </summary>
        public bool? Viewed { get; set; }
    }

    public class PhotosPhotoUpload
    {
        /// <summary>
        /// URL to upload photo
        /// </summary>
        public string UploadUrl { get; set; }
        /// <summary>
        /// Album ID
        /// </summary>
        public int? AlbumId { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
    }

    public class PhotosPhotoUploadResponse
    {
        /// <summary>
        /// Upload server number
        /// </summary>
        public int? Server { get; set; }
        /// <summary>
        /// Uploaded photos data
        /// </summary>
        public string PhotosList { get; set; }
        /// <summary>
        /// Album ID
        /// </summary>
        public int? Aid { get; set; }
        /// <summary>
        /// Uploading hash
        /// </summary>
        public string Hash { get; set; }
    }

    public class PhotosPhotoXtrRealOffset
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Album ID
        /// </summary>
        public int? AlbumId { get; set; }
        /// <summary>
        /// Photo owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// ID of the user who have uploaded the photo
        /// </summary>
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        /// <summary>
        /// URL of image with 75 px width
        /// </summary>
        public string Photo75 { get; set; }
        /// <summary>
        /// URL of image with 130 px width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of image with 604 px width
        /// </summary>
        public string Photo604 { get; set; }
        /// <summary>
        /// URL of image with 807 px width
        /// </summary>
        public string Photo807 { get; set; }
        /// <summary>
        /// URL of image with 1280 px width
        /// </summary>
        public string Photo1280 { get; set; }
        /// <summary>
        /// URL of image with 2560 px width
        /// </summary>
        public string Photo2560 { get; set; }
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Original photo width
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Original photo height
        /// </summary>
        public int? Height { get; set; }
        /// <summary>
        /// Photo caption
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Date when uploaded
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Latitude
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// Longitude
        /// </summary>
        public double? Long { get; set; }
        /// <summary>
        /// Access key for the photo
        /// </summary>
        public string AccessKey { get; set; }
        /// <summary>
        /// Returns if the photo is hidden above the wall
        /// </summary>
        public bool? Hidden { get; set; }
        /// <summary>
        /// Real position of the photo
        /// </summary>
        public int? RealOffset { get; set; }
    }

    public class PhotosPhotoXtrTagInfo
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Album ID
        /// </summary>
        public int? AlbumId { get; set; }
        /// <summary>
        /// Photo owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// ID of the user who have uploaded the photo
        /// </summary>
        public int? UserId { get; set; }
        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; }
        /// <summary>
        /// URL of image with 75 px width
        /// </summary>
        public string Photo75 { get; set; }
        /// <summary>
        /// URL of image with 130 px width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of image with 604 px width
        /// </summary>
        public string Photo604 { get; set; }
        /// <summary>
        /// URL of image with 807 px width
        /// </summary>
        public string Photo807 { get; set; }
        /// <summary>
        /// URL of image with 1280 px width
        /// </summary>
        public string Photo1280 { get; set; }
        /// <summary>
        /// URL of image with 2560 px width
        /// </summary>
        public string Photo2560 { get; set; }
        /// <summary>
        /// Post ID
        /// </summary>
        public int? PostId { get; set; }
        /// <summary>
        /// Original photo width
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Original photo height
        /// </summary>
        public int? Height { get; set; }
        /// <summary>
        /// Photo caption
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Date when uploaded
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Latitude
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// Longitude
        /// </summary>
        public double? Long { get; set; }
        /// <summary>
        /// Access key for the photo
        /// </summary>
        public string AccessKey { get; set; }
        /// <summary>
        /// ID of the tag creator
        /// </summary>
        public int? PlacerId { get; set; }
        /// <summary>
        /// Date when tag has been added in Unixtime
        /// </summary>
        public DateTime? TagCreated { get; set; }
        /// <summary>
        /// Tag ID
        /// </summary>
        public int? TagId { get; set; }
    }

    public class PhotosWallUploadResponse
    {
        /// <summary>
        /// Upload server number
        /// </summary>
        public int? Server { get; set; }
        /// <summary>
        /// Uploaded photo data
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Uploading hash
        /// </summary>
        public string Hash { get; set; }
    }

    public class PlacesCheckin
    {
        /// <summary>
        /// Checkin ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Date when the checkin has been added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Place latitude
        /// </summary>
        public double? Latitude { get; set; }
        /// <summary>
        /// Place longitude
        /// </summary>
        public double? Longitude { get; set; }
        /// <summary>
        /// Place ID
        /// </summary>
        public int? PlaceId { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Distance to the place
        /// </summary>
        public int? Distance { get; set; }
        /// <summary>
        /// Place title
        /// </summary>
        public string PlaceTitle { get; set; }
        /// <summary>
        /// Country ID
        /// </summary>
        public int? PlaceCountry { get; set; }
        /// <summary>
        /// City ID
        /// </summary>
        public int? PlaceCity { get; set; }
        /// <summary>
        /// Place type
        /// </summary>
        public string PlaceType { get; set; }
        /// <summary>
        /// URL of the place's icon
        /// </summary>
        public string PlaceIcon { get; set; }
    }

    public class PlacesPlaceFull
    {
        /// <summary>
        /// Place ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Place title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Place latitude
        /// </summary>
        public double? Latitude { get; set; }
        /// <summary>
        /// Place longitude
        /// </summary>
        public double? Longitude { get; set; }
        /// <summary>
        /// Date of the place creation in Unixtime
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// URL of the place's icon
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// Checkins number
        /// </summary>
        public int? Checkins { get; set; }
        /// <summary>
        /// Place type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Country ID
        /// </summary>
        public int? Country { get; set; }
        /// <summary>
        /// City ID
        /// </summary>
        public int? City { get; set; }
        /// <summary>
        /// Place address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Distance to the place
        /// </summary>
        public int? Distance { get; set; }
        /// <summary>
        /// Community ID
        /// </summary>
        public int? GroupId { get; set; }
        /// <summary>
        /// URL of the community's photo
        /// </summary>
        public string GroupPhoto { get; set; }
    }

    public class PlacesPlaceMin
    {
        /// <summary>
        /// Place ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Place title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Place latitude
        /// </summary>
        public double? Latitude { get; set; }
        /// <summary>
        /// Place longitude
        /// </summary>
        public double? Longitude { get; set; }
        /// <summary>
        /// Date of the place creation in Unixtime
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// URL of the place's icon
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// Checkins number
        /// </summary>
        public int? Checkins { get; set; }
        /// <summary>
        /// Place type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Country ID
        /// </summary>
        public int? Country { get; set; }
        /// <summary>
        /// City ID
        /// </summary>
        public int? City { get; set; }
        /// <summary>
        /// Place address
        /// </summary>
        public string Address { get; set; }
    }

    public class PlacesTypes
    {
        /// <summary>
        /// Place type ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Place type title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// URL of the place's icon
        /// </summary>
        public string Icon { get; set; }
    }

    public class PollsAnswer
    {
        /// <summary>
        /// Answer ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Answer text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Votes number
        /// </summary>
        public int? Votes { get; set; }
        /// <summary>
        /// Answer rate in percents
        /// </summary>
        public double? Rate { get; set; }
    }

    public class PollsPoll
    {
        /// <summary>
        /// Poll ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Poll owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Date when poll has been created in Unixtime
        /// </summary>
        public DateTime? Created { get; set; }
        /// <summary>
        /// Poll question
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// Votes number
        /// </summary>
        public string Votes { get; set; }
        /// <summary>
        /// Current user's answer ID
        /// </summary>
        public int? AnswerId { get; set; }
        public IEnumerable<PollsAnswer> Answers { get; set; }
        /// <summary>
        /// Information whether the pole is anonymous
        /// </summary>
        public bool? Anonymous { get; set; }
    }

    public class PollsVoters
    {
        /// <summary>
        /// Answer ID
        /// </summary>
        public int? AnswerId { get; set; }
        public PollsVotersUsers Users { get; set; }
    }

    public class PollsVotersUsers
    {
        /// <summary>
        /// Votes number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class SearchHint
    {
        /// <summary>
        /// Object type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Section title
        /// </summary>
        public string Section { get; set; }
        /// <summary>
        /// Object description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Information whether the object has been found globally
        /// </summary>
        public bool? Global { get; set; }
        public GroupsGroup Group { get; set; }
        public UsersUserMin Profile { get; set; }
    }

    public class SecureLevel
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? Uid { get; set; }
        /// <summary>
        /// Level
        /// </summary>
        public int? Level { get; set; }
    }

    public class SecureSmsNotification
    {
        /// <summary>
        /// Notification ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Application ID
        /// </summary>
        public int? AppId { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Date when message has been sent in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Messsage text
        /// </summary>
        public string Message { get; set; }
    }

    public class SecureTokenChecked
    {
        /// <summary>
        /// Returns if successfully processed
        /// </summary>
        public bool? Success { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Date when access_token has been generated in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Date when access_token will expire in Unixtime
        /// </summary>
        public DateTime? Expire { get; set; }
    }

    public class SecureTransaction
    {
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// From ID
        /// </summary>
        public int? UidFrom { get; set; }
        /// <summary>
        /// To ID
        /// </summary>
        public int? UidTo { get; set; }
        /// <summary>
        /// Votes number
        /// </summary>
        public int? Votes { get; set; }
        /// <summary>
        /// Transaction date in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
    }

    public class StatsAge
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        public int? Visitors { get; set; }
        /// <summary>
        /// Age interval
        /// </summary>
        public string Value { get; set; }
    }

    public class StatsCity
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        public int? Visitors { get; set; }
        /// <summary>
        /// City ID
        /// </summary>
        public int? Value { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        public string Name { get; set; }
    }

    public class StatsCountry
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        public int? Visitors { get; set; }
        /// <summary>
        /// Country ID
        /// </summary>
        public int? Value { get; set; }
        /// <summary>
        /// Country code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Country name
        /// </summary>
        public string Name { get; set; }
    }

    public class StatsPeriod
    {
        /// <summary>
        /// Day (YYYY-MM-DD)
        /// </summary>
        public string Day { get; set; }
        /// <summary>
        /// Views number
        /// </summary>
        public int? Views { get; set; }
        /// <summary>
        /// Visitors number
        /// </summary>
        public int? Visitors { get; set; }
        /// <summary>
        /// Total reach
        /// </summary>
        public int? Reach { get; set; }
        /// <summary>
        /// Subscribers reach
        /// </summary>
        public int? ReachSubscribers { get; set; }
        /// <summary>
        /// Number of users subscribed
        /// </summary>
        public int? Subscribed { get; set; }
        /// <summary>
        /// Number of users unsubscribed
        /// </summary>
        public int? Unsubscribed { get; set; }
        public IEnumerable<StatsSex> Sex { get; set; }
        public IEnumerable<StatsAge> Age { get; set; }
        public IEnumerable<StatsSexAge> SexAge { get; set; }
        public IEnumerable<StatsCity> Cities { get; set; }
        public IEnumerable<StatsCountry> Countries { get; set; }
    }

    public class StatsSex
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        public int? Visitors { get; set; }
        /// <summary>
        /// Sex
        /// </summary>
        public string Value { get; set; }
    }

    public class StatsSexAge
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        public int? Visitors { get; set; }
        /// <summary>
        /// Sex and age interval
        /// </summary>
        public string Value { get; set; }
    }

    public class StatsWallpostStat
    {
        /// <summary>
        /// Subscribers reach
        /// </summary>
        public int? ReachSubscribers { get; set; }
        /// <summary>
        /// Total reach
        /// </summary>
        public int? ReachTotal { get; set; }
        /// <summary>
        /// Link clickthrough
        /// </summary>
        public int? Links { get; set; }
        /// <summary>
        /// Clickthrough to community
        /// </summary>
        public int? ToGroup { get; set; }
        /// <summary>
        /// People have joined the group
        /// </summary>
        public int? JoinGroup { get; set; }
        /// <summary>
        /// Reports number
        /// </summary>
        public int? Report { get; set; }
        /// <summary>
        /// Hidings number
        /// </summary>
        public int? Hide { get; set; }
        /// <summary>
        /// Unsubscribed members
        /// </summary>
        public int? Unsubscribe { get; set; }
    }

    public class StatusStatus
    {
        /// <summary>
        /// Status text
        /// </summary>
        public string Text { get; set; }
        public AudioAudioFull Audio { get; set; }
    }

    public class UsersCareer
    {
        /// <summary>
        /// Community ID
        /// </summary>
        public int? GroupId { get; set; }
        /// <summary>
        /// Company name
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// Country ID
        /// </summary>
        public int? CountryId { get; set; }
        /// <summary>
        /// City ID
        /// </summary>
        public int? CityId { get; set; }
        /// <summary>
        /// From year
        /// </summary>
        public int? From { get; set; }
        /// <summary>
        /// Till year
        /// </summary>
        public int? Until { get; set; }
        /// <summary>
        /// Position
        /// </summary>
        public string Position { get; set; }
    }

    public class UsersCropPhoto
    {
        public PhotosPhoto Photo { get; set; }
        public UsersCropPhotoCrop Crop { get; set; }
        public UsersCropPhotoRect Rect { get; set; }
    }

    public class UsersCropPhotoCrop
    {
        /// <summary>
        /// Coordinate X of the left upper corner
        /// </summary>
        public double? X { get; set; }
        /// <summary>
        /// Coordinate Y of the left upper corner
        /// </summary>
        public double? Y { get; set; }
        /// <summary>
        /// Coordinate X of the right lower corner
        /// </summary>
        public double? X2 { get; set; }
        /// <summary>
        /// Coordinate Y of the right lower corner
        /// </summary>
        public double? Y2 { get; set; }
    }

    public class UsersCropPhotoRect
    {
        /// <summary>
        /// Coordinate X of the left upper corner
        /// </summary>
        public double? X { get; set; }
        /// <summary>
        /// Coordinate Y of the left upper corner
        /// </summary>
        public double? Y { get; set; }
        /// <summary>
        /// Coordinate X of the right lower corner
        /// </summary>
        public double? X2 { get; set; }
        /// <summary>
        /// Coordinate Y of the right lower corner
        /// </summary>
        public double? Y2 { get; set; }
    }

    public class UsersExports
    {
        public int? Twitter { get; set; }
        public int? Facebook { get; set; }
        public int? Livejournal { get; set; }
    }

    public class UsersLastSeen
    {
        /// <summary>
        /// Last visit date (in Unix time)
        /// </summary>
        public DateTime? Time { get; set; }
        /// <summary>
        /// Type of the platform that used for the last authorization
        /// </summary>
        public int? Platform { get; set; }
    }

    public class UsersMilitary
    {
        /// <summary>
        /// Unit name
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// Unit ID
        /// </summary>
        public int? UnitId { get; set; }
        /// <summary>
        /// Country ID
        /// </summary>
        public int? CountryId { get; set; }
        /// <summary>
        /// From year
        /// </summary>
        public int? From { get; set; }
        /// <summary>
        /// Till year
        /// </summary>
        public int? Until { get; set; }
    }

    public class UsersOccupation
    {
        /// <summary>
        /// Type of occupation
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// ID of school, university, company group
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Name of occupation
        /// </summary>
        public string Name { get; set; }
    }

    public class UsersPersonal
    {
        /// <summary>
        /// User's political views
        /// </summary>
        public int? Political { get; set; }
        public IEnumerable<string> Langs { get; set; }
        /// <summary>
        /// User's religion
        /// </summary>
        public string Religion { get; set; }
        /// <summary>
        /// User's inspired by
        /// </summary>
        public string InspiredBy { get; set; }
        /// <summary>
        /// User's personal priority in people
        /// </summary>
        public int? PeopleMain { get; set; }
        /// <summary>
        /// User's personal priority in life
        /// </summary>
        public int? LifeMain { get; set; }
        /// <summary>
        /// User's views on smoking
        /// </summary>
        public int? Smoking { get; set; }
        /// <summary>
        /// User's views on alcohol
        /// </summary>
        public int? Alcohol { get; set; }
    }

    public class UsersRelative
    {
        /// <summary>
        /// Relative ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Relative type
        /// </summary>
        public string Type { get; set; }
    }

    public class UsersSchool
    {
        /// <summary>
        /// School ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Country ID
        /// </summary>
        public int? Country { get; set; }
        /// <summary>
        /// City ID
        /// </summary>
        public int? City { get; set; }
        /// <summary>
        /// School name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Year the user started to study
        /// </summary>
        public int? YearFrom { get; set; }
        /// <summary>
        /// Year the user finished to study
        /// </summary>
        public int? YearTo { get; set; }
        /// <summary>
        /// Graduation year
        /// </summary>
        public int? YearGraduated { get; set; }
        /// <summary>
        /// School class letter
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// School type ID
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// School type name
        /// </summary>
        public string TypeStr { get; set; }
    }

    public class UsersUniversity
    {
        /// <summary>
        /// University ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Country ID
        /// </summary>
        public int? Country { get; set; }
        /// <summary>
        /// City ID
        /// </summary>
        public int? City { get; set; }
        /// <summary>
        /// University name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Faculty ID
        /// </summary>
        public int? Faculty { get; set; }
        /// <summary>
        /// Faculty name
        /// </summary>
        public string FacultyName { get; set; }
        /// <summary>
        /// Chair ID
        /// </summary>
        public int? Chair { get; set; }
        /// <summary>
        /// Chair name
        /// </summary>
        public string ChairName { get; set; }
        /// <summary>
        /// Graduation year
        /// </summary>
        public int? Graduation { get; set; }
        /// <summary>
        /// Education form
        /// </summary>
        public string EducationForm { get; set; }
        /// <summary>
        /// Education status
        /// </summary>
        public string EducationStatus { get; set; }
    }

    public class UsersUser : UsersUserMin
    {
        /// <summary>
        /// User sex
        /// </summary>
        public int? Sex { get; set; }
        /// <summary>
        /// Domain name of the user's page
        /// </summary>
        public string ScreenName { get; set; }
        /// <summary>
        /// URL of square photo of the user with 50 pixels in width
        /// </summary>
        public string Photo50 { get; set; }
        /// <summary>
        /// URL of square photo of the user with 100 pixels in width
        /// </summary>
        public string Photo100 { get; set; }
        /// <summary>
        /// Information whether the user is online
        /// </summary>
        public bool? Online { get; set; }
        /// <summary>
        /// Information whether the user is online in mobile site or application
        /// </summary>
        public bool? OnlineMobile { get; set; }
        /// <summary>
        /// Application ID
        /// </summary>
        public int? OnlineApp { get; set; }
    }

    public class UsersUserBroadcast : UsersUserMin
    {
        public AudioAudioFull StatusAudio { get; set; }
    }

    public class UsersUserCounters
    {
        /// <summary>
        /// Albums number
        /// </summary>
        public int? Albums { get; set; }
        /// <summary>
        /// Videos number
        /// </summary>
        public int? Videos { get; set; }
        /// <summary>
        /// Audios number
        /// </summary>
        public int? Audios { get; set; }
        /// <summary>
        /// Notes number
        /// </summary>
        public int? Notes { get; set; }
        /// <summary>
        /// Photos number
        /// </summary>
        public int? Photos { get; set; }
        /// <summary>
        /// Communities number
        /// </summary>
        public int? Groups { get; set; }
        /// <summary>
        /// Gifts number
        /// </summary>
        public int? Gifts { get; set; }
        /// <summary>
        /// Friends number
        /// </summary>
        public int? Friends { get; set; }
        /// <summary>
        /// Online friends number
        /// </summary>
        public int? OnlineFriends { get; set; }
        /// <summary>
        /// Number of photos with user
        /// </summary>
        public int? UserPhotos { get; set; }
        /// <summary>
        /// Number of videos with user
        /// </summary>
        public int? UserVideos { get; set; }
        /// <summary>
        /// Followers number
        /// </summary>
        public int? Followers { get; set; }
        /// <summary>
        /// Subscriptions number
        /// </summary>
        public int? Subscriptions { get; set; }
        /// <summary>
        /// Public pages number
        /// </summary>
        public int? Pages { get; set; }
    }

    public class UsersUserFull : UsersUser
    {
        /// <summary>
        /// User nickname
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// User maiden name
        /// </summary>
        public string MaidenName { get; set; }
        /// <summary>
        /// Domain name of the user's page
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// User's date of birth
        /// </summary>
        public string Bdate { get; set; }
        public BaseObject City { get; set; }
        public BaseCountry Country { get; set; }
        /// <summary>
        /// User's timezone
        /// </summary>
        public int? Timezone { get; set; }
        /// <summary>
        /// URL of square photo of the user with 200 pixels in width
        /// </summary>
        public string Photo200 { get; set; }
        /// <summary>
        /// URL of square photo of the user with maximum width
        /// </summary>
        public string PhotoMax { get; set; }
        /// <summary>
        /// URL of user's photo with 200 pixels in width
        /// </summary>
        public string Photo200Orig { get; set; }
        /// <summary>
        /// URL of user's photo with 400 pixels in width
        /// </summary>
        public string Photo400Orig { get; set; }
        /// <summary>
        /// URL of user's photo of maximum size
        /// </summary>
        public string PhotoMaxOrig { get; set; }
        /// <summary>
        /// ID of the user's main photo
        /// </summary>
        public string PhotoId { get; set; }
        /// <summary>
        /// Information whether the user has main photo
        /// </summary>
        public int? HasPhoto { get; set; }
        /// <summary>
        /// Information whether the user specified his phone number
        /// </summary>
        public bool? HasMobile { get; set; }
        /// <summary>
        /// Information whether the user is a friend of current user
        /// </summary>
        public bool? IsFriend { get; set; }
        /// <summary>
        /// Friend status for current user
        /// </summary>
        public int? FriendStatus { get; set; }
        /// <summary>
        /// Information whether current user can comment wall posts
        /// </summary>
        public bool? WallComments { get; set; }
        /// <summary>
        /// Information whether current user can post on the user's wall
        /// </summary>
        public bool? CanPost { get; set; }
        /// <summary>
        /// Information whether current user can see other users' audio on the wall
        /// </summary>
        public bool? CanSeeAllPosts { get; set; }
        /// <summary>
        /// Information whether current user can see the user's audio
        /// </summary>
        public bool? CanSeeAudio { get; set; }
        /// <summary>
        /// Information whether current user can write private message
        /// </summary>
        public bool? CanWritePrivateMessage { get; set; }
        /// <summary>
        /// Information whether current user can send a friend request
        /// </summary>
        public bool? CanSendFriendRequest { get; set; }
        /// <summary>
        /// Information whether current user can see
        /// </summary>
        public string MobilePhone { get; set; }
        /// <summary>
        /// User's mobile phone number
        /// </summary>
        public string HomePhone { get; set; }
        /// <summary>
        /// User's Skype nickname
        /// </summary>
        public string Skype { get; set; }
        /// <summary>
        /// User's Facebook account
        /// </summary>
        public string Facebook { get; set; }
        /// <summary>
        /// User's Facebook name
        /// </summary>
        public string FacebookName { get; set; }
        /// <summary>
        /// User's Twitter account
        /// </summary>
        public string Twitter { get; set; }
        /// <summary>
        /// User's Livejournal account
        /// </summary>
        public string Livejournal { get; set; }
        /// <summary>
        /// User's Instagram account
        /// </summary>
        public string Instagram { get; set; }
        /// <summary>
        /// User's website
        /// </summary>
        public string Site { get; set; }
        public AudioAudioFull StatusAudio { get; set; }
        /// <summary>
        /// User's status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// User's status
        /// </summary>
        public string Activity { get; set; }
        public UsersLastSeen LastSeen { get; set; }
        public UsersExports Exports { get; set; }
        public UsersCropPhoto CropPhoto { get; set; }
        /// <summary>
        /// Information whether the user is verified
        /// </summary>
        public bool? Verified { get; set; }
        /// <summary>
        /// Number of user's followers
        /// </summary>
        public int? FollowersCount { get; set; }
        /// <summary>
        /// Information whether current user is in the requested user's blacklist.
        /// </summary>
        public bool? Blacklisted { get; set; }
        /// <summary>
        /// Information whether the requested user is in current user's blacklist
        /// </summary>
        public bool? BlacklistedByMe { get; set; }
        /// <summary>
        /// Information whether the requested user is in faves of current user
        /// </summary>
        public bool? IsFavorite { get; set; }
        /// <summary>
        /// Information whether the requested user is hidden from current user's newsfeed
        /// </summary>
        public bool? IsHiddenFromFeed { get; set; }
        /// <summary>
        /// Number of common friends with current user
        /// </summary>
        public int? CommonCount { get; set; }
        public UsersOccupation Occupation { get; set; }
        public IEnumerable<UsersCareer> Career { get; set; }
        public IEnumerable<UsersMilitary> Military { get; set; }
        /// <summary>
        /// University ID
        /// </summary>
        public int? University { get; set; }
        /// <summary>
        /// University name
        /// </summary>
        public string UniversityName { get; set; }
        /// <summary>
        /// Faculty ID
        /// </summary>
        public int? Faculty { get; set; }
        /// <summary>
        /// Faculty name
        /// </summary>
        public string FacultyName { get; set; }
        /// <summary>
        /// Graduation year
        /// </summary>
        public int? Graduation { get; set; }
        /// <summary>
        /// Education form
        /// </summary>
        public string EducationForm { get; set; }
        /// <summary>
        /// User's education status
        /// </summary>
        public string EducationStatus { get; set; }
        /// <summary>
        /// User hometown
        /// </summary>
        public string HomeTown { get; set; }
        /// <summary>
        /// User relationship status
        /// </summary>
        public int? Relation { get; set; }
        public UsersUserMin RelationPartner { get; set; }
        public UsersPersonal Personal { get; set; }
        /// <summary>
        /// User's interests
        /// </summary>
        public string Interests { get; set; }
        /// <summary>
        /// User's favorite music
        /// </summary>
        public string Music { get; set; }
        /// <summary>
        /// User's activities
        /// </summary>
        public string Activities { get; set; }
        /// <summary>
        /// User's favorite movies
        /// </summary>
        public string Movies { get; set; }
        /// <summary>
        /// User's favorite tv shows
        /// </summary>
        public string Tv { get; set; }
        /// <summary>
        /// User's favorite books
        /// </summary>
        public string Books { get; set; }
        /// <summary>
        /// User's favorite games
        /// </summary>
        public string Games { get; set; }
        public IEnumerable<UsersUniversity> Universities { get; set; }
        public IEnumerable<UsersSchool> Schools { get; set; }
        /// <summary>
        /// About me field
        /// </summary>
        public string About { get; set; }
        public IEnumerable<UsersRelative> Relatives { get; set; }
        /// <summary>
        /// Favorite quotes
        /// </summary>
        public string Quotes { get; set; }
    }

    public class UsersUserFullXtrType : UsersUserFull
    {
        /// <summary>
        /// Object type
        /// </summary>
        public string Type { get; set; }
    }

    public class UsersUserLim
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// URL of square photo of the user with 50 pixels in width
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// User name and last name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// User name in genitive declension
        /// </summary>
        public string NameGen { get; set; }
    }

    public class UsersUserMin
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// User first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// User last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Returns if a profile is deleted or blocked
        /// </summary>
        public string Deactivated { get; set; }
        /// <summary>
        /// Returns if a profile is hidden.
        /// </summary>
        public int? Hidden { get; set; }
    }

    public class UsersUserXtrCounters : UsersUserFull
    {
        public UsersUserCounters Counters { get; set; }
    }

    public class UsersUserXtrType : UsersUser
    {
        /// <summary>
        /// Object type
        /// </summary>
        public string Type { get; set; }
    }

    public class UsersUsersArray
    {
        /// <summary>
        /// Users number
        /// </summary>
        public int? Count { get; set; }
        public IEnumerable<int?> Items { get; set; }
    }

    public class UtilsDomainResolved
    {
        /// <summary>
        /// Object type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Object ID
        /// </summary>
        public int? ObjectId { get; set; }
    }

    public class UtilsLastShortenedLink
    {
        /// <summary>
        /// Creation time in Unixtime
        /// </summary>
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Full URL
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Short link URL
        /// </summary>
        public string ShortUrl { get; set; }
        /// <summary>
        /// Link key (characters after vk.cc/)
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Total views number
        /// </summary>
        public int? Views { get; set; }
        /// <summary>
        /// Access key for private stats
        /// </summary>
        public string AccessKey { get; set; }
    }

    public class UtilsLinkChecked
    {
        /// <summary>
        /// Link status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Link URL
        /// </summary>
        public string Link { get; set; }
    }

    public class UtilsLinkStats
    {
        /// <summary>
        /// Link key (characters after vk.cc/)
        /// </summary>
        public string Key { get; set; }
        public IEnumerable<UtilsStats> Stats { get; set; }
    }

    public class UtilsLinkStatsExtended
    {
        /// <summary>
        /// Link key (characters after vk.cc/)
        /// </summary>
        public string Key { get; set; }
        public IEnumerable<UtilsStatsExtended> Stats { get; set; }
    }

    public class UtilsShortLink
    {
        /// <summary>
        /// Short link URL
        /// </summary>
        public string ShortUrl { get; set; }
        /// <summary>
        /// Access key for private stats
        /// </summary>
        public string AccessKey { get; set; }
        /// <summary>
        /// Link key (characters after vk.cc/)
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Full URL
        /// </summary>
        public string Url { get; set; }
    }

    public class UtilsStats
    {
        /// <summary>
        /// Start time
        /// </summary>
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Total views number
        /// </summary>
        public int? Views { get; set; }
    }

    public class UtilsStatsCity
    {
        /// <summary>
        /// City ID
        /// </summary>
        public int? CityId { get; set; }
        /// <summary>
        /// Views number
        /// </summary>
        public int? Views { get; set; }
    }

    public class UtilsStatsCountry
    {
        /// <summary>
        /// Country ID
        /// </summary>
        public int? CountryId { get; set; }
        /// <summary>
        /// Views number
        /// </summary>
        public int? Views { get; set; }
    }

    public class UtilsStatsExtended
    {
        /// <summary>
        /// Start time
        /// </summary>
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Total views number
        /// </summary>
        public int? Views { get; set; }
        public IEnumerable<UtilsStatsSexAge> SexAge { get; set; }
        public IEnumerable<UtilsStatsCountry> Countries { get; set; }
        public IEnumerable<UtilsStatsCity> Cities { get; set; }
    }

    public class UtilsStatsSexAge
    {
        /// <summary>
        /// Age denotation
        /// </summary>
        public string AgeRange { get; set; }
        /// <summary>
        ///  Views by female users
        /// </summary>
        public int? Female { get; set; }
        /// <summary>
        ///  Views by male users
        /// </summary>
        public int? Male { get; set; }
    }

    public class VideoCatBlock
    {
        public IEnumerable<VideoCatElement> Items { get; set; }
        /// <summary>
        /// New value for _from_ parameter
        /// </summary>
        public string Next { get; set; }
        /// <summary>
        /// Block name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Block ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Type of view
        /// </summary>
        public string View { get; set; }
        /// <summary>
        /// Information whether the block can be hidden
        /// </summary>
        public bool? CanHide { get; set; }
        /// <summary>
        /// Block type
        /// </summary>
        public string Type { get; set; }
    }

    public class VideoCatElement
    {
        /// <summary>
        /// Element ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Element owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Element title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Element type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Element description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Duration in seconds
        /// </summary>
        public int? Duration { get; set; }
        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of the preview image with 160 px in width
        /// </summary>
        public string Photo160 { get; set; }
        /// <summary>
        /// URL of the preview image with 320 px in width
        /// </summary>
        public string Photo320 { get; set; }
        /// <summary>
        /// URL of the preview image with 640 px in width
        /// </summary>
        public string Photo640 { get; set; }
        /// <summary>
        /// URL of the preview image with 800 px in width
        /// </summary>
        public string Photo800 { get; set; }
        /// <summary>
        /// Date when the element has been created
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Views number
        /// </summary>
        public int? Views { get; set; }
        /// <summary>
        /// Comments number
        /// </summary>
        public int? Comments { get; set; }
        /// <summary>
        /// Information whether current user can add the video
        /// </summary>
        public int? CanAdd { get; set; }
        /// <summary>
        /// Information whether current user can edit the video
        /// </summary>
        public int? CanEdit { get; set; }
        /// <summary>
        /// Information whether the video is private
        /// </summary>
        public int? IsPrivate { get; set; }
        /// <summary>
        /// Videos number (for album)
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Date of last update (for album) in Unixtime
        /// </summary>
        public DateTime? UpdatedTime { get; set; }
    }

    public class VideoSaveResult
    {
        /// <summary>
        /// URL for the video uploading
        /// </summary>
        public string UploadUrl { get; set; }
        /// <summary>
        /// Video ID
        /// </summary>
        public int? VideoId { get; set; }
        /// <summary>
        /// Video owner ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Video title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Video description
        /// </summary>
        public string Description { get; set; }
    }

    public class VideoUploadResponse
    {
        /// <summary>
        /// Video size
        /// </summary>
        public int? Size { get; set; }
        /// <summary>
        /// Video ID
        /// </summary>
        public int? VideoId { get; set; }
    }

    public class VideoVideo
    {
        /// <summary>
        /// Video ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Video owner ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Video title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Video duration in seconds
        /// </summary>
        public int? Duration { get; set; }
        /// <summary>
        /// Video description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Date when video has been uploaded in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Number of views
        /// </summary>
        public int? Views { get; set; }
        /// <summary>
        /// Number of comments
        /// </summary>
        public int? Comments { get; set; }
        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of the preview image with 320 px in width
        /// </summary>
        public string Photo320 { get; set; }
        /// <summary>
        /// URL of the preview image with 800 px in width
        /// </summary>
        public string Photo800 { get; set; }
        /// <summary>
        /// Video access key
        /// </summary>
        public string AccessKey { get; set; }
        /// <summary>
        /// Date when the video has been added in Unixtime
        /// </summary>
        public DateTime? AddingDate { get; set; }
        /// <summary>
        /// URL of the page with a player that can be used to play the video in the browser.
        /// </summary>
        public string Player { get; set; }
        /// <summary>
        /// Information whether current user can edit the video
        /// </summary>
        public bool? CanEdit { get; set; }
        /// <summary>
        /// Information whether current user can add the video
        /// </summary>
        public bool? CanAdd { get; set; }
        /// <summary>
        /// Returns if the video is processing
        /// </summary>
        public bool? Processing { get; set; }
        /// <summary>
        /// Returns if the video is live translation
        /// </summary>
        public bool? Live { get; set; }
        public VideoVideoFiles Files { get; set; }
    }

    public class VideoVideoAlbum
    {
        /// <summary>
        /// Album ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Album owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Album title
        /// </summary>
        public string Title { get; set; }
    }

    public class VideoVideoAlbumFull
    {
        /// <summary>
        /// Album ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Album owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Album title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Total number of videos in album
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// URL of the preview image with 160px in width
        /// </summary>
        public string Photo160 { get; set; }
        /// <summary>
        /// URL of the preview image with 320px in width
        /// </summary>
        public string Photo320 { get; set; }
        /// <summary>
        /// Date when the album has been updated last time in Unixtime
        /// </summary>
        public DateTime? UpdatedTime { get; set; }
        /// <summary>
        /// Information whether album is system
        /// </summary>
        public int? IsSystem { get; set; }
    }

    public class VideoVideoFiles
    {
        /// <summary>
        /// URL of the mpeg4 file with 240p quality
        /// </summary>
        public string Mp240 { get; set; }
        /// <summary>
        /// URL of the mpeg4 file with 360p quality
        /// </summary>
        public string Mp360 { get; set; }
        /// <summary>
        /// URL of the mpeg4 file with 480p quality
        /// </summary>
        public string Mp480 { get; set; }
        /// <summary>
        /// URL of the mpeg4 file with 720p quality
        /// </summary>
        public string Mp720 { get; set; }
        /// <summary>
        /// URL of the mpeg4 file with 1080p quality
        /// </summary>
        public string Mp1080 { get; set; }
        /// <summary>
        /// URL of the external player
        /// </summary>
        public string External { get; set; }
    }

    public class VideoVideoFull
    {
        /// <summary>
        /// Video ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Video owner ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Video title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Video duration in seconds
        /// </summary>
        public int? Duration { get; set; }
        /// <summary>
        /// Video description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Date when video has been uploaded in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Number of views
        /// </summary>
        public int? Views { get; set; }
        /// <summary>
        /// Number of comments
        /// </summary>
        public int? Comments { get; set; }
        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of the preview image with 320 px in width
        /// </summary>
        public string Photo320 { get; set; }
        /// <summary>
        /// URL of the preview image with 800 px in width
        /// </summary>
        public string Photo800 { get; set; }
        /// <summary>
        /// Video access key
        /// </summary>
        public string AccessKey { get; set; }
        /// <summary>
        /// Date when the video has been added in Unixtime
        /// </summary>
        public DateTime? AddingDate { get; set; }
        /// <summary>
        /// URL of the page with a player that can be used to play the video in the browser.
        /// </summary>
        public string Player { get; set; }
        /// <summary>
        /// Information whether current user can edit the video
        /// </summary>
        public bool? CanEdit { get; set; }
        /// <summary>
        /// Information whether current user can add the video
        /// </summary>
        public bool? CanAdd { get; set; }
        /// <summary>
        /// Returns if the video is processing
        /// </summary>
        public bool? Processing { get; set; }
        /// <summary>
        /// Returns if the video is live translation
        /// </summary>
        public bool? Live { get; set; }
        public VideoVideoFiles Files { get; set; }
        public IEnumerable<string> PrivacyView { get; set; }
        public IEnumerable<string> PrivacyComment { get; set; }
        /// <summary>
        /// Information whether current user can comment the video
        /// </summary>
        public bool? CanComment { get; set; }
        /// <summary>
        /// Information whether current user can comment the video
        /// </summary>
        public bool? CanRepost { get; set; }
        public BaseLikes Likes { get; set; }
        /// <summary>
        /// Information whether the video is repeated
        /// </summary>
        public bool? Repeat { get; set; }
    }

    public class VideoVideoTag
    {
        /// <summary>
        /// Tagged user ID
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Tag ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// ID of the tag creator
        /// </summary>
        public int? PlacerId { get; set; }
        /// <summary>
        /// Tag description
        /// </summary>
        public string TaggedName { get; set; }
        /// <summary>
        /// Date when tag has been added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Information whether tha tag is reviewed
        /// </summary>
        public bool? Viewed { get; set; }
    }

    public class VideoVideoTagInfo
    {
        /// <summary>
        /// Video ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Video owner ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Video title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Video duration in seconds
        /// </summary>
        public int? Duration { get; set; }
        /// <summary>
        /// Video description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Date when video has been uploaded in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Number of views
        /// </summary>
        public int? Views { get; set; }
        /// <summary>
        /// Number of comments
        /// </summary>
        public int? Comments { get; set; }
        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of the preview image with 320 px in width
        /// </summary>
        public string Photo320 { get; set; }
        /// <summary>
        /// URL of the preview image with 800 px in width
        /// </summary>
        public string Photo800 { get; set; }
        /// <summary>
        /// Video access key
        /// </summary>
        public string AccessKey { get; set; }
        /// <summary>
        /// Date when the video has been added in Unixtime
        /// </summary>
        public DateTime? AddingDate { get; set; }
        /// <summary>
        /// URL of the page with a player that can be used to play the video in the browser.
        /// </summary>
        public string Player { get; set; }
        /// <summary>
        /// Information whether current user can edit the video
        /// </summary>
        public bool? CanEdit { get; set; }
        /// <summary>
        /// Information whether current user can add the video
        /// </summary>
        public bool? CanAdd { get; set; }
        /// <summary>
        /// Returns if the video is processing
        /// </summary>
        public bool? Processing { get; set; }
        /// <summary>
        /// Returns if the video is live translation
        /// </summary>
        public bool? Live { get; set; }
        public VideoVideoFiles Files { get; set; }
        /// <summary>
        /// ID of the tag creator
        /// </summary>
        public int? PlacerId { get; set; }
        /// <summary>
        /// Date when tag has been added in Unixtime
        /// </summary>
        public DateTime? TagCreated { get; set; }
        /// <summary>
        /// Tag ID
        /// </summary>
        public int? TagId { get; set; }
    }

    public class WallAppPost
    {
        /// <summary>
        /// Application ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Application name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of the preview image with 604 px in width
        /// </summary>
        public string Photo604 { get; set; }
    }

    public class WallAttachedNote
    {
        /// <summary>
        /// Note ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Note owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Comments number
        /// </summary>
        public int? Comments { get; set; }
        /// <summary>
        /// Read comments number
        /// </summary>
        public int? ReadComments { get; set; }
        /// <summary>
        /// Date when the note has been created in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Note title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// URL of the page with note preview
        /// </summary>
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
        /// <summary>
        /// Attachment type
        /// </summary>
        public string Type { get; set; }
    }

    public class WallGraffiti
    {
        /// <summary>
        /// Graffiti ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Graffiti owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// URL of the preview image with 200 px in width
        /// </summary>
        public string Photo200 { get; set; }
        /// <summary>
        /// URL of the preview image with 586 px in width
        /// </summary>
        public string Photo586 { get; set; }
    }

    public class WallPostSource
    {
        /// <summary>
        /// Type of post source
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Platform name
        /// </summary>
        public string Platform { get; set; }
        /// <summary>
        /// Additional data
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// URL to an external site used to publish the post
        /// </summary>
        public string Url { get; set; }
    }

    public class WallPostedPhoto
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Photo owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        public string Photo130 { get; set; }
        /// <summary>
        /// URL of the preview image with 604 px in width
        /// </summary>
        public string Photo604 { get; set; }
    }

    public class WallViews
    {
        /// <summary>
        /// Count
        /// </summary>
        public int? Count { get; set; }
    }

    public class WallWallComment
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Author ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Text { get; set; }
        public BaseLikesInfo Likes { get; set; }
        /// <summary>
        /// Replied user ID
        /// </summary>
        public int? ReplyToUser { get; set; }
        /// <summary>
        /// Replied comment ID
        /// </summary>
        public int? ReplyToComment { get; set; }
        public IEnumerable<WallCommentAttachment> Attachments { get; set; }
        /// <summary>
        /// Real position of the comment
        /// </summary>
        public int? RealOffset { get; set; }
    }

    public class WallWallpost
    {
        /// <summary>
        /// Post ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Post author ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// Wall owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Date of publishing in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        public bool? MarkedAsAds { get; set; }

        /// <summary>
        /// Count of views
        /// </summary>
        public WallViews Views { get; set; }
        public string PostType { get; set; }
        /// <summary>
        /// Post text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Post signer ID
        /// </summary>
        public int? SignerId { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
        public WallPostSource PostSource { get; set; }
    }

    public class WallWallpostAttached
    {
        /// <summary>
        /// Post ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Post author ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// Post addresse
        /// </summary>
        public int? ToId { get; set; }
        /// <summary>
        /// Date of publishing in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        public string PostType { get; set; }
        /// <summary>
        /// Post text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Information whether current user can delete the post
        /// </summary>
        public int? CanDelete { get; set; }
        /// <summary>
        /// Post signer ID
        /// </summary>
        public int? SignerId { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
        public WallPostSource PostSource { get; set; }
        public BaseCommentsInfo Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
        /// <summary>
        /// Source post owner's ID
        /// </summary>
        public int? CopyOwnerId { get; set; }
        /// <summary>
        /// Source post ID
        /// </summary>
        public int? CopyPostId { get; set; }
        /// <summary>
        /// Repost comment
        /// </summary>
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
        /// <summary>
        /// Attachment type
        /// </summary>
        public string Type { get; set; }
    }

    public class WallWallpostFull : WallWallpost
    {
        public IEnumerable<WallWallpost> CopyHistory { get; set; }
        /// <summary>
        /// Information whether current user can edit the post
        /// </summary>
        public bool? CanEdit { get; set; }
        /// <summary>
        /// Post creator ID (if post still can be edited)
        /// </summary>
        public int? CreatedBy { get; set; }
        /// <summary>
        /// Information whether current user can delete the post
        /// </summary>
        public bool? CanDelete { get; set; }
        /// <summary>
        /// Information whether current user can pin the post
        /// </summary>
        public bool? CanPin { get; set; }
        /// <summary>
        /// Information whether the post is pinned
        /// </summary>
        public bool? IsPinned { get; set; }
        public BaseCommentsInfo Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
    }

    public class WallWallpostToId
    {
        /// <summary>
        /// Post ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Post author ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// Wall owner's ID
        /// </summary>
        public int? ToId { get; set; }
        /// <summary>
        /// Date of publishing in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// wall post ID (if comment)
        /// </summary>
        public int? PostId { get; set; }
        public string PostType { get; set; }
        /// <summary>
        /// Post text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Post signer ID
        /// </summary>
        public int? SignerId { get; set; }
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; }
        public BaseGeo Geo { get; set; }
        public WallPostSource PostSource { get; set; }
        public BaseCommentsInfo Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
        /// <summary>
        /// ID of the source post owner
        /// </summary>
        public int? CopyOwnerId { get; set; }
        /// <summary>
        /// ID of the source post
        /// </summary>
        public int? CopyPostId { get; set; }
    }

    public class WidgetsCommentMedia
    {
        /// <summary>
        /// Media type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Media owner's ID
        /// </summary>
        public int? OwnerId { get; set; }
        /// <summary>
        /// Media item ID
        /// </summary>
        public int? ItemId { get; set; }
        /// <summary>
        /// URL of the preview image (type=photo only)
        /// </summary>
        public string ThumbSrc { get; set; }
    }

    public class WidgetsCommentReplies
    {
        /// <summary>
        /// Comments number
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Information whether current user can comment the post
        /// </summary>
        public int? CanPost { get; set; }
        public IEnumerable<WidgetsCommentRepliesItem> Replies { get; set; }
    }

    public class WidgetsCommentRepliesItem
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        public int? Cid { get; set; }
        /// <summary>
        /// User ID
        /// </summary>
        public int? Uid { get; set; }
        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Text { get; set; }
        public WidgetsWidgetLikes Likes { get; set; }
        public UsersUserFull User { get; set; }
    }

    public class WidgetsWidgetComment
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Comment author ID
        /// </summary>
        public int? FromId { get; set; }
        /// <summary>
        /// Wall owner
        /// </summary>
        public int? ToId { get; set; }
        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        public UsersUserFull User { get; set; }
        /// <summary>
        /// Post type
        /// </summary>
        public int? PostType { get; set; }
        /// <summary>
        /// Comment text
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Information whether current user can delete the comment
        /// </summary>
        public int? CanDelete { get; set; }
        public WidgetsCommentMedia Media { get; set; }
        public IEnumerable<WallCommentAttachment> Attachments { get; set; }
        public WallPostSource PostSource { get; set; }
        public WidgetsCommentReplies Comments { get; set; }
        public BaseLikesInfo Likes { get; set; }
        public BaseRepostsInfo Reposts { get; set; }
    }

    public class WidgetsWidgetLikes
    {
        /// <summary>
        /// Likes number
        /// </summary>
        public int? Count { get; set; }
    }

    public class WidgetsWidgetPage
    {
        /// <summary>
        /// Page ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Page title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Page description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// URL of the preview image
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Page absolute URL
        /// </summary>
        public string Url { get; set; }
        public BaseObjectCount Likes { get; set; }
        public BaseObjectCount Comments { get; set; }
        /// <summary>
        /// Date when widgets on the page has been initialized firstly in Unixtime
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// page_id parameter value
        /// </summary>
        public string PageId { get; set; }
    }

}