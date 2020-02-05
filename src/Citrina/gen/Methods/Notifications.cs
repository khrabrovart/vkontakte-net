using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Notifications : INotifications
    {
        /// <summary>
        /// Returns a list of notifications about other users' feedback to the current user's wall posts.
        /// </summary>
        public Task<ApiRequest<NotificationsGetResponse>> GetApi(int? count = null, string startFrom = null, IEnumerable<string> filters = null, int? startTime = null, int? endTime = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["start_from"] = startFrom,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NotificationsGetResponse>("notifications.get", null, request);
        }

        /// <summary>
        /// Resets the counter of new notifications about other users' feedback to the current user's wall posts.
        /// </summary>
        public Task<ApiRequest<bool?>> MarkAsViewedApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<bool?>("notifications.markAsViewed", null, request);
        }

        public Task<ApiRequest<IEnumerable<NotificationsSendMessageItem>>> SendMessageApi(IEnumerable<int> userIds = null, string message = null, string fragment = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["message"] = message,
                ["fragment"] = fragment,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<NotificationsSendMessageItem>>("notifications.sendMessage", null, request);
        }
    }
}
