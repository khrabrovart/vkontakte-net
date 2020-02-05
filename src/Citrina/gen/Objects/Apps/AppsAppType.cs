using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Application type.
    /// </summary>
    public enum AppsAppType
    {
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "game")]
        Game,
        [EnumMember(Value = "site")]
        Site,
        [EnumMember(Value = "standalone")]
        Standalone,
        [EnumMember(Value = "vk_app")]
        VkApp,
        [EnumMember(Value = "community_app")]
        CommunityApp,
        [EnumMember(Value = "html5_game")]
        Html5Game,
    }
}
