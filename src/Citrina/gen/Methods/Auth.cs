using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Auth : IAuth
    {
        /// <summary>
        /// Checks a user's phone number for correctness.
        /// </summary>
        public Task<ApiRequest<bool?>> CheckPhoneApi(string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null)
        {
            var request = new Dictionary<string, string>
            {
                ["phone"] = phone,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["auth_by_phone"] = RequestHelpers.ParseBoolean(authByPhone),
            };

            return RequestManager.CreateRequestAsync<bool?>("auth.checkPhone", null, request);
        }

        /// <summary>
        /// Allows to restore account access using a code received via SMS. " This method is only available for apps with [vk.com/dev/auth_direct|Direct authorization] access. ".
        /// </summary>
        public Task<ApiRequest<AuthRestoreResponse>> RestoreApi(string phone = null, string lastName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["phone"] = phone,
                ["last_name"] = lastName,
            };

            return RequestManager.CreateRequestAsync<AuthRestoreResponse>("auth.restore", null, request);
        }
    }
}
