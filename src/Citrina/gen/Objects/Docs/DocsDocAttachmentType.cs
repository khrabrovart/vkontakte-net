using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Doc attachment type.
    /// </summary>
    public enum DocsDocAttachmentType
    {
        [EnumMember(Value = "doc")]
        Doc,
        [EnumMember(Value = "graffiti")]
        Graffiti,
        [EnumMember(Value = "audio_message")]
        AudioMessage,
    }
}
