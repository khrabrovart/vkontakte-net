using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IStatusApi
    {
        /// <summary>
        /// Returns data required to show the status of a user or community.
        /// </summary>
        Task<ApiRequest<StatusStatus>> Get(UserAccessToken accessToken, int? userId = null, int? groupId = null);
        /// <summary>
        /// Sets a new status for the current user.
        /// </summary>
        Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string text = null, int? groupId = null);
    }
}
