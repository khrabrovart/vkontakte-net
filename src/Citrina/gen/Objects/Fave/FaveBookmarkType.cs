using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public enum FaveBookmarkType
    {
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "product")]
        Product,
        [EnumMember(Value = "article")]
        Article,
        [EnumMember(Value = "link")]
        Link,
    }
}
