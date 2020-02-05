using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IAdsApi
    {
        /// <summary>
        /// Returns a list of advertising accounts.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsAccount>>> GetAccounts(UserAccessToken accessToken);
        /// <summary>
        /// Returns a list of advertising agency's clients.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsClient>>> GetClients(UserAccessToken accessToken, int? accountId = null);
        /// <summary>
        /// Creates clients of an advertising agency.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> CreateClients(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Edits clients of an advertising agency.
        /// </summary>
        Task<ApiRequest<int?>> UpdateClients(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Archives clients of an advertising agency.
        /// </summary>
        Task<ApiRequest<int?>> DeleteClients(UserAccessToken accessToken, int? accountId = null, string ids = null);
        /// <summary>
        /// Returns a list of campaigns in an advertising account.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsCampaign>>> GetCampaigns(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null);
        /// <summary>
        /// Creates advertising campaigns.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> CreateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Edits advertising campaigns.
        /// </summary>
        Task<ApiRequest<int?>> UpdateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Archives advertising campaigns.
        /// </summary>
        Task<ApiRequest<int?>> DeleteCampaigns(UserAccessToken accessToken, int? accountId = null, string ids = null);
        /// <summary>
        /// Returns number of ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsAd>>> GetAds(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null);
        /// <summary>
        /// Returns descriptions of ad layouts.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsAdLayout>>> GetAdsLayout(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null);
        /// <summary>
        /// Returns ad targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSettings>>> GetAdsTargeting(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null);
        /// <summary>
        /// Creates ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> CreateAds(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Edits ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> UpdateAds(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Archives ads.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> DeleteAds(UserAccessToken accessToken, int? accountId = null, string ids = null);
        /// <summary>
        /// Allows to check the ad link.
        /// </summary>
        Task<ApiRequest<AdsLinkStatus>> CheckLink(UserAccessToken accessToken, int? accountId = null, string linkType = null, string linkUrl = null, int? campaignId = null);
        /// <summary>
        /// Returns statistics of performance indicators for ads, campaigns, clients or the whole account.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsStats>>> GetStatistics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null);
        /// <summary>
        /// Returns demographics for ads or campaigns.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsDemoStats>>> GetDemographics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null);
        /// <summary>
        /// Allows to get detailed information about the ad post reach.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsPostStats>>> GetAdsPostsReach(UserAccessToken accessToken, int? accountId = null, string adsIds = null);
        /// <summary>
        /// Returns current budget of the advertising account.
        /// </summary>
        Task<ApiRequest<int?>> GetBudget(UserAccessToken accessToken, int? accountId = null);
        /// <summary>
        /// Returns a list of managers and supervisors of advertising account.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsUsers>>> GetOfficeUsers(UserAccessToken accessToken, int? accountId = null);
        /// <summary>
        /// Adds managers and/or supervisors to advertising account.
        /// </summary>
        Task<ApiRequest<bool?>> AddOfficeUsers(UserAccessToken accessToken, int? accountId = null, string data = null);
        /// <summary>
        /// Removes managers and/or supervisors from advertising account.
        /// </summary>
        Task<ApiRequest<bool?>> RemoveOfficeUsers(UserAccessToken accessToken, int? accountId = null, string ids = null);
        /// <summary>
        /// Returns the size of targeting audience, and also recommended values for CPC and CPM.
        /// </summary>
        Task<ApiRequest<AdsTargStats>> GetTargetingStats(UserAccessToken accessToken, int? accountId = null, string criteria = null, int? adId = null, int? adFormat = null, string adPlatform = null, string linkUrl = null, string linkDomain = null);
        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestions>>> GetSuggestions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null);
        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsRegions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null);
        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsCities(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null);
        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsSchools(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null);
        /// <summary>
        /// Returns a list of possible ad categories.
        /// </summary>
        Task<ApiRequest<AdsGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, string lang = null);
        /// <summary>
        /// Returns URL to upload an ad photo to.
        /// </summary>
        Task<ApiRequest<string>> GetUploadURL(UserAccessToken accessToken, int? adFormat = null);
        /// <summary>
        /// Returns URL to upload an ad video to.
        /// </summary>
        Task<ApiRequest<string>> GetVideoUploadURL();
        /// <summary>
        /// Returns information about current state of a counter — number of remaining runs of methods and time to the next counter nulling in seconds.
        /// </summary>
        Task<ApiRequest<AdsFloodStats>> GetFloodStats(UserAccessToken accessToken, int? accountId = null);
        /// <summary>
        /// Returns a reason of ad rejection for pre-moderation.
        /// </summary>
        Task<ApiRequest<AdsRejectReason>> GetRejectionReason(UserAccessToken accessToken, int? accountId = null, int? adId = null);
        /// <summary>
        /// Creates a group to re-target ads for users who visited advertiser's site (viewed information about the product, registered, etc.).
        /// </summary>
        Task<ApiRequest<AdsCreateTargetGroupResponse>> CreateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, string name = null, string domain = null, int? lifetime = null);
        /// <summary>
        /// Edits a retarget group.
        /// </summary>
        Task<ApiRequest<bool?>> UpdateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string name = null, string domain = null, int? lifetime = null);
        /// <summary>
        /// Deletes a retarget group.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null);
        /// <summary>
        /// Returns a list of target groups.
        /// </summary>
        Task<ApiRequest<IEnumerable<AdsTargetGroup>>> GetTargetGroups(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? extended = null);
        /// <summary>
        /// Imports a list of advertiser's contacts to count VK registered users against the target group.
        /// </summary>
        Task<ApiRequest<int?>> ImportTargetContacts(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string contacts = null);
    }
}
