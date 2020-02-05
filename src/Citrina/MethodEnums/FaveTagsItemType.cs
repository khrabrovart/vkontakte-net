using System.Runtime.Serialization;

namespace Citrina
{
    public enum FaveTagsItemType
    {
        [EnumMember(Value = "article")]
        Article,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "narrative")]
        Narrative,
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "podcast")]
        Podcast,
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "product")]
        Product,
        [EnumMember(Value = "video")]
        Video,
    }
}
