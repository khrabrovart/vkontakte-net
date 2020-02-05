using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Status : IStatus
    {
        /// <summary>
        /// Returns data required to show the status of a user or community.
        /// </summary>
        public Task<ApiRequest<StatusStatus>> GetApi(int? userId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<StatusStatus>("status.get", null, request);
        }

        /// <summary>
        /// Sets a new status for the current user.
        /// </summary>
        public Task<ApiRequest<bool?>> SetApi(string text = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["text"] = text,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("status.set", null, request);
        }
    }
}
