using System.Runtime.Serialization;

namespace Citrina
{
    public enum FavePagesType
    {
        [EnumMember(Value = "groups")]
        Groups,
        [EnumMember(Value = "hints")]
        Hints,
        [EnumMember(Value = "users")]
        Users,
    }
}
