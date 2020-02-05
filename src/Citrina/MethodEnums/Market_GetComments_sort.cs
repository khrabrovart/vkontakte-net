namespace Citrina
{
    /// <summary>
    /// Sort order ('asc' — from old to new, 'desc' — from new to old).
    /// </summary>
    public enum Market_GetComments_sort
    {
        [EnumMember(Value = "asc")]
        OldToNew,
        [EnumMember(Value = "desc")]
        NewToOld,
    }
}
