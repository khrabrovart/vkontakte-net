using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IUtilsApi
    {
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        Task<ApiRequest<UtilsLinkChecked>> CheckLinkApi(string url = null);

        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteFromLastShortenedApi(string key = null);

        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinksApi(int? count = null, int? offset = null);

        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStats>> GetLinkStatsApi(string key = null, string source = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);

        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsApi(string key = null, string source = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);

        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        Task<ApiRequest<int?>> GetServerTimeApi();

        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        Task<ApiRequest<UtilsShortLink>> GetShortLinkApi(string url = null, bool? @private = null);

        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        Task<ApiRequest<UtilsDomainResolved>> ResolveScreenNameApi(string screenName = null);
    }
}
