using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IUsersApi
    {
        /// <summary>
        /// Returns detailed information on users.
        /// </summary>
        Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(UserAccessToken accessToken, IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns detailed information on users.
        /// </summary>
        Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns detailed information on users.
        /// </summary>
        Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(ServiceAccessToken accessToken, IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of users matching the search criteria.
        /// </summary>
        Task<ApiRequest<UsersSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, int? city = null, int? country = null, string hometown = null, int? universityCountry = null, int? university = null, int? universityYear = null, int? universityFaculty = null, int? universityChair = null, int? sex = null, int? status = null, int? ageFrom = null, int? ageTo = null, int? birthDay = null, int? birthMonth = null, int? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = null, string interests = null, string company = null, string position = null, int? groupId = null, IEnumerable<string> fromList = null);
        /// <summary>
        /// Returns information whether a user installed the application.
        /// </summary>
        Task<ApiRequest<bool?>> IsAppUser(UserAccessToken accessToken, int? userId = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(UserAccessToken accessToken, int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(ServiceAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(ServiceAccessToken accessToken, int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null);
        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(ServiceAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null);
        /// <summary>
        /// Reports (submits a complain about) a user.
        /// </summary>
        Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? userId = null, string type = null, string comment = null);
        /// <summary>
        /// Indexes current user location and returns nearby users.
        /// </summary>
        Task<ApiRequest<UsersGetNearbyResponse>> GetNearby(UserAccessToken accessToken, double? latitude = null, double? longitude = null, int? accuracy = null, int? timeout = null, int? radius = null, IEnumerable<string> fields = null, string nameCase = null);
    }
}
