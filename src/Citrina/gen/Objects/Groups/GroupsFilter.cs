using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public enum GroupsFilter
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "editor")]
        Editor,
        [EnumMember(Value = "moder")]
        Moder,
        [EnumMember(Value = "groups")]
        Groups,
        [EnumMember(Value = "publics")]
        Publics,
        [EnumMember(Value = "events")]
        Events,
        [EnumMember(Value = "has_addresses")]
        HasAddresses,
    }
}
