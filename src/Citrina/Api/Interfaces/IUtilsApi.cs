using System.Threading.Tasks;

namespace Citrina
{
    public interface IUtilsApi
    {
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        Task<ApiRequest<UtilsLinkChecked>> CheckLink(UserAccessToken accessToken, string url = null);
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        Task<ApiRequest<UtilsLinkChecked>> CheckLink(GroupAccessToken accessToken, string url = null);
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        Task<ApiRequest<UtilsLinkChecked>> CheckLink(string url = null);
        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// </summary>
        Task<ApiRequest<UtilsLinkChecked>> CheckLink(ServiceAccessToken accessToken, string url = null);
        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteFromLastShortened(UserAccessToken accessToken, string key = null);
        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteFromLastShortened(GroupAccessToken accessToken, string key = null);
        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteFromLastShortened(string key = null);
        /// <summary>
        /// Deletes shortened link from user's list.
        /// </summary>
        Task<ApiRequest<bool?>> DeleteFromLastShortened(ServiceAccessToken accessToken, string key = null);
        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(UserAccessToken accessToken, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(GroupAccessToken accessToken, int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(int? count = null, int? offset = null);
        /// <summary>
        /// Returns a list of user's shortened links.
        /// </summary>
        Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(ServiceAccessToken accessToken, int? count = null, int? offset = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStats>> GetLinkStats(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStats>> GetLinkStats(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStats>> GetLinkStats(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStats>> GetLinkStats(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null);
        /// <summary>
        /// Returns stats data for shortened link.
        /// </summary>
        Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null);
        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        Task<ApiRequest<UtilsShortLink>> GetShortLink(UserAccessToken accessToken, string url = null, bool? @private = null);
        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        Task<ApiRequest<UtilsShortLink>> GetShortLink(GroupAccessToken accessToken, string url = null, bool? @private = null);
        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        Task<ApiRequest<UtilsShortLink>> GetShortLink(string url = null, bool? @private = null);
        /// <summary>
        /// Allows to receive a link shortened via vk.cc.
        /// </summary>
        Task<ApiRequest<UtilsShortLink>> GetShortLink(ServiceAccessToken accessToken, string url = null, bool? @private = null);
        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(UserAccessToken accessToken, string screenName = null);
        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(GroupAccessToken accessToken, string screenName = null);
        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(string screenName = null);
        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// </summary>
        Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(ServiceAccessToken accessToken, string screenName = null);
        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        Task<ApiRequest<int?>> GetServerTime(UserAccessToken accessToken);
        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        Task<ApiRequest<int?>> GetServerTime(GroupAccessToken accessToken);
        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        Task<ApiRequest<int?>> GetServerTime();
        /// <summary>
        /// Returns the current time of the VK server.
        /// </summary>
        Task<ApiRequest<int?>> GetServerTime(ServiceAccessToken accessToken);
    }
}
