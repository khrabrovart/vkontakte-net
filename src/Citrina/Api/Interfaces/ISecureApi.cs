using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface ISecureApi
    {
        /// <summary>
        /// Returns payment balance of the application in hundredth of a vote.
        /// </summary>
        Task<ApiRequest<int?>> GetAppBalance(ServiceAccessToken accessToken);
        /// <summary>
        /// Shows history of votes transaction between users and the application.
        /// </summary>
        Task<ApiRequest<IEnumerable<SecureTransaction>>> GetTransactionsHistory(ServiceAccessToken accessToken);
        /// <summary>
        /// Shows a list of SMS notifications sent by the application using [vk.com/dev/secure.sendSMSNotification|secure.sendSMSNotification] method.
        /// </summary>
        Task<ApiRequest<IEnumerable<SecureSmsNotification>>> GetSMSHistory(ServiceAccessToken accessToken, int? userId = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? limit = null);
        /// <summary>
        /// Sends 'SMS' notification to a user's mobile device.
        /// </summary>
        Task<ApiRequest<bool?>> SendSMSNotification(ServiceAccessToken accessToken, int? userId = null, string message = null);
        /// <summary>
        /// Sends notification to the user.
        /// </summary>
        Task<ApiRequest<IEnumerable<int?>>> SendNotification(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null, int? userId = null, string message = null);
        /// <summary>
        /// Sets a counter which is shown to the user in bold in the left menu.
        /// </summary>
        Task<ApiRequest<bool?>> SetCounter(ServiceAccessToken accessToken, IEnumerable<string> counters = null, int? userId = null, int? counter = null);
        /// <summary>
        /// Sets user game level in the application which can be seen by his/her friends.
        /// </summary>
        Task<ApiRequest<bool?>> SetUserLevel(ServiceAccessToken accessToken, IEnumerable<string> levels = null, int? userId = null, int? level = null);
        /// <summary>
        /// Returns one of the previously set game levels of one or more users in the application.
        /// </summary>
        Task<ApiRequest<IEnumerable<SecureLevel>>> GetUserLevel(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null);
        /// <summary>
        /// Adds user activity information to an application
        /// </summary>
        Task<ApiRequest<bool?>> AddAppEvent(UserAccessToken accessToken, int? userId = null, int? activityId = null, int? value = null);
        /// <summary>
        /// Checks the user authentication in 'IFrame' and 'Flash' apps using the 'access_token' parameter.
        /// </summary>
        Task<ApiRequest<SecureTokenChecked>> CheckToken(UserAccessToken accessToken, string token = null, string ip = null);
    }
}
