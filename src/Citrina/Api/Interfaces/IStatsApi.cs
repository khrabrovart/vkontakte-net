using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IStatsApi
    {
        /// <summary>
        /// Returns statistics of a community or an application.
        /// </summary>
        Task<ApiRequest<IEnumerable<StatsPeriod>>> Get(UserAccessToken accessToken, int? groupId = null, int? appId = null, string dateFrom = null, string dateTo = null);
        Task<ApiRequest<bool?>> TrackVisitor(UserAccessToken accessToken);
        /// <summary>
        /// Returns stats for a wall post.
        /// </summary>
        Task<ApiRequest<IEnumerable<StatsWallpostStat>>> GetPostReach(UserAccessToken accessToken, int? ownerId = null, int? postId = null);
    }
}
