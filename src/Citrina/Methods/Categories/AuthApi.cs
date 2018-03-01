using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
    internal class AuthApi : IAuthApi
    {
        public Task<ApiRequest<bool?>> CheckPhone(string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null)
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

        public Task<ApiRequest<bool?>> CheckPhone(ServiceAccessToken accessToken, string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["phone"] = phone,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["auth_by_phone"] = RequestHelpers.ParseBoolean(authByPhone),
            };

            return RequestManager.CreateRequestAsync<bool?>("auth.checkPhone", accessToken, request);
        }

        public Task<ApiRequest<AuthSignupResponse>> Signup(string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["first_name"] = firstName,
                ["last_name"] = lastName,
                ["birthday"] = birthday,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["phone"] = phone,
                ["password"] = password,
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["voice"] = RequestHelpers.ParseBoolean(voice),
                ["sex"] = sex?.ToString(),
                ["sid"] = sid,
            };

            return RequestManager.CreateRequestAsync<AuthSignupResponse>("auth.signup", null, request);
        }

        public Task<ApiRequest<AuthSignupResponse>> Signup(ServiceAccessToken accessToken, string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["first_name"] = firstName,
                ["last_name"] = lastName,
                ["birthday"] = birthday,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["phone"] = phone,
                ["password"] = password,
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["voice"] = RequestHelpers.ParseBoolean(voice),
                ["sex"] = sex?.ToString(),
                ["sid"] = sid,
            };

            return RequestManager.CreateRequestAsync<AuthSignupResponse>("auth.signup", accessToken, request);
        }

        public Task<ApiRequest<AuthConfirmResponse>> Confirm(int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null)
        {
            var request = new Dictionary<string, string>
            {
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["phone"] = phone,
                ["code"] = code,
                ["password"] = password,
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["intro"] = intro?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AuthConfirmResponse>("auth.confirm", null, request);
        }

        public Task<ApiRequest<AuthConfirmResponse>> Confirm(ServiceAccessToken accessToken, int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["phone"] = phone,
                ["code"] = code,
                ["password"] = password,
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["intro"] = intro?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AuthConfirmResponse>("auth.confirm", accessToken, request);
        }

        public Task<ApiRequest<AuthRestoreResponse>> Restore(string phone = null, string lastName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["phone"] = phone,
                ["last_name"] = lastName,
            };

            return RequestManager.CreateRequestAsync<AuthRestoreResponse>("auth.restore", null, request);
        }

        public Task<ApiRequest<AuthRestoreResponse>> Restore(ServiceAccessToken accessToken, string phone = null, string lastName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["phone"] = phone,
                ["last_name"] = lastName,
            };

            return RequestManager.CreateRequestAsync<AuthRestoreResponse>("auth.restore", accessToken, request);
        }

    }
}
