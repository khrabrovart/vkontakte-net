using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Sort order: 'asc' — by creation date in chronological order, 'desc' — by creation date in reverse chronological order,.
    /// </summary>
    public enum BoardCommentsSort
    {
        [EnumMember(Value = "asc")]
        Chronological,
        [EnumMember(Value = "desc")]
        ReverseChronological,
    }
}
