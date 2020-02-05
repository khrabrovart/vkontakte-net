namespace Citrina
{
    /// <summary>
    /// Filters to apply: 'likes' — returns information about all users who liked the object (default), 'copies' — returns information only about users who told their friends about the object.
    /// </summary>
    public enum Likes_GetList_filter
    {
        [EnumMember(Value = "likes")]
        Likes,
        [EnumMember(Value = "copies")]
        Copies,
    }
}
