using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IAuthentication
    {
        string GenerateLink(LinkType type, int clientId, string redirectUri, DisplayOptions display, UserPermissions scope, string state);
        string GenerateLink(LinkType type, int clientId, UserPermissions scope, string state);
        string GenerateLink(LinkType type, int clientId, UserPermissions scope);
        string GenerateLink(LinkType type, int clientId, IEnumerable<int> groupIds, string redirectUri, DisplayOptions display, GroupPermissions scope, string state);
        string GenerateLink(LinkType type, int clientId, IEnumerable<int> groupIds, GroupPermissions scope, string state);
        string GenerateLink(LinkType type, int clientId, IEnumerable<int> groupIds, GroupPermissions scope);
        Task<CodeAuthenticationCall> GetAccessTokenAsync(int clientId, string clientSecret, string redirectUri, string code);
    }
}
