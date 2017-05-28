using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Citrina.StandardApi.Core;
using Newtonsoft.Json.Linq;

namespace Citrina
{
    internal class AuthHelpers : IAuthHelpers
    {
        public string GenerateLink(LinkType type, int clientId, string redirectUri, DisplayOptions display, UserPermissions scope, string state)
        {
            var sb = new StringBuilder($"https://oauth.vk.com/authorize?client_id={clientId}");
            var uri = string.IsNullOrWhiteSpace(redirectUri) ? "https://oauth.vk.com/blank.html" : redirectUri;

            sb.Append($"&scope={scope:D}");
            sb.Append($"&response_type={type.ToString().ToLower()}");
            sb.Append($"&v={CitrinaGlobalSettings.ApiVersion}");
            sb.Append($"&redirect_uri={uri}");

            if (display != DisplayOptions.Default)
            {
                sb.Append($"&display={display.ToString().ToLower()}");
            }

            if (!string.IsNullOrWhiteSpace(state))
            {
                sb.Append($"&state={state}");
            }

            return sb.ToString();
        }

        public string GenerateLink(LinkType type, int clientId, UserPermissions scope, string state)
        {
            return GenerateLink(type, clientId, null, DisplayOptions.Default, scope, state);
        }

        public string GenerateLink(LinkType type, int clientId, UserPermissions scope)
        {
            return GenerateLink(type, clientId, scope, null);
        }

        public string GenerateLink(LinkType type, int clientId, IEnumerable<int> groupIds, string redirectUri, DisplayOptions display, GroupPermissions scope, string state)
        {
            var sb = new StringBuilder($"https://oauth.vk.com/authorize?client_id={clientId}");
            var uri = string.IsNullOrWhiteSpace(redirectUri) ? "https://oauth.vk.com/blank.html" : redirectUri;

            sb.Append($"&group_ids={string.Join(",", groupIds)}");
            sb.Append($"&scope={scope:D}");
            sb.Append($"&response_type={type.ToString().ToLower()}");
            sb.Append($"&v={CitrinaGlobalSettings.ApiVersion}");
            sb.Append($"&redirect_uri={uri}");

            if (display != DisplayOptions.Default)
            {
                sb.Append($"&display={display.ToString().ToLower()}");
            }

            if (!string.IsNullOrWhiteSpace(state))
            {
                sb.Append($"&state={state}");
            }

            return sb.ToString();
        }

        public string GenerateLink(LinkType type, int clientId, IEnumerable<int> groupIds, GroupPermissions scope, string state)
        {
            return GenerateLink(type, clientId, groupIds, null, DisplayOptions.Default, scope, state);
        }

        public string GenerateLink(LinkType type, int clientId, IEnumerable<int> groupIds, GroupPermissions scope)
        {
            return GenerateLink(type, clientId, groupIds, scope, null);
        }

        public async Task<CodeAuthCall> GetAccessTokenAsync(int clientId, string clientSecret, string redirectUri, string code)
        {
            var sb = new StringBuilder($"https://oauth.vk.com/access_token?client_id={clientId}");
            var uri = string.IsNullOrWhiteSpace(redirectUri) ? "https://oauth.vk.com/blank.html" : redirectUri;

            sb.Append($"&client_secret={clientSecret}");
            sb.Append($"&redirect_uri={uri}");
            sb.Append($"&code={code}");

            using (var client = new HttpClient())
            {
                var response = await (await client.GetAsync(sb.ToString()).ConfigureAwait(false))
                    .Content.ReadAsStringAsync().ConfigureAwait(false);

                dynamic jobj = JObject.Parse(response);

                if (jobj.error != null)
                {
                    return new CodeAuthCall
                    {
                        Error = JsonCore.Deserialize<CodeAuthCallError>(response),
                        IsError = true
                    };
                }

                var token = JsonCore.Deserialize<CodeAuthCallResponse>(response);
                return new CodeAuthCall
                {
                    AccessToken = new UserAccessToken(token.AccessToken, token.ExpiresIn, token.UserId, clientId)
                };
            }
        }
    }
}