using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Leads : ILeads
    {
        /// <summary>
        /// Checks if the user can start the lead.
        /// </summary>
        public Task<ApiRequest<LeadsChecked>> CheckUserApi(int? leadId = null, int? testResult = null, bool? testMode = null, bool? autoStart = null, int? age = null, string country = null)
        {
            var request = new Dictionary<string, string>
            {
                ["lead_id"] = leadId?.ToString(),
                ["test_result"] = testResult?.ToString(),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["auto_start"] = RequestHelpers.ParseBoolean(autoStart),
                ["age"] = age?.ToString(),
                ["country"] = country,
            };

            return RequestManager.CreateRequestAsync<LeadsChecked>("leads.checkUser", null, request);
        }

        /// <summary>
        /// Completes the lead started by user.
        /// </summary>
        public Task<ApiRequest<LeadsComplete>> CompleteApi(string vkSid = null, string secret = null, string comment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["vk_sid"] = vkSid,
                ["secret"] = secret,
                ["comment"] = comment,
            };

            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", null, request);
        }

        /// <summary>
        /// Returns lead stats data.
        /// </summary>
        public Task<ApiRequest<LeadsLead>> GetStatsApi(int? leadId = null, string secret = null, string dateStart = null, string dateEnd = null)
        {
            var request = new Dictionary<string, string>
            {
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
                ["date_start"] = dateStart,
                ["date_end"] = dateEnd,
            };

            return RequestManager.CreateRequestAsync<LeadsLead>("leads.getStats", null, request);
        }

        /// <summary>
        /// Returns a list of last user actions for the offer.
        /// </summary>
        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsersApi(int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offer_id"] = offerId?.ToString(),
                ["secret"] = secret,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["status"] = status?.ToString(),
                ["reverse"] = RequestHelpers.ParseBoolean(reverse),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<LeadsEntry>>("leads.getUsers", null, request);
        }

        /// <summary>
        /// Counts the metric event.
        /// </summary>
        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHitApi(string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", null, request);
        }

        /// <summary>
        /// Creates new session for the user passing the offer.
        /// </summary>
        public Task<ApiRequest<LeadsStart>> StartApi(int? leadId = null, string secret = null, int? uid = null, int? aid = null, bool? testMode = null, bool? force = null)
        {
            var request = new Dictionary<string, string>
            {
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
                ["uid"] = uid?.ToString(),
                ["aid"] = aid?.ToString(),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["force"] = RequestHelpers.ParseBoolean(force),
            };

            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", null, request);
        }
    }
}
