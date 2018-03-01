using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface INotificationsApi
    {
        /// <summary>
        /// Returns a list of notifications about other users' feedback to the current user's wall posts.
        /// </summary>
        Task<ApiRequest<NotificationsGetResponse>> Get(UserAccessToken accessToken, int? count = null, string startFrom = null, IEnumerable<string> filters = null, DateTime? startTime = null, DateTime? endTime = null);
        /// <summary>
        /// Resets the counter of new notifications about other users' feedback to the current user's wall posts.
        /// </summary>
        Task<ApiRequest<bool?>> MarkAsViewed(UserAccessToken accessToken);
    }
}
