using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Ads : IAds
    {
        /// <summary>
        /// Adds managers and/or supervisors to advertising account.
        /// </summary>
        public Task<ApiRequest<bool?>> AddOfficeUsersApi(int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.addOfficeUsers", null, request);
        }

        /// <summary>
        /// Allows to check the ad link.
        /// </summary>
        public Task<ApiRequest<AdsLinkStatus>> CheckLinkApi(int? accountId = null, string linkType = null, string linkUrl = null, int? campaignId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["link_type"] = linkType,
                ["link_url"] = linkUrl,
                ["campaign_id"] = campaignId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsLinkStatus>("ads.checkLink", null, request);
        }

        /// <summary>
        /// Creates ads.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> CreateAdsApi(int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("ads.createAds", null, request);
        }

        /// <summary>
        /// Creates advertising campaigns.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> CreateCampaignsApi(int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("ads.createCampaigns", null, request);
        }

        /// <summary>
        /// Creates clients of an advertising agency.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> CreateClientsApi(int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("ads.createClients", null, request);
        }

        /// <summary>
        /// Creates a group to re-target ads for users who visited advertiser's site (viewed information about the product, registered, etc.).
        /// </summary>
        public Task<ApiRequest<AdsCreateTargetGroupResponse>> CreateTargetGroupApi(int? accountId = null, int? clientId = null, string name = null, int? lifetime = null, int? targetPixelId = null, string targetPixelRules = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["name"] = name,
                ["lifetime"] = lifetime?.ToString(),
                ["target_pixel_id"] = targetPixelId?.ToString(),
                ["target_pixel_rules"] = targetPixelRules,
            };

            return RequestManager.CreateRequestAsync<AdsCreateTargetGroupResponse>("ads.createTargetGroup", null, request);
        }

        /// <summary>
        /// Archives ads.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> DeleteAdsApi(int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("ads.deleteAds", null, request);
        }

        /// <summary>
        /// Archives advertising campaigns.
        /// </summary>
        public Task<ApiRequest<int?>> DeleteCampaignsApi(int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.deleteCampaigns", null, request);
        }

        /// <summary>
        /// Archives clients of an advertising agency.
        /// </summary>
        public Task<ApiRequest<int?>> DeleteClientsApi(int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.deleteClients", null, request);
        }

        /// <summary>
        /// Deletes a retarget group.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteTargetGroupApi(int? accountId = null, int? clientId = null, int? targetGroupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["target_group_id"] = targetGroupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.deleteTargetGroup", null, request);
        }

        /// <summary>
        /// Returns a list of advertising accounts.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsAccount>>> GetAccountsApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsAccount>>("ads.getAccounts", null, request);
        }

        /// <summary>
        /// Returns number of ads.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsAd>>> GetAdsApi(int? accountId = null, string adIds = null, string campaignIds = null, int? clientId = null, bool? includeDeleted = null, int? limit = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ad_ids"] = adIds,
                ["campaign_ids"] = campaignIds,
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["limit"] = limit?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsAd>>("ads.getAds", null, request);
        }

        /// <summary>
        /// Returns descriptions of ad layouts.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsAdLayout>>> GetAdsLayoutApi(int? accountId = null, string adIds = null, string campaignIds = null, int? clientId = null, bool? includeDeleted = null, int? limit = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ad_ids"] = adIds,
                ["campaign_ids"] = campaignIds,
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["limit"] = limit?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsAdLayout>>("ads.getAdsLayout", null, request);
        }

        /// <summary>
        /// Returns ad targeting parameters.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsTargSettings>>> GetAdsTargetingApi(int? accountId = null, string adIds = null, string campaignIds = null, int? clientId = null, bool? includeDeleted = null, int? limit = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ad_ids"] = adIds,
                ["campaign_ids"] = campaignIds,
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["limit"] = limit?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSettings>>("ads.getAdsTargeting", null, request);
        }

        /// <summary>
        /// Returns current budget of the advertising account.
        /// </summary>
        public Task<ApiRequest<int?>> GetBudgetApi(int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("ads.getBudget", null, request);
        }

        /// <summary>
        /// Returns a list of campaigns in an advertising account.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsCampaign>>> GetCampaignsApi(int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["campaign_ids"] = campaignIds,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsCampaign>>("ads.getCampaigns", null, request);
        }

        /// <summary>
        /// Returns a list of possible ad categories.
        /// </summary>
        public Task<ApiRequest<AdsGetCategoriesResponse>> GetCategoriesApi(string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<AdsGetCategoriesResponse>("ads.getCategories", null, request);
        }

        /// <summary>
        /// Returns a list of advertising agency's clients.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsClient>>> GetClientsApi(int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsClient>>("ads.getClients", null, request);
        }

        /// <summary>
        /// Returns demographics for ads or campaigns.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsDemoStats>>> GetDemographicsApi(int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ids_type"] = idsType,
                ["ids"] = ids,
                ["period"] = period,
                ["date_from"] = dateFrom,
                ["date_to"] = dateTo,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsDemoStats>>("ads.getDemographics", null, request);
        }

        /// <summary>
        /// Returns information about current state of a counter — number of remaining runs of methods and time to the next counter nulling in seconds.
        /// </summary>
        public Task<ApiRequest<AdsFloodStats>> GetFloodStatsApi(int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsFloodStats>("ads.getFloodStats", null, request);
        }

        /// <summary>
        /// Returns a list of managers and supervisors of advertising account.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsUsers>>> GetOfficeUsersApi(int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsUsers>>("ads.getOfficeUsers", null, request);
        }

        /// <summary>
        /// Returns detailed statistics of promoted posts reach from campaigns and ads.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsPromotedPostReach>>> GetPostsReachApi(int? accountId = null, string idsType = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ids_type"] = idsType,
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsPromotedPostReach>>("ads.getPostsReach", null, request);
        }

        /// <summary>
        /// Returns a reason of ad rejection for pre-moderation.
        /// </summary>
        public Task<ApiRequest<AdsRejectReason>> GetRejectionReasonApi(int? accountId = null, int? adId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ad_id"] = adId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsRejectReason>("ads.getRejectionReason", null, request);
        }

        /// <summary>
        /// Returns statistics of performance indicators for ads, campaigns, clients or the whole account.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsStats>>> GetStatisticsApi(int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ids_type"] = idsType,
                ["ids"] = ids,
                ["period"] = period,
                ["date_from"] = dateFrom,
                ["date_to"] = dateTo,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsStats>>("ads.getStatistics", null, request);
        }

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsTargSuggestions>>> GetSuggestionsApi(string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["cities"] = cities,
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestions>>("ads.getSuggestions", null, request);
        }

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsApi(string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["cities"] = cities,
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsRegions>>("ads.getSuggestions", null, request);
        }

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsApi(string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["cities"] = cities,
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsCities>>("ads.getSuggestions", null, request);
        }

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsApi(string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["cities"] = cities,
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsSchools>>("ads.getSuggestions", null, request);
        }

        /// <summary>
        /// Returns a list of target groups.
        /// </summary>
        public Task<ApiRequest<IEnumerable<AdsTargetGroup>>> GetTargetGroupsApi(int? accountId = null, int? clientId = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargetGroup>>("ads.getTargetGroups", null, request);
        }

        /// <summary>
        /// Returns the size of targeting audience, and also recommended values for CPC and CPM.
        /// </summary>
        public Task<ApiRequest<AdsTargStats>> GetTargetingStatsApi(int? accountId = null, int? clientId = null, string criteria = null, int? adId = null, int? adFormat = null, string adPlatform = null, string adPlatformNoWall = null, string adPlatformNoAdNetwork = null, string linkUrl = null, string linkDomain = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["criteria"] = criteria,
                ["ad_id"] = adId?.ToString(),
                ["ad_format"] = adFormat?.ToString(),
                ["ad_platform"] = adPlatform,
                ["ad_platform_no_wall"] = adPlatformNoWall,
                ["ad_platform_no_ad_network"] = adPlatformNoAdNetwork,
                ["link_url"] = linkUrl,
                ["link_domain"] = linkDomain,
            };

            return RequestManager.CreateRequestAsync<AdsTargStats>("ads.getTargetingStats", null, request);
        }

        /// <summary>
        /// Returns URL to upload an ad photo to.
        /// </summary>
        public Task<ApiRequest<string>> GetUploadURLApi(int? adFormat = null, int? icon = null)
        {
            var request = new Dictionary<string, string>
            {
                ["ad_format"] = adFormat?.ToString(),
                ["icon"] = icon?.ToString(),
            };

            return RequestManager.CreateRequestAsync<string>("ads.getUploadURL", null, request);
        }

        /// <summary>
        /// Returns URL to upload an ad video to.
        /// </summary>
        public Task<ApiRequest<string>> GetVideoUploadURLApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<string>("ads.getVideoUploadURL", null, request);
        }

        /// <summary>
        /// Imports a list of advertiser's contacts to count VK registered users against the target group.
        /// </summary>
        public Task<ApiRequest<int?>> ImportTargetContactsApi(int? accountId = null, int? clientId = null, int? targetGroupId = null, string contacts = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["target_group_id"] = targetGroupId?.ToString(),
                ["contacts"] = contacts,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.importTargetContacts", null, request);
        }

        /// <summary>
        /// Removes managers and/or supervisors from advertising account.
        /// </summary>
        public Task<ApiRequest<bool?>> RemoveOfficeUsersApi(int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.removeOfficeUsers", null, request);
        }

        /// <summary>
        /// Edits ads.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> UpdateAdsApi(int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("ads.updateAds", null, request);
        }

        /// <summary>
        /// Edits advertising campaigns.
        /// </summary>
        public Task<ApiRequest<int?>> UpdateCampaignsApi(int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.updateCampaigns", null, request);
        }

        /// <summary>
        /// Edits clients of an advertising agency.
        /// </summary>
        public Task<ApiRequest<int?>> UpdateClientsApi(int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.updateClients", null, request);
        }

        /// <summary>
        /// Edits a retarget group.
        /// </summary>
        public Task<ApiRequest<bool?>> UpdateTargetGroupApi(int? accountId = null, int? clientId = null, int? targetGroupId = null, string name = null, string domain = null, int? lifetime = null, int? targetPixelId = null, string targetPixelRules = null)
        {
            var request = new Dictionary<string, string>
            {
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["target_group_id"] = targetGroupId?.ToString(),
                ["name"] = name,
                ["domain"] = domain,
                ["lifetime"] = lifetime?.ToString(),
                ["target_pixel_id"] = targetPixelId?.ToString(),
                ["target_pixel_rules"] = targetPixelRules,
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.updateTargetGroup", null, request);
        }
    }
}
