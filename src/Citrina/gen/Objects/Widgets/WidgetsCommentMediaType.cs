using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Media type.
    /// </summary>
    public enum WidgetsCommentMediaType
    {
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "video")]
        Video,
    }
}
