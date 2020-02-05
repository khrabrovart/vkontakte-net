using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IAuthApi
    {
        /// <summary>
        /// Checks a user's phone number for correctness.
        /// </summary>
        Task<ApiRequest<bool?>> CheckPhoneApi(string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null);

        /// <summary>
        /// Allows to restore account access using a code received via SMS. " This method is only available for apps with [vk.com/dev/auth_direct|Direct authorization] access. ".
        /// </summary>
        Task<ApiRequest<AuthRestoreResponse>> RestoreApi(string phone = null, string lastName = null);
    }
}
