using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IUsersApi
    {
        /// <summary>
        /// Returns detailed information on users.
        /// </summary>
        Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> GetApi(IEnumerable<string> userIds = null, IEnumerable<UsersFields> fields = null, string nameCase = null);

        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        Task<ApiRequest<UsersGetFollowersResponse>> GetFollowersApi(int? userId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string nameCase = null);

        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        Task<ApiRequest<UsersGetFollowersFieldsResponse>> GetFollowersApi(int? userId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string nameCase = null);

        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptionsApi(int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsApi(int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null);

        /// <summary>
        /// Returns information whether a user installed the application.
        /// </summary>
        Task<ApiRequest<bool?>> IsAppUserApi(int? userId = null);

        /// <summary>
        /// Reports (submits a complain about) a user.
        /// </summary>
        Task<ApiRequest<bool?>> ReportApi(int? userId = null, string type = null, string comment = null);

        /// <summary>
        /// Returns a list of users matching the search criteria.
        /// </summary>
        Task<ApiRequest<UsersSearchResponse>> SearchApi(string q = null, int? sort = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, int? city = null, int? country = null, string hometown = null, int? universityCountry = null, int? university = null, int? universityYear = null, int? universityFaculty = null, int? universityChair = null, int? sex = null, int? status = null, int? ageFrom = null, int? ageTo = null, int? birthDay = null, int? birthMonth = null, int? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = null, string interests = null, string company = null, string position = null, int? groupId = null, IEnumerable<string> fromList = null);
    }
}
