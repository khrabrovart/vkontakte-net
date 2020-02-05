using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Users : IUsers
    {
        /// <summary>
        /// Returns detailed information on users.
        /// </summary>
        public Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> GetApi(IEnumerable<string> userIds = null, IEnumerable<UsersFields> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<UsersUserXtrCounters>>("users.get", null, request);
        }

        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        public Task<ApiRequest<UsersGetFollowersResponse>> GetFollowersApi(int? userId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<UsersGetFollowersResponse>("users.getFollowers", null, request);
        }

        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// </summary>
        public Task<ApiRequest<UsersGetFollowersFieldsResponse>> GetFollowersApi(int? userId = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<UsersGetFollowersFieldsResponse>("users.getFollowers", null, request);
        }

        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        public Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptionsApi(int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsResponse>("users.getSubscriptions", null, request);
        }

        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// </summary>
        public Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsApi(int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsExtendedResponse>("users.getSubscriptions", null, request);
        }

        /// <summary>
        /// Returns information whether a user installed the application.
        /// </summary>
        public Task<ApiRequest<bool?>> IsAppUserApi(int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("users.isAppUser", null, request);
        }

        /// <summary>
        /// Reports (submits a complain about) a user.
        /// </summary>
        public Task<ApiRequest<bool?>> ReportApi(int? userId = null, string type = null, string comment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["type"] = type,
                ["comment"] = comment,
            };

            return RequestManager.CreateRequestAsync<bool?>("users.report", null, request);
        }

        /// <summary>
        /// Returns a list of users matching the search criteria.
        /// </summary>
        public Task<ApiRequest<UsersSearchResponse>> SearchApi(string q = null, int? sort = null, int? offset = null, int? count = null, IEnumerable<UsersFields> fields = null, int? city = null, int? country = null, string hometown = null, int? universityCountry = null, int? university = null, int? universityYear = null, int? universityFaculty = null, int? universityChair = null, int? sex = null, int? status = null, int? ageFrom = null, int? ageTo = null, int? birthDay = null, int? birthMonth = null, int? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = null, string interests = null, string company = null, string position = null, int? groupId = null, IEnumerable<string> fromList = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["sort"] = sort?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["city"] = city?.ToString(),
                ["country"] = country?.ToString(),
                ["hometown"] = hometown,
                ["university_country"] = universityCountry?.ToString(),
                ["university"] = university?.ToString(),
                ["university_year"] = universityYear?.ToString(),
                ["university_faculty"] = universityFaculty?.ToString(),
                ["university_chair"] = universityChair?.ToString(),
                ["sex"] = sex?.ToString(),
                ["status"] = status?.ToString(),
                ["age_from"] = ageFrom?.ToString(),
                ["age_to"] = ageTo?.ToString(),
                ["birth_day"] = birthDay?.ToString(),
                ["birth_month"] = birthMonth?.ToString(),
                ["birth_year"] = birthYear?.ToString(),
                ["online"] = RequestHelpers.ParseBoolean(online),
                ["has_photo"] = RequestHelpers.ParseBoolean(hasPhoto),
                ["school_country"] = schoolCountry?.ToString(),
                ["school_city"] = schoolCity?.ToString(),
                ["school_class"] = schoolClass?.ToString(),
                ["school"] = school?.ToString(),
                ["school_year"] = schoolYear?.ToString(),
                ["religion"] = religion,
                ["interests"] = interests,
                ["company"] = company,
                ["position"] = position,
                ["group_id"] = groupId?.ToString(),
                ["from_list"] = RequestHelpers.ParseEnumerable(fromList),
            };

            return RequestManager.CreateRequestAsync<UsersSearchResponse>("users.search", null, request);
        }
    }
}
