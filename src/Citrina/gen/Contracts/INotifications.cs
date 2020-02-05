using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface INotificationsApi
    {
        /// <summary>
        /// Returns a list of notifications about other users' feedback to the current user's wall posts.
        /// </summary>
        Task<ApiRequest<NotificationsGetResponse>> GetApi(int? count = null, string startFrom = null, IEnumerable<string> filters = null, int? startTime = null, int? endTime = null);

        /// <summary>
        /// Resets the counter of new notifications about other users' feedback to the current user's wall posts.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsViewedApi();

        Task<ApiRequest<IEnumerable<NotificationsSendMessageItem>>> SendMessageApi(IEnumerable<int> userIds = null, string message = null, string fragment = null, int? groupId = null);
    }
}
