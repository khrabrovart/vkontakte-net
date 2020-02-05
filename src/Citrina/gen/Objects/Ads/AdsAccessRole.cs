using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Current user's role.
    /// </summary>
    public enum AdsAccessRole
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "manager")]
        Manager,
        [EnumMember(Value = "reports")]
        Reports,
    }
}
