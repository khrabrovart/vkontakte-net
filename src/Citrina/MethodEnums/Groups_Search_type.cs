namespace Citrina
{
    /// <summary>
    /// Community type. Possible values: 'group, page, event.'.
    /// </summary>
    public enum Groups_Search_type
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "event")]
        Event,
    }
}
