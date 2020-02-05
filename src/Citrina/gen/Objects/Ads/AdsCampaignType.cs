using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Campaign type.
    /// </summary>
    public enum AdsCampaignType
    {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "vk_apps_managed")]
        VkAppsManaged,
        [EnumMember(Value = "mobile_apps")]
        MobileApps,
        [EnumMember(Value = "promoted_posts")]
        PromotedPosts,
    }
}
