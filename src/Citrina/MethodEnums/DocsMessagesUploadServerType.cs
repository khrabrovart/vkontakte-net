using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Document type.
    /// </summary>
    public enum DocsMessagesUploadServerType
    {
        [EnumMember(Value = "audio_message")]
        AudioMessage,
        [EnumMember(Value = "doc")]
        Doc,
        [EnumMember(Value = "graffiti")]
        Graffiti,
    }
}
