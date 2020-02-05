using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface ISecureApi
    {
        /// <summary>
        /// Adds user activity information to an application.
        /// </summary>
        Task<ApiRequest<bool?>> AddAppEventApi(int? userId = null, int? activityId = null, int? value = null);

        /// <summary>
        /// Checks the user authentication in 'IFrame' and 'Flash' apps using the 'access_token' parameter.
        /// </summary>
        Task<ApiRequest<SecureTokenChecked>> CheckTokenApi(string token = null, string ip = null);

        /// <summary>
        /// Returns payment balance of the application in hundredth of a vote.
        /// </summary>
        Task<ApiRequest<int?>> GetAppBalanceApi();

        /// <summary>
        /// Shows a list of SMS notifications sent by the application using [vk.com/dev/secure.sendSMSNotification|secure.sendSMSNotification] method.
        /// </summary>
        Task<ApiRequest<IEnumerable<SecureSmsNotification>>> GetSMSHistoryApi(int? userId = null, int? dateFrom = null, int? dateTo = null, int? limit = null);

        /// <summary>
        /// Shows history of votes transaction between users and the application.
        /// </summary>
        Task<ApiRequest<IEnumerable<SecureTransaction>>> GetTransactionsHistoryApi(int? type = null, int? uidFrom = null, int? uidTo = null, int? dateFrom = null, int? dateTo = null, int? limit = null);

        /// <summary>
        /// Returns one of the previously set game levels of one or more users in the application.
        /// </summary>
        Task<ApiRequest<IEnumerable<SecureLevel>>> GetUserLevelApi(IEnumerable<int> userIds = null);

        /// <summary>
        /// Opens the game achievement and gives the user a sticker.
        /// </summary>
        Task<ApiRequest<IEnumerable<object>>> GiveEventStickerApi(IEnumerable<int> userIds = null, int? achievementId = null);

        /// <summary>
        /// Sends notification to the user.
        /// </summary>
        Task<ApiRequest<IEnumerable<int>>> SendNotificationApi(IEnumerable<int> userIds = null, int? userId = null, string message = null);

        /// <summary>
        /// Sends 'SMS' notification to a user's mobile device.
        /// </summary>
        Task<ApiRequest<bool?>> SendSMSNotificationApi(int? userId = null, string message = null);

        /// <summary>
        /// Sets a counter which is shown to the user in bold in the left menu.
        /// </summary>
        Task<ApiRequest<bool?>> SetCounterApi(IEnumerable<string> counters = null, int? userId = null, int? counter = null, bool? increment = null);
    }
}
