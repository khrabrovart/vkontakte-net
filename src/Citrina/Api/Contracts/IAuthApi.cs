using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IAuthApi
    {
        /// <summary>
        /// Checks a user's phone number for correctness.
        /// </summary>
        Task<ApiRequest<bool?>> CheckPhone(string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null);
        /// <summary>
        /// Checks a user's phone number for correctness.
        /// </summary>
        Task<ApiRequest<bool?>> CheckPhone(ServiceAccessToken accessToken, string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null);
        /// <summary>
        /// Registers a new user by phone number.
        /// </summary>
        Task<ApiRequest<AuthSignupResponse>> Signup(string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null);
        /// <summary>
        /// Registers a new user by phone number.
        /// </summary>
        Task<ApiRequest<AuthSignupResponse>> Signup(ServiceAccessToken accessToken, string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null);
        /// <summary>
        /// Completes a user's registration (begun with the [vk.com/dev/auth.signup|auth.signup] method) using an authorization code.
        /// </summary>
        Task<ApiRequest<AuthConfirmResponse>> Confirm(int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null);
        /// <summary>
        /// Completes a user's registration (begun with the [vk.com/dev/auth.signup|auth.signup] method) using an authorization code.
        /// </summary>
        Task<ApiRequest<AuthConfirmResponse>> Confirm(ServiceAccessToken accessToken, int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null);
        /// <summary>
        /// Allows to restore account access using a code received via SMS. " This method is only available for apps with [vk.com/dev/auth_direct|Direct authorization] access. "
        /// </summary>
        Task<ApiRequest<AuthRestoreResponse>> Restore(string phone = null, string lastName = null);
        /// <summary>
        /// Allows to restore account access using a code received via SMS. " This method is only available for apps with [vk.com/dev/auth_direct|Direct authorization] access. "
        /// </summary>
        Task<ApiRequest<AuthRestoreResponse>> Restore(ServiceAccessToken accessToken, string phone = null, string lastName = null);
    }
}
