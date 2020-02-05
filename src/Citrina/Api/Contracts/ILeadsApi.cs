using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface ILeadsApi
    {
        /// <summary>
        /// Completes the lead started by user.
        /// </summary>
        Task<ApiRequest<LeadsComplete>> Complete(UserAccessToken accessToken, string vkSid = null, string secret = null, string comment = null);
        /// <summary>
        /// Completes the lead started by user.
        /// </summary>
        Task<ApiRequest<LeadsComplete>> Complete(string vkSid = null, string secret = null, string comment = null);
        /// <summary>
        /// Completes the lead started by user.
        /// </summary>
        Task<ApiRequest<LeadsComplete>> Complete(ServiceAccessToken accessToken, string vkSid = null, string secret = null, string comment = null);
        /// <summary>
        /// Creates new session for the user passing the offer.
        /// </summary>
        Task<ApiRequest<LeadsStart>> Start(UserAccessToken accessToken, int? leadId = null, string secret = null);
        /// <summary>
        /// Creates new session for the user passing the offer.
        /// </summary>
        Task<ApiRequest<LeadsStart>> Start(int? leadId = null, string secret = null);
        /// <summary>
        /// Creates new session for the user passing the offer.
        /// </summary>
        Task<ApiRequest<LeadsStart>> Start(ServiceAccessToken accessToken, int? leadId = null, string secret = null);
        /// <summary>
        /// Returns lead stats data.
        /// </summary>
        Task<ApiRequest<LeadsLead>> GetStats(UserAccessToken accessToken, int? leadId = null, string secret = null, string dateStart = null, string dateEnd = null);
        /// <summary>
        /// Returns a list of last user actions for the offer.
        /// </summary>
        Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(UserAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null);
        /// <summary>
        /// Returns a list of last user actions for the offer.
        /// </summary>
        Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null);
        /// <summary>
        /// Returns a list of last user actions for the offer.
        /// </summary>
        Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(ServiceAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null);
        /// <summary>
        /// Checks if the user can start the lead.
        /// </summary>
        Task<ApiRequest<LeadsChecked>> CheckUser(UserAccessToken accessToken, int? leadId = null, int? testResult = null, int? age = null, string country = null);
        /// <summary>
        /// Counts the metric event.
        /// </summary>
        Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(UserAccessToken accessToken, string data = null);
        /// <summary>
        /// Counts the metric event.
        /// </summary>
        Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(string data = null);
        /// <summary>
        /// Counts the metric event.
        /// </summary>
        Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(ServiceAccessToken accessToken, string data = null);
    }
}
