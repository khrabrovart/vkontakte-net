namespace Citrina
{
    /// <summary>
    /// Sort order: 'asc' — oldest comment first, 'desc' — newest comment first.
    /// </summary>
    public enum Video_GetComments_sort
    {
        [EnumMember(Value = "asc")]
        OldestCommentFirst,
        [EnumMember(Value = "desc")]
        NewestCommentFirst,
    }
}
