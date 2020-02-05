namespace Citrina
{
    /// <summary>
    /// *'friends' – only friends in this community will be returned,, *'unsure' – only those who pressed 'I may attend' will be returned (if it's an event).
    /// </summary>
    public enum Groups_GetMembers_filter
    {
        [EnumMember(Value = "friends")]
        Friends,
        [EnumMember(Value = "unsure")]
        Unsure,
    }
}
