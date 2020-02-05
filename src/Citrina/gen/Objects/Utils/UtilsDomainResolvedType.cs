using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Object type.
    /// </summary>
    public enum UtilsDomainResolvedType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "page")]
        Page,
    }
}
