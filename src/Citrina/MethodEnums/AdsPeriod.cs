using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Data grouping by dates: *day — statistics by days,, *month — statistics by months,, *overall — overall statistics. 'date_from' and 'date_to' parameters set temporary limits.
    /// </summary>
    public enum AdsPeriod
    {
        [EnumMember(Value = "day")]
        Day,
        [EnumMember(Value = "month")]
        Month,
        [EnumMember(Value = "overall")]
        Overall,
    }
}
