namespace Citrina
{
    /// <summary>
    /// Community type. Possible values: *'group' – group,, *'event' – event,, *'public' – public page.
    /// </summary>
    public enum Groups_Create_type
    {
        [EnumMember(Value = "event")]
        Event,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "public")]
        Public,
    }
}
