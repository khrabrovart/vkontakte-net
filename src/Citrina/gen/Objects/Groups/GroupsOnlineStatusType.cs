using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Type of online status of group.
    /// </summary>
    public enum GroupsOnlineStatusType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "online")]
        Online,
        [EnumMember(Value = "answer_mark")]
        AnswerMark,
    }
}
