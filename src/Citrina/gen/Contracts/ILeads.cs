using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface ILeadsApi
    {
        /// <summary>
        /// Checks if the user can start the lead.
        /// </summary>
        Task<ApiRequest<LeadsChecked>> CheckUserApi(int? leadId = null, int? testResult = null, bool? testMode = null, bool? autoStart = null, int? age = null, string country = null);

        /// <summary>
        /// Completes the lead started by user.
        /// </summary>
        Task<ApiRequest<LeadsComplete>> CompleteApi(string vkSid = null, string secret = null, string comment = null);

        /// <summary>
        /// Returns lead stats data.
        /// </summary>
        Task<ApiRequest<LeadsLead>> GetStatsApi(int? leadId = null, string secret = null, string dateStart = null, string dateEnd = null);

        /// <summary>
        /// Returns a list of last user actions for the offer.
        /// </summary>
        Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsersApi(int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null);

        /// <summary>
        /// Counts the metric event.
        /// </summary>
        Task<ApiRequest<LeadsMetricHitResponse>> MetricHitApi(string data = null);

        /// <summary>
        /// Creates new session for the user passing the offer.
        /// </summary>
        Task<ApiRequest<LeadsStart>> StartApi(int? leadId = null, string secret = null, int? uid = null, int? aid = null, bool? testMode = null, bool? force = null);
    }
}
