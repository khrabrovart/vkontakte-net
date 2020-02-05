using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IAdsApi
    {
        /// <summary>
        /// Adds managers and/or supervisors to advertising account.
        /// </summary>
        Task<ApiRequest<bool?>> AddOfficeUsersApi(int? accountId = null, string data = null);

        /// <summary>
        /// Allows to check the ad link.
        /// </summary>
        Task<ApiRequest<AdsLinkStatus>> CheckLinkApi(int? accountId = null, string linkType = null, string linkUrl = null, int? campaignId = null);

        /// <summary>
        /// Creates ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> CreateAdsApi(int? accountId = null, string data = null);

        /// <summary>
        /// Creates advertising campaigns.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> CreateCampaignsApi(int? accountId = null, string data = null);

        /// <summary>
        /// Creates clients of an advertising agency.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> CreateClientsApi(int? accountId = null, string data = null);

        /// <summary>
        /// Creates a group to re-target ads for users who visited advertiser's site (viewed information about the product, registered, etc.).
        /// </summary>
        Task<ApiRequest<AdsCreateTargetGroupResponse>> CreateTargetGroupApi(int? accountId = null, int? clientId = null, string name = null, int? lifetime = null, int? targetPixelId = null, string targetPixelRules = null);

        /// <summary>
        /// Archives ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> DeleteAdsApi(int? accountId = null, string ids = null);

        /// <summary>
        /// Archives advertising campaigns.
        /// </summary>
        Task<ApiRequest<int?>> DeleteCampaignsApi(int? accountId = null, string ids = null);

        /// <summary>
        /// Archives clients of an advertising agency.
        /// </summary>
        Task<ApiRequest<int?>> DeleteClientsApi(int? accountId = null, string ids = null);

        /// <summary>
        /// Deletes a retarget group.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteTargetGroupApi(int? accountId = null, int? clientId = null, int? targetGroupId = null);

        /// <summary>
        /// Returns a list of advertising accounts.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsAccount>>> GetAccountsApi();

        /// <summary>
        /// Returns number of ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsAd>>> GetAdsApi(int? accountId = null, string adIds = null, string campaignIds = null, int? clientId = null, bool? includeDeleted = null, int? limit = null, int? offset = null);

        /// <summary>
        /// Returns descriptions of ad layouts.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsAdLayout>>> GetAdsLayoutApi(int? accountId = null, string adIds = null, string campaignIds = null, int? clientId = null, bool? includeDeleted = null, int? limit = null, int? offset = null);

        /// <summary>
        /// Returns ad targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSettings>>> GetAdsTargetingApi(int? accountId = null, string adIds = null, string campaignIds = null, int? clientId = null, bool? includeDeleted = null, int? limit = null, int? offset = null);

        /// <summary>
        /// Returns current budget of the advertising account.
        /// </summary>
        Task<ApiRequest<int?>> GetBudgetApi(int? accountId = null);

        /// <summary>
        /// Returns a list of campaigns in an advertising account.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsCampaign>>> GetCampaignsApi(int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null);

        /// <summary>
        /// Returns a list of possible ad categories.
        /// </summary>
        Task<ApiRequest<AdsGetCategoriesResponse>> GetCategoriesApi(string lang = null);

        /// <summary>
        /// Returns a list of advertising agency's clients.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsClient>>> GetClientsApi(int? accountId = null);

        /// <summary>
        /// Returns demographics for ads or campaigns.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsDemoStats>>> GetDemographicsApi(int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null);

        /// <summary>
        /// Returns information about current state of a counter — number of remaining runs of methods and time to the next counter nulling in seconds.
        /// </summary>
        Task<ApiRequest<AdsFloodStats>> GetFloodStatsApi(int? accountId = null);

        /// <summary>
        /// Returns a list of managers and supervisors of advertising account.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsUsers>>> GetOfficeUsersApi(int? accountId = null);

        /// <summary>
        /// Returns detailed statistics of promoted posts reach from campaigns and ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsPromotedPostReach>>> GetPostsReachApi(int? accountId = null, string idsType = null, string ids = null);

        /// <summary>
        /// Returns a reason of ad rejection for pre-moderation.
        /// </summary>
        Task<ApiRequest<AdsRejectReason>> GetRejectionReasonApi(int? accountId = null, int? adId = null);

        /// <summary>
        /// Returns statistics of performance indicators for ads, campaigns, clients or the whole account.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsStats>>> GetStatisticsApi(int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null);

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestions>>> GetSuggestionsApi(string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null);

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsApi(string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null);

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsApi(string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null);

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsApi(string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null);

        /// <summary>
        /// Returns a list of target groups.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargetGroup>>> GetTargetGroupsApi(int? accountId = null, int? clientId = null, bool? extended = null);

        /// <summary>
        /// Returns the size of targeting audience, and also recommended values for CPC and CPM.
        /// </summary>
        Task<ApiRequest<AdsTargStats>> GetTargetingStatsApi(int? accountId = null, int? clientId = null, string criteria = null, int? adId = null, int? adFormat = null, string adPlatform = null, string adPlatformNoWall = null, string adPlatformNoAdNetwork = null, string linkUrl = null, string linkDomain = null);

        /// <summary>
        /// Returns URL to upload an ad photo to.
        /// </summary>
        Task<ApiRequest<string>> GetUploadURLApi(int? adFormat = null, int? icon = null);

        /// <summary>
        /// Returns URL to upload an ad video to.
        /// </summary>
        Task<ApiRequest<string>> GetVideoUploadURLApi();

        /// <summary>
        /// Imports a list of advertiser's contacts to count VK registered users against the target group.
        /// </summary>
        Task<ApiRequest<int?>> ImportTargetContactsApi(int? accountId = null, int? clientId = null, int? targetGroupId = null, string contacts = null);

        /// <summary>
        /// Removes managers and/or supervisors from advertising account.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveOfficeUsersApi(int? accountId = null, string ids = null);

        /// <summary>
        /// Edits ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> UpdateAdsApi(int? accountId = null, string data = null);

        /// <summary>
        /// Edits advertising campaigns.
        /// </summary>
        Task<ApiRequest<int?>> UpdateCampaignsApi(int? accountId = null, string data = null);

        /// <summary>
        /// Edits clients of an advertising agency.
        /// </summary>
        Task<ApiRequest<int?>> UpdateClientsApi(int? accountId = null, string data = null);

        /// <summary>
        /// Edits a retarget group.
        /// </summary>
        Task<ApiRequest<bool?>> UpdateTargetGroupApi(int? accountId = null, int? clientId = null, int? targetGroupId = null, string name = null, string domain = null, int? lifetime = null, int? targetPixelId = null, string targetPixelRules = null);
    }
}
