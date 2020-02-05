using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IStatusApi
    {
        /// <summary>
        /// Returns data required to show the status of a user or community.
        /// </summary>
        Task<ApiRequest<StatusStatus>> GetApi(int? userId = null, int? groupId = null);

        /// <summary>
        /// Sets a new status for the current user.
        /// </summary>
        Task<ApiRequest<bool?>> SetApi(string text = null, int? groupId = null);
    }
}
