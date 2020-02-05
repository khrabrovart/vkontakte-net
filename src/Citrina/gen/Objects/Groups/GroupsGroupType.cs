using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Community type.
    /// </summary>
    public enum GroupsGroupType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "event")]
        Event,
    }
}
