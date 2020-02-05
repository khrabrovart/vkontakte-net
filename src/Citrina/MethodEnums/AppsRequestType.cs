using System.Runtime.Serialization;

namespace Citrina
{
    /// <summary>
    /// request type. Values: 'invite' – if the request is sent to a user who does not have the app installed,, 'request' – if a user has already installed the app.
    /// </summary>
    public enum AppsRequestType
    {
        [EnumMember(Value = "invite")]
        Invite,
        [EnumMember(Value = "request")]
        Request,
    }
}
