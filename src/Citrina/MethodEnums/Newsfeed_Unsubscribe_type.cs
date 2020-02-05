namespace Citrina
{
    /// <summary>
    /// Type of object from which to unsubscribe: 'note' — note, 'photo' — photo, 'post' — post on user wall or community wall, 'topic' — topic, 'video' — video.
    /// </summary>
    public enum Newsfeed_Unsubscribe_type
    {
        [EnumMember(Value = "note")]
        Note,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "topic")]
        Topic,
        [EnumMember(Value = "video")]
        Video,
    }
}
