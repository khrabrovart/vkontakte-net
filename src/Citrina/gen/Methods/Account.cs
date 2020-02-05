using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Account : IAccount
    {
        public Task<ApiRequest<bool?>> BanApi(int? ownerId = null)
        {

            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.ban", null, request);
        }

        /// <summary>
        /// Changes a user password after access is successfully restored with the [vk.com/dev/auth.restore|auth.restore] method.
        /// </summary>
        public Task<ApiRequest<AccountChangePasswordResponse>> ChangePasswordApi(string restoreSid = null, string changePasswordHash = null, string oldPassword = null, string newPassword = null)
        {
            var request = new Dictionary<string, string>
            {
                ["restore_sid"] = restoreSid,
                ["change_password_hash"] = changePasswordHash,
                ["old_password"] = oldPassword,
                ["new_password"] = newPassword,
            };

            return RequestManager.CreateRequestAsync<AccountChangePasswordResponse>("account.changePassword", null, request);
        }

        /// <summary>
        /// Returns a list of active ads (offers) which executed by the user will bring him/her respective number of votes to his balance in the application.
        /// </summary>
        public Task<ApiRequest<AccountGetActiveOffersResponse>> GetActiveOffersApi(int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AccountGetActiveOffersResponse>("account.getActiveOffers", null, request);
        }

        /// <summary>
        /// Gets settings of the user in this application.
        /// </summary>
        public Task<ApiRequest<int?>> GetAppPermissionsApi(int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("account.getAppPermissions", null, request);
        }

        /// <summary>
        /// Returns a user's blacklist.
        /// </summary>
        public Task<ApiRequest<AccountGetBannedResponse>> GetBannedApi(int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AccountGetBannedResponse>("account.getBanned", null, request);
        }

        /// <summary>
        /// Returns non-null values of user counters.
        /// </summary>
        public Task<ApiRequest<AccountAccountCounters>> GetCountersApi(IEnumerable<string> filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["filter"] = RequestHelpers.ParseEnumerable(filter),
            };

            return RequestManager.CreateRequestAsync<AccountAccountCounters>("account.getCounters", null, request);
        }

        /// <summary>
        /// Returns current account info.
        /// </summary>
        public Task<ApiRequest<AccountInfo>> GetInfoApi(IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<AccountInfo>("account.getInfo", null, request);
        }

        /// <summary>
        /// Returns the current account info.
        /// </summary>
        public Task<ApiRequest<AccountUserSettings>> GetProfileInfoApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<AccountUserSettings>("account.getProfileInfo", null, request);
        }

        /// <summary>
        /// Gets settings of push notifications.
        /// </summary>
        public Task<ApiRequest<AccountPushSettings>> GetPushSettingsApi(string deviceId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["device_id"] = deviceId,
            };

            return RequestManager.CreateRequestAsync<AccountPushSettings>("account.getPushSettings", null, request);
        }

        /// <summary>
        /// Subscribes an iOS/Android/Windows Phone-based device to receive push notifications.
        /// </summary>
        public Task<ApiRequest<bool?>> RegisterDeviceApi(string token = null, string deviceModel = null, int? deviceYear = null, string deviceId = null, string systemVersion = null, string settings = null, bool? sandbox = null)
        {
            var request = new Dictionary<string, string>
            {
                ["token"] = token,
                ["device_model"] = deviceModel,
                ["device_year"] = deviceYear?.ToString(),
                ["device_id"] = deviceId,
                ["system_version"] = systemVersion,
                ["settings"] = settings,
                ["sandbox"] = RequestHelpers.ParseBoolean(sandbox),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.registerDevice", null, request);
        }

        /// <summary>
        /// Edits current profile info.
        /// </summary>
        public Task<ApiRequest<AccountSaveProfileInfoResponse>> SaveProfileInfoApi(string firstName = null, string lastName = null, string maidenName = null, string screenName = null, int? cancelRequestId = null, int? sex = null, int? relation = null, int? relationPartnerId = null, string bdate = null, int? bdateVisibility = null, string homeTown = null, int? countryId = null, int? cityId = null, string status = null)
        {
            var request = new Dictionary<string, string>
            {
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

            return RequestManager.CreateRequestAsync<AccountSaveProfileInfoResponse>("account.saveProfileInfo", null, request);
        }

        /// <summary>
        /// Allows to edit the current account info.
        /// </summary>
        public Task<ApiRequest<bool?>> SetInfoApi(string name = null, string value = null)
        {
            var request = new Dictionary<string, string>
            {
                ["name"] = name,
                ["value"] = value,
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setInfo", null, request);
        }

        /// <summary>
        /// Sets an application screen name (up to 17 characters), that is shown to the user in the left menu.
        /// </summary>
        public Task<ApiRequest<bool?>> SetNameInMenuApi(int? userId = null, string name = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["name"] = name,
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setNameInMenu", null, request);
        }

        /// <summary>
        /// Marks a current user as offline.
        /// </summary>
        public Task<ApiRequest<bool?>> SetOfflineApi()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setOffline", null, request);
        }

        /// <summary>
        /// Marks the current user as online for 15 minutes.
        /// </summary>
        public Task<ApiRequest<bool?>> SetOnlineApi(bool? voip = null)
        {
            var request = new Dictionary<string, string>
            {
                ["voip"] = RequestHelpers.ParseBoolean(voip),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setOnline", null, request);
        }

        /// <summary>
        /// Change push settings.
        /// </summary>
        public Task<ApiRequest<bool?>> SetPushSettingsApi(string deviceId = null, string settings = null, string key = null, IEnumerable<string> value = null)
        {
            var request = new Dictionary<string, string>
            {
                ["device_id"] = deviceId,
                ["settings"] = settings,
                ["key"] = key,
                ["value"] = RequestHelpers.ParseEnumerable(value),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setPushSettings", null, request);
        }

        /// <summary>
        /// Mutes push notifications for the set period of time.
        /// </summary>
        public Task<ApiRequest<bool?>> SetSilenceModeApi(string deviceId = null, int? time = null, int? peerId = null, int? sound = null)
        {
            var request = new Dictionary<string, string>
            {
                ["device_id"] = deviceId,
                ["time"] = time?.ToString(),
                ["peer_id"] = peerId?.ToString(),
                ["sound"] = sound?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.setSilenceMode", null, request);
        }

        public Task<ApiRequest<bool?>> UnbanApi(int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.unban", null, request);
        }

        /// <summary>
        /// Unsubscribes a device from push notifications.
        /// </summary>
        public Task<ApiRequest<bool?>> UnregisterDeviceApi(string deviceId = null, bool? sandbox = null)
        {
            var request = new Dictionary<string, string>
            {
                ["device_id"] = deviceId,
                ["sandbox"] = RequestHelpers.ParseBoolean(sandbox),
            };

            return RequestManager.CreateRequestAsync<bool?>("account.unregisterDevice", null, request);
        }
    }
}
