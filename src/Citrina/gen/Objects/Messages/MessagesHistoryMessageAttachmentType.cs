using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Attachments type.
    /// </summary>
    public enum MessagesHistoryMessageAttachmentType
    {
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "doc")]
        Doc,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "wall")]
        Wall,
        [EnumMember(Value = "share")]
        Share,
        [EnumMember(Value = "graffiti")]
        Graffiti,
        [EnumMember(Value = "audio_message")]
        AudioMessage,
    }
}
