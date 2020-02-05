using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Stats : IStats
    {
        /// <summary>
        /// Returns statistics of a community or an application.
        /// </summary>
        public Task<ApiRequest<IEnumerable<StatsPeriod>>> GetApi(int? groupId = null, int? appId = null, int? timestampFrom = null, int? timestampTo = null, string interval = null, int? intervalsCount = null, IEnumerable<string> filters = null, IEnumerable<string> statsGroups = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["app_id"] = appId?.ToString(),
                ["timestamp_from"] = timestampFrom?.ToString(),
                ["timestamp_to"] = timestampTo?.ToString(),
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["stats_groups"] = RequestHelpers.ParseEnumerable(statsGroups),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<StatsPeriod>>("stats.get", null, request);
        }

        /// <summary>
        /// Returns stats for a wall post.
        /// </summary>
        public Task<ApiRequest<IEnumerable<StatsWallpostStat>>> GetPostReachApi(string ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId,
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<StatsWallpostStat>>("stats.getPostReach", null, request);
        }

        public Task<ApiRequest<bool?>> TrackVisitorApi(string id = null)
        {
            var request = new Dictionary<string, string>
            {
                ["id"] = id,
            };

            return RequestManager.CreateRequestAsync<bool?>("stats.trackVisitor", null, request);
        }
    }
}
