using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class NotificationsApi : INotificationsApi
    {
        public Task<ApiRequest<NotificationsGetResponse>> Get(UserAccessToken accessToken, int? count = null, string startFrom = null, IEnumerable<string> filters = null, DateTime? startTime = null, DateTime? endTime = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["start_from"] = startFrom,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
            };

            return RequestManager.CreateRequestAsync<NotificationsGetResponse>("notifications.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MarkAsViewed(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<bool?>("notifications.markAsViewed", accessToken, request);
        }
    }
}
