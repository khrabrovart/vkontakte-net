using System.Runtime.Serialization;

namespace Citrina
{
    public enum AppWidgetsUpdateType
    {
        [EnumMember(Value = "compact_list")]
        CompactList,
        [EnumMember(Value = "cover_list")]
        CoverList,
        [EnumMember(Value = "donation")]
        Donation,
        [EnumMember(Value = "list")]
        List,
        [EnumMember(Value = "match")]
        Match,
        [EnumMember(Value = "matches")]
        Matches,
        [EnumMember(Value = "table")]
        Table,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "tiles")]
        Tiles,
    }
}
