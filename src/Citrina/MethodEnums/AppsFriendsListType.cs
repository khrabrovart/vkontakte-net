using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// List type. Possible values: * 'invite' — available for invites (don't play the game),, * 'request' — available for request (play the game). By default: 'invite'.
    /// </summary>
    public enum AppsFriendsListType
    {
        [EnumMember(Value = "invite")]
        Invite,
        [EnumMember(Value = "request")]
        Request,
    }
}
