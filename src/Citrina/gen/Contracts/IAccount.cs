using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IAccountApi
    {
        Task<ApiRequest<bool?>> BanApi(int? ownerId = null);

        /// <summary>
        /// Changes a user password after access is successfully restored with the [vk.com/dev/auth.restore|auth.restore] method.
        /// </summary>
        Task<ApiRequest<AccountChangePasswordResponse>> ChangePasswordApi(string restoreSid = null, string changePasswordHash = null, string oldPassword = null, string newPassword = null);

        /// <summary>
        /// Returns a list of active ads (offers) which executed by the user will bring him/her respective number of votes to his balance in the application.
        /// </summary>
        Task<ApiRequest<AccountGetActiveOffersResponse>> GetActiveOffersApi(int? offset = null, int? count = null);

        /// <summary>
        /// Gets settings of the user in this application.
        /// </summary>
        Task<ApiRequest<int?>> GetAppPermissionsApi(int? userId = null);

        /// <summary>
        /// Returns a user's blacklist.
        /// </summary>
        Task<ApiRequest<AccountGetBannedResponse>> GetBannedApi(int? offset = null, int? count = null);

        /// <summary>
        /// Returns non-null values of user counters.
        /// </summary>
        Task<ApiRequest<AccountAccountCounters>> GetCountersApi(IEnumerable<string> filter = null);

        /// <summary>
        /// Returns current account info.
        /// </summary>
        Task<ApiRequest<AccountInfo>> GetInfoApi(IEnumerable<string> fields = null);

        /// <summary>
        /// Returns the current account info.
        /// </summary>
        Task<ApiRequest<AccountUserSettings>> GetProfileInfoApi();

        /// <summary>
        /// Gets settings of push notifications.
        /// </summary>
        Task<ApiRequest<AccountPushSettings>> GetPushSettingsApi(string deviceId = null);

        /// <summary>
        /// Subscribes an iOS/Android/Windows Phone-based device to receive push notifications.
        /// </summary>
        Task<ApiRequest<bool?>> RegisterDeviceApi(string token = null, string deviceModel = null, int? deviceYear = null, string deviceId = null, string systemVersion = null, string settings = null, bool? sandbox = null);

        /// <summary>
        /// Edits current profile info.
        /// </summary>
        Task<ApiRequest<AccountSaveProfileInfoResponse>> SaveProfileInfoApi(string firstName = null, string lastName = null, string maidenName = null, string screenName = null, int? cancelRequestId = null, int? sex = null, int? relation = null, int? relationPartnerId = null, string bdate = null, int? bdateVisibility = null, string homeTown = null, int? countryId = null, int? cityId = null, string status = null);

        /// <summary>
        /// Allows to edit the current account info.
        /// </summary>
        Task<ApiRequest<bool?>> SetInfoApi(string name = null, string value = null);

        /// <summary>
        /// Sets an application screen name (up to 17 characters), that is shown to the user in the left menu.
        /// </summary>
        Task<ApiRequest<bool?>> SetNameInMenuApi(int? userId = null, string name = null);

        /// <summary>
        /// Marks a current user as offline.
        /// </summary>
        Task<ApiRequest<bool?>> SetOfflineApi();

        /// <summary>
        /// Marks the current user as online for 15 minutes.
        /// </summary>
        Task<ApiRequest<bool?>> SetOnlineApi(bool? voip = null);

        /// <summary>
        /// Change push settings.
        /// </summary>
        Task<ApiRequest<bool?>> SetPushSettingsApi(string deviceId = null, string settings = null, string key = null, IEnumerable<string> value = null);

        /// <summary>
        /// Mutes push notifications for the set period of time.
        /// </summary>
        Task<ApiRequest<bool?>> SetSilenceModeApi(string deviceId = null, int? time = null, int? peerId = null, int? sound = null);

        Task<ApiRequest<bool?>> UnbanApi(int? ownerId = null);

        /// <summary>
        /// Unsubscribes a device from push notifications.
        /// </summary>
        Task<ApiRequest<bool?>> UnregisterDeviceApi(string deviceId = null, bool? sandbox = null);
    }
}
