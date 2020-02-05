using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Utils : IUtils
    {
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        public Task<ApiRequest<UtilsLinkChecked>> CheckLinkApi(string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", null, request);
        }

        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        public Task<ApiRequest<bool?>> DeleteFromLastShortenedApi(string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", null, request);
        }

        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinksApi(int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", null, request);
        }

        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        public Task<ApiRequest<UtilsLinkStats>> GetLinkStatsApi(string key = null, string source = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
                ["source"] = source,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", null, request);
        }

        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsApi(string key = null, string source = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
                ["source"] = source,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", null, request);
        }

        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        public Task<ApiRequest<int?>> GetServerTimeApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", null, request);
        }

        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        public Task<ApiRequest<UtilsShortLink>> GetShortLinkApi(string url = null, bool? @private = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
                ["private"] = RequestHelpers.ParseBoolean(@private),
            };

            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", null, request);
        }

        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenNameApi(string screenName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["screen_name"] = screenName,
            };

            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", null, request);
        }
    }
}
