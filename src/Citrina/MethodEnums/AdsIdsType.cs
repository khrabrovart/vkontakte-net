using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Type of requested objects listed in 'ids' parameter: *ad — ads,, *campaign — campaigns.
    /// </summary>
    public enum AdsIdsType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "campaign")]
        Campaign,
    }
}
