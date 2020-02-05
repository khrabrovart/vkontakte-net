using System.Runtime.Serialization;

namespace Citrina
{
    public enum AccountCountersFilter
    {
        [EnumMember(Value = "friends")]
        Friends,
        [EnumMember(Value = "messages")]
        Messages,
        [EnumMember(Value = "photos")]
        Photos,
        [EnumMember(Value = "videos")]
        Videos,
        [EnumMember(Value = "notes")]
        Notes,
        [EnumMember(Value = "gifts")]
        Gifts,
        [EnumMember(Value = "events")]
        Events,
        [EnumMember(Value = "groups")]
        Groups,
        [EnumMember(Value = "sdk")]
        Sdk,
        [EnumMember(Value = "friends_suggestions")]
        FriendsSuggestions,
    }
}
