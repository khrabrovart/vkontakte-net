using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class LeadsApi : ILeadsApi
    {
        public Task<ApiRequest<LeadsComplete>> Complete(UserAccessToken accessToken, string vkSid = null, string secret = null, string comment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["vk_sid"] = vkSid,
                ["secret"] = secret,
                ["comment"] = comment,
            };

            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", accessToken, request);
        }

        public Task<ApiRequest<LeadsComplete>> Complete(string vkSid = null, string secret = null, string comment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["vk_sid"] = vkSid,
                ["secret"] = secret,
                ["comment"] = comment,
            };

            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", null, request);
        }

        public Task<ApiRequest<LeadsComplete>> Complete(ServiceAccessToken accessToken, string vkSid = null, string secret = null, string comment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["vk_sid"] = vkSid,
                ["secret"] = secret,
                ["comment"] = comment,
            };

            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", accessToken, request);
        }

        public Task<ApiRequest<LeadsStart>> Start(UserAccessToken accessToken, int? leadId = null, string secret = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
            };

            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", accessToken, request);
        }

        public Task<ApiRequest<LeadsStart>> Start(int? leadId = null, string secret = null)
        {
            var request = new Dictionary<string, string>
            {
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
            };

            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", null, request);
        }

        public Task<ApiRequest<LeadsStart>> Start(ServiceAccessToken accessToken, int? leadId = null, string secret = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
            };

            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", accessToken, request);
        }

        public Task<ApiRequest<LeadsLead>> GetStats(UserAccessToken accessToken, int? leadId = null, string secret = null, string dateStart = null, string dateEnd = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
                ["date_start"] = dateStart,
                ["date_end"] = dateEnd,
            };

            return RequestManager.CreateRequestAsync<LeadsLead>("leads.getStats", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(UserAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offer_id"] = offerId?.ToString(),
                ["secret"] = secret,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["status"] = status?.ToString(),
                ["reverse"] = RequestHelpers.ParseBoolean(reverse),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<LeadsEntry>>("leads.getUsers", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
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

        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(ServiceAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offer_id"] = offerId?.ToString(),
                ["secret"] = secret,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["status"] = status?.ToString(),
                ["reverse"] = RequestHelpers.ParseBoolean(reverse),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<LeadsEntry>>("leads.getUsers", accessToken, request);
        }

        public Task<ApiRequest<LeadsChecked>> CheckUser(UserAccessToken accessToken, int? leadId = null, int? testResult = null, int? age = null, string country = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lead_id"] = leadId?.ToString(),
                ["test_result"] = testResult?.ToString(),
                ["age"] = age?.ToString(),
                ["country"] = country,
            };

            return RequestManager.CreateRequestAsync<LeadsChecked>("leads.checkUser", accessToken, request);
        }

        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(UserAccessToken accessToken, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", accessToken, request);
        }

        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", null, request);
        }

        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(ServiceAccessToken accessToken, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", accessToken, request);
        }

    }
}
