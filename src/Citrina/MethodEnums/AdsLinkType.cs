using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Object type: *'community' — community,, *'post' — community post,, *'application' — VK application,, *'video' — video,, *'site' — external site.
    /// </summary>
    public enum AdsLinkType
    {
        [EnumMember(Value = "community")]
        Community,
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "site")]
        Site,
    }
}
