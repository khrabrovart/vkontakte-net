using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Peer type.
    /// </summary>
    public enum MessagesConversationPeerType
    {
        [EnumMember(Value = "chat")]
        Chat,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group,
    }
}
