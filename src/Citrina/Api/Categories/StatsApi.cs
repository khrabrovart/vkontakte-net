using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class StatsApi : IStatsApi
    {
        public Task<ApiRequest<IEnumerable<StatsPeriod>>> Get(UserAccessToken accessToken, int? groupId = null, int? appId = null, string dateFrom = null, string dateTo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["app_id"] = appId?.ToString(),
                ["date_from"] = dateFrom,
                ["date_to"] = dateTo,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<StatsPeriod>>("stats.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> TrackVisitor(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<bool?>("stats.trackVisitor", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<StatsWallpostStat>>> GetPostReach(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<StatsWallpostStat>>("stats.getPostReach", accessToken, request);
        }
    }
}
