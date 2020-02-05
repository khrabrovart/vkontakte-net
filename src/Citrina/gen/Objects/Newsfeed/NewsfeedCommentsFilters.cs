using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public enum NewsfeedCommentsFilters
    {
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "topic")]
        Topic,
        [EnumMember(Value = "note")]
        Note,
    }
}
