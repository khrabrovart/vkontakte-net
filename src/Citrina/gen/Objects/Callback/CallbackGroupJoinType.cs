using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public enum CallbackGroupJoinType
    {
        [EnumMember(Value = "join")]
        Join,
        [EnumMember(Value = "unsure")]
        Unsure,
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "request")]
        Request,
    }
}
