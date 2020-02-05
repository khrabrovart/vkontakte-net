namespace Citrina
{
    public enum Groups_EditAddress_workInfoStatus
    {
        [EnumMember(Value = "always_opened")]
        AlwaysOpened,
        [EnumMember(Value = "forever_closed")]
        ForeverClosed,
        [EnumMember(Value = "no_information")]
        NoInformation,
        [EnumMember(Value = "temporarily_closed")]
        TemporarilyClosed,
        [EnumMember(Value = "timetable")]
        Timetable,
    }
}
