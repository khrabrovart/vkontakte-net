using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Type of requested objects listed in 'ids' parameter: *ad — ads,, *campaign — campaigns,, *client — clients,, *office — account.
    /// </summary>
    public enum AdsStatisticsIdsType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "campaign")]
        Campaign,
        [EnumMember(Value = "client")]
        Client,
        [EnumMember(Value = "office")]
        Office,
    }
}
