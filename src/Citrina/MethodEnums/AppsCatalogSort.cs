using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Sort order: 'popular_today' — popular for one day (default), 'visitors' — by visitors number , 'create_date' — by creation date, 'growth_rate' — by growth rate, 'popular_week' — popular for one week.
    /// </summary>
    public enum AppsCatalogSort
    {
        [EnumMember(Value = "popular_today")]
        PopularToday,
        [EnumMember(Value = "visitors")]
        Visitors,
        [EnumMember(Value = "create_date")]
        CreateDate,
        [EnumMember(Value = "growth_rate")]
        GrowthRate,
        [EnumMember(Value = "popular_week")]
        PopularWeek,
    }
}
