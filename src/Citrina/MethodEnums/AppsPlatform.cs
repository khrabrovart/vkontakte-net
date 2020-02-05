using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// platform. Possible values: *'ios' — iOS,, *'android' — Android,, *'winphone' — Windows Phone,, *'web' — приложения на vk.com. By default: 'web'.
    /// </summary>
    public enum AppsPlatform
    {
        [EnumMember(Value = "android")]
        Android,
        [EnumMember(Value = "ios")]
        Ios,
        [EnumMember(Value = "web")]
        Web,
        [EnumMember(Value = "winphone")]
        Winphone,
    }
}
