using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Object type.
    /// </summary>
    public enum AdsObjectType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "campaign")]
        Campaign,
        [EnumMember(Value = "client")]
        Client,
        [EnumMember(Value = "office")]
        Office,
    }
}
