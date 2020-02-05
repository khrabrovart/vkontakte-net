namespace Citrina
{
    /// <summary>
    /// Type of media files to return: *'photo',, *'video',, *'audio',, *'doc',, *'link'.,*'market'.,*'wall'.,*'share'.
    /// </summary>
    public enum Messages_GetHistoryAttachments_mediaType
    {
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "audio_message")]
        AudioMessage,
        [EnumMember(Value = "doc")]
        Doc,
        [EnumMember(Value = "graffiti")]
        Graffiti,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "share")]
        Share,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "wall")]
        Wall,
    }
}
