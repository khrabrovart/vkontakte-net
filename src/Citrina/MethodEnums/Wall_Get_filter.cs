namespace Citrina
{
    /// <summary>
    /// Filter to apply: 'owner' — posts by the wall owner, 'others' — posts by someone else, 'all' — posts by the wall owner and others (default), 'postponed' — timed posts (only available for calls with an 'access_token'), 'suggests' — suggested posts on a community wall.
    /// </summary>
    public enum Wall_Get_filter
    {
        [EnumMember(Value = "owner")]
        Owner,
        [EnumMember(Value = "others")]
        Others,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "postponed")]
        Postponed,
        [EnumMember(Value = "suggests")]
        Suggests,
    }
}
