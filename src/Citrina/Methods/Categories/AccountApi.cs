using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
    internal class AccountApi : IAccountApi
    {
        public Task<ApiRequest<AccountAccountCounters>> GetCounters(UserAccessToken accessToken, IEnumerable<string> filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["filter"] = RequestHelpers.ParseEnumerable(filter),
            };

            return RequestManager.CreateRequestAsync<AccountAccountCounters>("account.getCounters", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetNameInMenu(UserAccessToken accessToken, int? userId = null, string name = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["name"] = name,
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setNameInMenu", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetOnline(UserAccessToken accessToken, bool? voip = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["voip"] = RequestHelpers.ParseBoolean(voip),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setOnline", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetOffline(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setOffline", accessToken, request);
        }

        public Task<ApiRequest<AccountLookupResult>> LookupContacts(UserAccessToken accessToken, IEnumerable<string> contacts = null, string service = null, string mycontact = null, bool? returnAll = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["contacts"] = RequestHelpers.ParseEnumerable(contacts),
                ["service"] = service,
                ["mycontact"] = mycontact,
                ["return_all"] = RequestHelpers.ParseBoolean(returnAll),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<AccountLookupResult>("account.lookupContacts", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RegisterDevice(UserAccessToken accessToken, string token = null, string deviceModel = null, int? deviceYear = null, string deviceId = null, string systemVersion = null, string settings = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["token"] = token,
                ["device_model"] = deviceModel,
                ["device_year"] = deviceYear?.ToString(),
                ["device_id"] = deviceId,
                ["system_version"] = systemVersion,
                ["settings"] = settings,
            };

            return RequestManager.CreateRequestAsync<bool?>("account.registerDevice", accessToken, request);
        }

        public Task<ApiRequest<bool?>> UnregisterDevice(UserAccessToken accessToken, string deviceId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["device_id"] = deviceId,
            };

            return RequestManager.CreateRequestAsync<bool?>("account.unregisterDevice", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetSilenceMode(UserAccessToken accessToken, string deviceId = null, int? time = null, int? peerId = null, int? sound = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["device_id"] = deviceId,
                ["time"] = time?.ToString(),
                ["peer_id"] = peerId?.ToString(),
                ["sound"] = sound?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setSilenceMode", accessToken, request);
        }

        public Task<ApiRequest<AccountPushSettings>> GetPushSettings(UserAccessToken accessToken, string deviceId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["device_id"] = deviceId,
            };

            return RequestManager.CreateRequestAsync<AccountPushSettings>("account.getPushSettings", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetPushSettings(UserAccessToken accessToken, string deviceId = null, string settings = null, string key = null, IEnumerable<string> value = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["device_id"] = deviceId,
                ["settings"] = settings,
                ["key"] = key,
                ["value"] = RequestHelpers.ParseEnumerable(value),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setPushSettings", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetAppPermissions(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("account.getAppPermissions", accessToken, request);
        }

        public Task<ApiRequest<AccountGetActiveOffersResponse>> GetActiveOffers(UserAccessToken accessToken, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AccountGetActiveOffersResponse>("account.getActiveOffers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> BanUser(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.banUser", accessToken, request);
        }

        public Task<ApiRequest<bool?>> UnbanUser(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.unbanUser", accessToken, request);
        }

        public Task<ApiRequest<AccountGetBannedResponse>> GetBanned(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AccountGetBannedResponse>("account.getBanned", accessToken, request);
        }

        public Task<ApiRequest<AccountInfo>> GetInfo(UserAccessToken accessToken, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<AccountInfo>("account.getInfo", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetInfo(UserAccessToken accessToken, string name = null, string value = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["name"] = name,
                ["value"] = value,
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setInfo", accessToken, request);
        }

        public Task<ApiRequest<AccountChangePasswordResponse>> ChangePassword(UserAccessToken accessToken, string restoreSid = null, string changePasswordHash = null, string oldPassword = null, string newPassword = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["restore_sid"] = restoreSid,
                ["change_password_hash"] = changePasswordHash,
                ["old_password"] = oldPassword,
                ["new_password"] = newPassword,
            };

            return RequestManager.CreateRequestAsync<AccountChangePasswordResponse>("account.changePassword", accessToken, request);
        }

        public Task<ApiRequest<AccountUserSettings>> GetProfileInfo(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<AccountUserSettings>("account.getProfileInfo", null, request);
        }

        public Task<ApiRequest<AccountSaveProfileInfoResponse>> SaveProfileInfo(UserAccessToken accessToken, string firstName = null, string lastName = null, string maidenName = null, string screenName = null, int? cancelRequestId = null, int? sex = null, int? relation = null, int? relationPartnerId = null, string bdate = null, int? bdateVisibility = null, string homeTown = null, int? countryId = null, int? cityId = null, string status = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["first_name"] = firstName,
                ["last_name"] = lastName,
                ["maiden_name"] = maidenName,
                ["screen_name"] = screenName,
                ["cancel_request_id"] = cancelRequestId?.ToString(),
                ["sex"] = sex?.ToString(),
                ["relation"] = relation?.ToString(),
                ["relation_partner_id"] = relationPartnerId?.ToString(),
                ["bdate"] = bdate,
                ["bdate_visibility"] = bdateVisibility?.ToString(),
                ["home_town"] = homeTown,
                ["country_id"] = countryId?.ToString(),
                ["city_id"] = cityId?.ToString(),
                ["status"] = status,
            };

            return RequestManager.CreateRequestAsync<AccountSaveProfileInfoResponse>("account.saveProfileInfo", accessToken, request);
        }

    }
}
