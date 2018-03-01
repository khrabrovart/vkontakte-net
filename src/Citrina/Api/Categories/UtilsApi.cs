using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class UtilsApi : IUtilsApi
    {
        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(UserAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(GroupAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", null, request);
        }

        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(ServiceAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(UserAccessToken accessToken, string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(GroupAccessToken accessToken, string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", null, request);
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(ServiceAccessToken accessToken, string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", accessToken, request);
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(UserAccessToken accessToken, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", accessToken, request);
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(GroupAccessToken accessToken, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", accessToken, request);
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", null, request);
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(ServiceAccessToken accessToken, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", null, request);
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", null, request);
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(UserAccessToken accessToken, string url = null, bool? @private = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
                ["private"] = RequestHelpers.ParseBoolean(@private),
            };

            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(GroupAccessToken accessToken, string url = null, bool? @private = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
                ["private"] = RequestHelpers.ParseBoolean(@private),
            };

            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(string url = null, bool? @private = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
                ["private"] = RequestHelpers.ParseBoolean(@private),
            };

            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", null, request);
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(ServiceAccessToken accessToken, string url = null, bool? @private = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
                ["private"] = RequestHelpers.ParseBoolean(@private),
            };

            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(UserAccessToken accessToken, string screenName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["screen_name"] = screenName,
            };

            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", accessToken, request);
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(GroupAccessToken accessToken, string screenName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["screen_name"] = screenName,
            };

            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", accessToken, request);
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(string screenName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["screen_name"] = screenName,
            };

            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", null, request);
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(ServiceAccessToken accessToken, string screenName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["screen_name"] = screenName,
            };

            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetServerTime(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetServerTime(GroupAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetServerTime()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", null, request);
        }

        public Task<ApiRequest<int?>> GetServerTime(ServiceAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", accessToken, request);
        }

    }
}
