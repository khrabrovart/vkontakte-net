using System.Runtime.Serialization;

namespace Citrina
{
    public enum AppsScopesType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "user")]
        User,
    }
}
