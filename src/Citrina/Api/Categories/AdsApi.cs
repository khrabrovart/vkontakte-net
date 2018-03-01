using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class AdsApi : IAdsApi
    {
        public Task<ApiRequest<IEnumerable<AdsAccount>>> GetAccounts(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsAccount>>("ads.getAccounts", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsClient>>> GetClients(UserAccessToken accessToken, int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsClient>>("ads.getClients", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> CreateClients(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.createClients", accessToken, request);
        }

        public Task<ApiRequest<int?>> UpdateClients(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.updateClients", accessToken, request);
        }

        public Task<ApiRequest<int?>> DeleteClients(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.deleteClients", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsCampaign>>> GetCampaigns(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["campaign_ids"] = campaignIds,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsCampaign>>("ads.getCampaigns", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> CreateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.createCampaigns", accessToken, request);
        }

        public Task<ApiRequest<int?>> UpdateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.updateCampaigns", accessToken, request);
        }

        public Task<ApiRequest<int?>> DeleteCampaigns(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.deleteCampaigns", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsAd>>> GetAds(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["campaign_ids"] = campaignIds,
                ["ad_ids"] = adIds,
                ["limit"] = limit?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsAd>>("ads.getAds", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsAdLayout>>> GetAdsLayout(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["campaign_ids"] = campaignIds,
                ["ad_ids"] = adIds,
                ["limit"] = limit?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsAdLayout>>("ads.getAdsLayout", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSettings>>> GetAdsTargeting(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["campaign_ids"] = campaignIds,
                ["ad_ids"] = adIds,
                ["limit"] = limit?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSettings>>("ads.getAdsTargeting", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> CreateAds(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.createAds", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> UpdateAds(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.updateAds", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> DeleteAds(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.deleteAds", accessToken, request);
        }

        public Task<ApiRequest<AdsLinkStatus>> CheckLink(UserAccessToken accessToken, int? accountId = null, string linkType = null, string linkUrl = null, int? campaignId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["link_type"] = linkType,
                ["link_url"] = linkUrl,
                ["campaign_id"] = campaignId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsLinkStatus>("ads.checkLink", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsStats>>> GetStatistics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids_type"] = idsType,
                ["ids"] = ids,
                ["period"] = period,
                ["date_from"] = dateFrom,
                ["date_to"] = dateTo,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsStats>>("ads.getStatistics", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsDemoStats>>> GetDemographics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids_type"] = idsType,
                ["ids"] = ids,
                ["period"] = period,
                ["date_from"] = dateFrom,
                ["date_to"] = dateTo,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsDemoStats>>("ads.getDemographics", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsPostStats>>> GetAdsPostsReach(UserAccessToken accessToken, int? accountId = null, string adsIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ads_ids"] = adsIds,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsPostStats>>("ads.getAdsPostsReach", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetBudget(UserAccessToken accessToken, int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("ads.getBudget", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsUsers>>> GetOfficeUsers(UserAccessToken accessToken, int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsUsers>>("ads.getOfficeUsers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddOfficeUsers(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.addOfficeUsers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveOfficeUsers(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.removeOfficeUsers", accessToken, request);
        }

        public Task<ApiRequest<AdsTargStats>> GetTargetingStats(UserAccessToken accessToken, int? accountId = null, string criteria = null, int? adId = null, int? adFormat = null, string adPlatform = null, string linkUrl = null, string linkDomain = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["criteria"] = criteria,
                ["ad_id"] = adId?.ToString(),
                ["ad_format"] = adFormat?.ToString(),
                ["ad_platform"] = adPlatform,
                ["link_url"] = linkUrl,
                ["link_domain"] = linkDomain,
            };

            return RequestManager.CreateRequestAsync<AdsTargStats>("ads.getTargetingStats", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestions>>> GetSuggestions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestions>>("ads.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsRegions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsRegions>>("ads.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsCities(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["cities"] = cities,
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsCities>>("ads.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsSchools(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsSchools>>("ads.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<AdsGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<AdsGetCategoriesResponse>("ads.getCategories", accessToken, request);
        }

        public Task<ApiRequest<string>> GetUploadURL(UserAccessToken accessToken, int? adFormat = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["ad_format"] = adFormat?.ToString(),
            };

            return RequestManager.CreateRequestAsync<string>("ads.getUploadURL", accessToken, request);
        }

        public Task<ApiRequest<string>> GetVideoUploadURL()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<string>("ads.getVideoUploadURL", null, request);
        }

        public Task<ApiRequest<AdsFloodStats>> GetFloodStats(UserAccessToken accessToken, int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsFloodStats>("ads.getFloodStats", accessToken, request);
        }

        public Task<ApiRequest<AdsRejectReason>> GetRejectionReason(UserAccessToken accessToken, int? accountId = null, int? adId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ad_id"] = adId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsRejectReason>("ads.getRejectionReason", accessToken, request);
        }

        public Task<ApiRequest<AdsCreateTargetGroupResponse>> CreateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, string name = null, string domain = null, int? lifetime = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["name"] = name,
                ["domain"] = domain,
                ["lifetime"] = lifetime?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsCreateTargetGroupResponse>("ads.createTargetGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> UpdateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string name = null, string domain = null, int? lifetime = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["target_group_id"] = targetGroupId?.ToString(),
                ["name"] = name,
                ["domain"] = domain,
                ["lifetime"] = lifetime?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.updateTargetGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["target_group_id"] = targetGroupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.deleteTargetGroup", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargetGroup>>> GetTargetGroups(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargetGroup>>("ads.getTargetGroups", accessToken, request);
        }

        public Task<ApiRequest<int?>> ImportTargetContacts(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string contacts = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["target_group_id"] = targetGroupId?.ToString(),
                ["contacts"] = contacts,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.importTargetContacts", accessToken, request);
        }

    }
}
