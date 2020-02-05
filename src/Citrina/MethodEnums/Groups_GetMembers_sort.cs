namespace Citrina
{
    /// <summary>
    /// Sort order. Available values: 'id_asc', 'id_desc', 'time_asc', 'time_desc'. 'time_asc' and 'time_desc' are availavle only if the method is called by the group's 'moderator'.
    /// </summary>
    public enum Groups_GetMembers_sort
    {
        [EnumMember(Value = "id_asc")]
        IdAsc,
        [EnumMember(Value = "id_desc")]
        IdDesc,
        [EnumMember(Value = "time_asc")]
        TimeAsc,
        [EnumMember(Value = "time_desc")]
        TimeDesc,
    }
}
