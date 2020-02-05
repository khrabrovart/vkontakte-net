using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// 'installed' — to return list of installed apps (only for mobile platform).
    /// </summary>
    public enum AppsCatalogFilter
    {
        [EnumMember(Value = "favorite")]
        Favorite,
        [EnumMember(Value = "featured")]
        Featured,
        [EnumMember(Value = "installed")]
        Installed,
        [EnumMember(Value = "new")]
        New,
    }
}
