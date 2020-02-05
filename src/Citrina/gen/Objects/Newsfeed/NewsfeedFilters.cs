using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public enum NewsfeedFilters
    {
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "photo_tag")]
        PhotoTag,
        [EnumMember(Value = "wall_photo")]
        WallPhoto,
        [EnumMember(Value = "friend")]
        Friend,
        [EnumMember(Value = "note")]
        Note,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "video")]
        Video,
    }
}
