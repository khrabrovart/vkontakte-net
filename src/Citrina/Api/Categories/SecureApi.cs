using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class SecureApi : ISecureApi
    {
        public Task<ApiRequest<int?>> GetAppBalance(ServiceAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<int?>("secure.getAppBalance", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<SecureTransaction>>> GetTransactionsHistory(ServiceAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SecureTransaction>>("secure.getTransactionsHistory", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<SecureSmsNotification>>> GetSMSHistory(ServiceAccessToken accessToken, int? userId = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? limit = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["date_from"] = RequestHelpers.ParseDateTime(dateFrom),
                ["date_to"] = RequestHelpers.ParseDateTime(dateTo),
                ["limit"] = limit?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SecureSmsNotification>>("secure.getSMSHistory", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SendSMSNotification(ServiceAccessToken accessToken, int? userId = null, string message = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["message"] = message,
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.sendSMSNotification", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> SendNotification(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null, int? userId = null, string message = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["user_id"] = userId?.ToString(),
                ["message"] = message,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("secure.sendNotification", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetCounter(ServiceAccessToken accessToken, IEnumerable<string> counters = null, int? userId = null, int? counter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["counters"] = RequestHelpers.ParseEnumerable(counters),
                ["user_id"] = userId?.ToString(),
                ["counter"] = counter?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.setCounter", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetUserLevel(ServiceAccessToken accessToken, IEnumerable<string> levels = null, int? userId = null, int? level = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["levels"] = RequestHelpers.ParseEnumerable(levels),
                ["user_id"] = userId?.ToString(),
                ["level"] = level?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.setUserLevel", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<SecureLevel>>> GetUserLevel(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SecureLevel>>("secure.getUserLevel", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddAppEvent(UserAccessToken accessToken, int? userId = null, int? activityId = null, int? value = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["activity_id"] = activityId?.ToString(),
                ["value"] = value?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.addAppEvent", accessToken, request);
        }

        public Task<ApiRequest<SecureTokenChecked>> CheckToken(UserAccessToken accessToken, string token = null, string ip = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["token"] = token,
                ["ip"] = ip,
            };

            return RequestManager.CreateRequestAsync<SecureTokenChecked>("secure.checkToken", accessToken, request);
        }

    }
}
