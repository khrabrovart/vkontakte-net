namespace Citrina
{
    /// <summary>
    /// Sort order: 'asc' — old first, 'desc' — new first.
    /// </summary>
    public enum Photos_GetComments_sort
    {
        [EnumMember(Value = "asc")]
        OldFirst,
        [EnumMember(Value = "desc")]
        NewFirst,
    }
}
