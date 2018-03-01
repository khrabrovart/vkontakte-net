using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class StatusApi : IStatusApi
    {
        public Task<ApiRequest<StatusStatus>> Get(UserAccessToken accessToken, int? userId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<StatusStatus>("status.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string text = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["text"] = text,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("status.set", accessToken, request);
        }
    }
}
