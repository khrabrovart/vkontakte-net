using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IStatsApi
    {
        /// <summary>
        /// Returns statistics of a community or an application.
        /// </summary>
        Task<ApiRequest<IEnumerable<StatsPeriod>>> GetApi(int? groupId = null, int? appId = null, int? timestampFrom = null, int? timestampTo = null, string interval = null, int? intervalsCount = null, IEnumerable<string> filters = null, IEnumerable<string> statsGroups = null, bool? extended = null);

        /// <summary>
        /// Returns stats for a wall post.
        /// </summary>
        Task<ApiRequest<IEnumerable<StatsWallpostStat>>> GetPostReachApi(string ownerId = null, int? postId = null);

        Task<ApiRequest<bool?>> TrackVisitorApi(string id = null);
    }
}
