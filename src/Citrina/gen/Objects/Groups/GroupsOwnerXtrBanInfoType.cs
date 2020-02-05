using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Owner type.
    /// </summary>
    public enum GroupsOwnerXtrBanInfoType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "profile")]
        Profile,
    }
}
