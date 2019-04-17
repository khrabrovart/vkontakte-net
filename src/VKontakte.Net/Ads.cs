using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class AdsAccesses
    {
        public string ClientId { get; set; } 

        public AdsAccessRole Role { get; set; } 
    }

    public class AdsAccessRole
    {
    }

    public class AdsAccount
    {
        public AdsAccessRole AccessRole { get; set; } 

        public int? AccountId { get; set; } 

        public bool? AccountStatus { get; set; } 

        public AdsAccountType AccountType { get; set; } 
    }

    public class AdsAccountType
    {
    }

    public class AdsAd
    {
        public int? AdFormat { get; set; } 

        public object AdPlatform { get; set; } 

        public int? AllLimit { get; set; } 

        public AdsAdApproved Approved { get; set; } 

        public int? CampaignId { get; set; } 

        public int? Category1Id { get; set; } 

        public int? Category2Id { get; set; } 

        public AdsAdCostType CostType { get; set; } 

        public int? Cpc { get; set; } 

        public int? Cpm { get; set; } 

        public bool? DisclaimerMedical { get; set; } 

        public bool? DisclaimerSpecialist { get; set; } 

        public bool? DisclaimerSupplements { get; set; } 

        public int? Id { get; set; } 

        public int? ImpressionsLimit { get; set; } 

        public bool? ImpressionsLimited { get; set; } 

        public string Name { get; set; } 

        public AdsAdStatus Status { get; set; } 

        public bool? Video { get; set; } 
    }

    public class AdsAdApproved
    {
    }

    public class AdsAdCostType
    {
    }

    public class AdsAdLayout
    {
        public int? AdFormat { get; set; } 

        public int? CampaignId { get; set; } 

        public AdsAdLayoutCostType CostType { get; set; } 

        public string Description { get; set; } 

        public int? Id { get; set; } 

        public string ImageSrc { get; set; } 

        public string ImageSrc2x { get; set; } 

        public string LinkDomain { get; set; } 

        public string LinkUrl { get; set; } 

        public object PreviewLink { get; set; } 

        public string Title { get; set; } 

        public bool? Video { get; set; } 
    }

    public class AdsAdLayoutCostType
    {
    }

    public class AdsAdStatus
    {
    }

    public class AdsCampaign
    {
        public string AllLimit { get; set; } 

        public string DayLimit { get; set; } 

        public int? Id { get; set; } 

        public string Name { get; set; } 

        public int? StartTime { get; set; } 

        public AdsCampaignStatus Status { get; set; } 

        public int? StopTime { get; set; } 

        public AdsCampaignType Type { get; set; } 
    }

    public class AdsCampaignStatus
    {
    }

    public class AdsCampaignType
    {
    }

    public class AdsCategory
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public IEnumerable<object> Subcategories { get; set; } 
    }

    public class AdsClient
    {
        public string AllLimit { get; set; } 

        public string DayLimit { get; set; } 

        public int? Id { get; set; } 

        public string Name { get; set; } 
    }

    public class AdsCriteria
    {
        public int? AgeFrom { get; set; } 

        public int? AgeTo { get; set; } 

        public string Apps { get; set; } 

        public string AppsNot { get; set; } 

        public int? Birthday { get; set; } 

        public string Cities { get; set; } 

        public string CitiesNot { get; set; } 

        public int? Country { get; set; } 

        public string Districts { get; set; } 

        public string Groups { get; set; } 

        public string InterestCategories { get; set; } 

        public string Interests { get; set; } 

        public bool? Paying { get; set; } 

        public string Positions { get; set; } 

        public string Religions { get; set; } 

        public string RetargetingGroups { get; set; } 

        public string RetargetingGroupsNot { get; set; } 

        public int? SchoolFrom { get; set; } 

        public int? SchoolTo { get; set; } 

        public string Schools { get; set; } 

        public AdsCriteriaSex Sex { get; set; } 

        public string Stations { get; set; } 

        public string Statuses { get; set; } 

        public string Streets { get; set; } 

        public BasePropertyExists Travellers { get; set; } 

        public int? UniFrom { get; set; } 

        public int? UniTo { get; set; } 

        public string UserBrowsers { get; set; } 

        public string UserDevices { get; set; } 

        public string UserOs { get; set; } 
    }

    public class AdsCriteriaSex
    {
    }

    public class AdsDemoStats
    {
        public int? Id { get; set; } 

        public AdsDemostatsFormat Stats { get; set; } 

        public AdsObjectType Type { get; set; } 
    }

    public class AdsDemostatsFormat
    {
        public IEnumerable<object> Age { get; set; } 

        public IEnumerable<object> Cities { get; set; } 

        public string Day { get; set; } 

        public string Month { get; set; } 

        public int? Overall { get; set; } 

        public IEnumerable<object> Sex { get; set; } 

        public IEnumerable<object> SexAge { get; set; } 
    }

    public class AdsFloodStats
    {
        public int? Left { get; set; } 

        public int? Refresh { get; set; } 
    }

    public class AdsLinkStatus
    {
        public string Description { get; set; } 

        public string RedirectUrl { get; set; } 

        public string Status { get; set; } 
    }

    public class AdsObjectType
    {
    }

    public class AdsParagraphs
    {
        public string Paragraph { get; set; } 
    }

    public class AdsPromotedPostReach
    {
        public int? Hide { get; set; } 

        public int? Id { get; set; } 

        public int? JoinGroup { get; set; } 

        public int? Links { get; set; } 

        public int? ReachSubscribers { get; set; } 

        public int? ReachTotal { get; set; } 

        public int? Report { get; set; } 

        public int? ToGroup { get; set; } 

        public int? Unsubscribe { get; set; } 

        public int? VideoViews100p { get; set; } 

        public int? VideoViews25p { get; set; } 

        public int? VideoViews3s { get; set; } 

        public int? VideoViews50p { get; set; } 

        public int? VideoViews75p { get; set; } 

        public int? VideoViewsStart { get; set; } 
    }

    public class AdsRejectReason
    {
        public string Comment { get; set; } 

        public IEnumerable<object> Rules { get; set; } 
    }

    public class AdsRules
    {
        public IEnumerable<object> Paragraphs { get; set; } 

        public string Title { get; set; } 
    }

    public class AdsStats
    {
        public int? Id { get; set; } 

        public AdsStatsFormat Stats { get; set; } 

        public AdsObjectType Type { get; set; } 
    }

    public class AdsStatsAge
    {
        public double? ClicksRate { get; set; } 

        public double? ImpressionsRate { get; set; } 

        public string Value { get; set; } 
    }

    public class AdsStatsCities
    {
        public double? ClicksRate { get; set; } 

        public double? ImpressionsRate { get; set; } 

        public string Name { get; set; } 

        public int? Value { get; set; } 
    }

    public class AdsStatsFormat
    {
        public int? Clicks { get; set; } 

        public string Day { get; set; } 

        public int? Impressions { get; set; } 

        public int? JoinRate { get; set; } 

        public string Month { get; set; } 

        public int? Overall { get; set; } 

        public int? Reach { get; set; } 

        public int? Spent { get; set; } 

        public int? VideoClicksSite { get; set; } 

        public int? VideoViews { get; set; } 

        public int? VideoViewsFull { get; set; } 

        public int? VideoViewsHalf { get; set; } 
    }

    public class AdsStatsSex
    {
        public double? ClicksRate { get; set; } 

        public double? ImpressionsRate { get; set; } 

        public AdsStatsSexValue Value { get; set; } 
    }

    public class AdsStatsSexAge
    {
        public double? ClicksRate { get; set; } 

        public double? ImpressionsRate { get; set; } 

        public string Value { get; set; } 
    }

    public class AdsStatsSexValue
    {
    }

    public class AdsTargetGroup
    {
        public int? AudienceCount { get; set; } 

        public string Domain { get; set; } 

        public int? Id { get; set; } 

        public int? Lifetime { get; set; } 

        public string Name { get; set; } 

        public string Pixel { get; set; } 
    }

    public class AdsTargSettings
    {
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

    public class AdsTargSuggestionsCities
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public string Parent { get; set; } 
    }

    public class AdsTargSuggestionsRegions
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public string Type { get; set; } 
    }

    public class AdsTargSuggestionsSchools
    {
        public string Desc { get; set; } 

        public int? Id { get; set; } 

        public string Name { get; set; } 

        public string Parent { get; set; } 

        public AdsTargSuggestionsSchoolsType Type { get; set; } 
    }

    public class AdsTargSuggestionsSchoolsType
    {
    }

    public class AdsUsers
    {
        public IEnumerable<object> Accesses { get; set; } 

        public int? UserId { get; set; } 
    }
}
