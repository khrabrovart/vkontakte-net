using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Object type.
    /// </summary>
    public enum SearchHintType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "profile")]
        Profile,
        [EnumMember(Value = "vk_app")]
        VkApp,
    }
}
