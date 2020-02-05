using System.Runtime.Serialization;

namespace Citrina
{
    public enum AccountInfoField
    {
        [EnumMember(Value = "country")]
        Country,
        [EnumMember(Value = "https_required")]
        HttpsRequired,
        [EnumMember(Value = "own_posts_default")]
        OwnPostsDefault,
        [EnumMember(Value = "no_wall_replies")]
        NoWallReplies,
        [EnumMember(Value = "intro")]
        Intro,
        [EnumMember(Value = "lang")]
        Lang,
    }
}
