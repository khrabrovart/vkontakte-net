using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IAccountApi
    {
        /// <summary>
        /// Returns non-null values of user counters.
        /// </summary>
        Task<ApiRequest<AccountAccountCounters>> GetCounters(UserAccessToken accessToken, IEnumerable<string> filter = null);
        /// <summary>
        /// Sets an application screen name (up to 17 characters), that is shown to the user in the left menu.
        /// </summary>
        Task<ApiRequest<bool?>> SetNameInMenu(UserAccessToken accessToken, int? userId = null, string name = null);
        /// <summary>
        /// Marks the current user as online for 15 minutes.
        /// </summary>
        Task<ApiRequest<bool?>> SetOnline(UserAccessToken accessToken, bool? voip = null);
        /// <summary>
        /// Marks a current user as offline.
        /// </summary>
        Task<ApiRequest<bool?>> SetOffline(UserAccessToken accessToken);
        /// <summary>
        /// Allows to search the VK users using phone numbers, e-mail addresses and user IDs on other services.
        /// </summary>
        Task<ApiRequest<AccountLookupResult>> LookupContacts(UserAccessToken accessToken, IEnumerable<string> contacts = null, string service = null, string mycontact = null, bool? returnAll = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Subscribes an iOS/Android/Windows Phone-based device to receive push notifications
        /// </summary>
        Task<ApiRequest<bool?>> RegisterDevice(UserAccessToken accessToken, string token = null, string deviceModel = null, int? deviceYear = null, string deviceId = null, string systemVersion = null, string settings = null);
        /// <summary>
        /// Unsubscribes a device from push notifications.
        /// </summary>
        Task<ApiRequest<bool?>> UnregisterDevice(UserAccessToken accessToken, string deviceId = null);
        /// <summary>
        /// Mutes push notifications for the set period of time.
        /// </summary>
        Task<ApiRequest<bool?>> SetSilenceMode(UserAccessToken accessToken, string deviceId = null, int? time = null, int? peerId = null, int? sound = null);
        /// <summary>
        /// Gets settings of push notifications.
        /// </summary>
        Task<ApiRequest<AccountPushSettings>> GetPushSettings(UserAccessToken accessToken, string deviceId = null);
        /// <summary>
        /// Change push settings.
        /// </summary>
        Task<ApiRequest<bool?>> SetPushSettings(UserAccessToken accessToken, string deviceId = null, string settings = null, string key = null, IEnumerable<string> value = null);
        /// <summary>
        /// Gets settings of the user in this application.
        /// </summary>
        Task<ApiRequest<int?>> GetAppPermissions(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Returns a list of active ads (offers) which executed by the user will bring him/her respective number of votes to his balance in the application.
        /// </summary>
        Task<ApiRequest<AccountGetActiveOffersResponse>> GetActiveOffers(UserAccessToken accessToken, int? count = null);
        /// <summary>
        /// Adds user to the banlist.
        /// </summary>
        Task<ApiRequest<bool?>> BanUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Deletes user from the blacklist.
        /// </summary>
        Task<ApiRequest<bool?>> UnbanUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Returns a user's blacklist.
        /// </summary>
        Task<ApiRequest<AccountGetBannedResponse>> GetBanned(UserAccessToken accessToken, int? offset = null, int? count = null);
        /// <summary>
        /// Returns current account info.
        /// </summary>
        Task<ApiRequest<AccountInfo>> GetInfo(UserAccessToken accessToken, IEnumerable<string> fields = null);
        /// <summary>
        /// Allows to edit the current account info.
        /// </summary>
        Task<ApiRequest<bool?>> SetInfo(UserAccessToken accessToken, string name = null, string value = null);
        /// <summary>
        /// Changes a user password after access is successfully restored with the [vk.com/dev/auth.restore|auth.restore] method.
        /// </summary>
        Task<ApiRequest<AccountChangePasswordResponse>> ChangePassword(UserAccessToken accessToken, string restoreSid = null, string changePasswordHash = null, string oldPassword = null, string newPassword = null);
        /// <summary>
        /// Returns the current account info.
        /// </summary>
        Task<ApiRequest<AccountUserSettings>> GetProfileInfo(UserAccessToken accessToken);
        /// <summary>
        /// Edits current profile info.
        /// </summary>
        Task<ApiRequest<AccountSaveProfileInfoResponse>> SaveProfileInfo(UserAccessToken accessToken, string firstName = null, string lastName = null, string maidenName = null, string screenName = null, int? cancelRequestId = null, int? sex = null, int? relation = null, int? relationPartnerId = null, string bdate = null, int? bdateVisibility = null, string homeTown = null, int? countryId = null, int? cityId = null, string status = null);
    }
}
