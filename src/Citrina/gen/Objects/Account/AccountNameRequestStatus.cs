using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Request status.
    /// </summary>
    public enum AccountNameRequestStatus
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "was_accepted")]
        WasAccepted,
        [EnumMember(Value = "was_declined")]
        WasDeclined,
    }
}
