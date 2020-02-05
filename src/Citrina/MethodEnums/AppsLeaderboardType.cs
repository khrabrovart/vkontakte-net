using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Leaderboard type. Possible values: *'level' — by level,, *'points' — by mission points,, *'score' — by score ().
    /// </summary>
    public enum AppsLeaderboardType
    {
        [EnumMember(Value = "level")]
        Level,
        [EnumMember(Value = "points")]
        Points,
        [EnumMember(Value = "score")]
        Score,
    }
}
