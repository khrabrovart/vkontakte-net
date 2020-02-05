using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Secure : ISecure
    {
        /// <summary>
        /// Adds user activity information to an application.
        /// </summary>
        public Task<ApiRequest<bool?>> AddAppEventApi(int? userId = null, int? activityId = null, int? value = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["activity_id"] = activityId?.ToString(),
                ["value"] = value?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.addAppEvent", null, request);
        }

        /// <summary>
        /// Checks the user authentication in 'IFrame' and 'Flash' apps using the 'access_token' parameter.
        /// </summary>
        public Task<ApiRequest<SecureTokenChecked>> CheckTokenApi(string token = null, string ip = null)
        {
            var request = new Dictionary<string, string>
            {
                ["token"] = token,
                ["ip"] = ip,
            };

            return RequestManager.CreateRequestAsync<SecureTokenChecked>("secure.checkToken", null, request);
        }

        /// <summary>
        /// Returns payment balance of the application in hundredth of a vote.
        /// </summary>
        public Task<ApiRequest<int?>> GetAppBalanceApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<int?>("secure.getAppBalance", null, request);
        }

        /// <summary>
        /// Shows a list of SMS notifications sent by the application using [vk.com/dev/secure.sendSMSNotification|secure.sendSMSNotification] method.
        /// </summary>
        public Task<ApiRequest<IEnumerable<SecureSmsNotification>>> GetSMSHistoryApi(int? userId = null, int? dateFrom = null, int? dateTo = null, int? limit = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["date_from"] = dateFrom?.ToString(),
                ["date_to"] = dateTo?.ToString(),
                ["limit"] = limit?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SecureSmsNotification>>("secure.getSMSHistory", null, request);
        }

        /// <summary>
        /// Shows history of votes transaction between users and the application.
        /// </summary>
        public Task<ApiRequest<IEnumerable<SecureTransaction>>> GetTransactionsHistoryApi(int? type = null, int? uidFrom = null, int? uidTo = null, int? dateFrom = null, int? dateTo = null, int? limit = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type?.ToString(),
                ["uid_from"] = uidFrom?.ToString(),
                ["uid_to"] = uidTo?.ToString(),
                ["date_from"] = dateFrom?.ToString(),
                ["date_to"] = dateTo?.ToString(),
                ["limit"] = limit?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SecureTransaction>>("secure.getTransactionsHistory", null, request);
        }

        /// <summary>
        /// Returns one of the previously set game levels of one or more users in the application.
        /// </summary>
        public Task<ApiRequest<IEnumerable<SecureLevel>>> GetUserLevelApi(IEnumerable<int> userIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SecureLevel>>("secure.getUserLevel", null, request);
        }

        /// <summary>
        /// Opens the game achievement and gives the user a sticker.
        /// </summary>
        public Task<ApiRequest<IEnumerable<object>>> GiveEventStickerApi(IEnumerable<int> userIds = null, int? achievementId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["achievement_id"] = achievementId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<object>>("secure.giveEventSticker", null, request);
        }

        /// <summary>
        /// Sends notification to the user.
        /// </summary>
        public Task<ApiRequest<IEnumerable<int>>> SendNotificationApi(IEnumerable<int> userIds = null, int? userId = null, string message = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["user_id"] = userId?.ToString(),
                ["message"] = message,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int>>("secure.sendNotification", null, request);
        }

        /// <summary>
        /// Sends 'SMS' notification to a user's mobile device.
        /// </summary>
        public Task<ApiRequest<bool?>> SendSMSNotificationApi(int? userId = null, string message = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["message"] = message,
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.sendSMSNotification", null, request);
        }

        /// <summary>
        /// Sets a counter which is shown to the user in bold in the left menu.
        /// </summary>
        public Task<ApiRequest<bool?>> SetCounterApi(IEnumerable<string> counters = null, int? userId = null, int? counter = null, bool? increment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["counters"] = RequestHelpers.ParseEnumerable(counters),
                ["user_id"] = userId?.ToString(),
                ["counter"] = counter?.ToString(),
                ["increment"] = RequestHelpers.ParseBoolean(increment),
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.setCounter", null, request);
        }
    }
}
