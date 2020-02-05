using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public enum NewsfeedIgnoreItemType
    {
        [EnumMember(Value = "wall")]
        PostOnTheWall,
        [EnumMember(Value = "tag")]
        TagOnAPhoto,
        [EnumMember(Value = "profilephoto")]
        ProfilePhoto,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "audio")]
        Audio,
    }
}
