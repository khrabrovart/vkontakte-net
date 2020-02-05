using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Link status.
    /// </summary>
    public enum UtilsLinkCheckedStatus
    {
        [EnumMember(Value = "not_banned")]
        NotBanned,
        [EnumMember(Value = "banned")]
        Banned,
        [EnumMember(Value = "processing")]
        Processing,
    }
}
