using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// Language of the returned string values. Supported languages: *ru — Russian,, *ua — Ukrainian,, *en — English.
    /// </summary>
    public enum AdsLanguage
    {
        [EnumMember(Value = "ru")]
        Russian,
        [EnumMember(Value = "ua")]
        Ukrainian,
        [EnumMember(Value = "en")]
        English,
    }
}
