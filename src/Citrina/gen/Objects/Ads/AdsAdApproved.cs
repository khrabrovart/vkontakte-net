using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Review status.
    /// </summary>
    public enum AdsAdApproved
    {
        NotModerated,
        PendingModeration,
        Approved,
        Rejected,
    }
}
