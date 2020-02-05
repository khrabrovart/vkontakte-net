using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Community type.
    /// </summary>
    public enum GroupsGroupXtrInvitedByType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "event")]
        Event,
    }
}
