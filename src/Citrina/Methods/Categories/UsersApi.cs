using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
    internal class UsersApi : IUsersApi
    {
        public Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(UserAccessToken accessToken, IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<UsersUserXtrCounters>>("users.get", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<UsersUserXtrCounters>>("users.get", null, request);
        }

        public Task<ApiRequest<IEnumerable<UsersUserXtrCounters>>> Get(ServiceAccessToken accessToken, IEnumerable<string> userIds = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<UsersUserXtrCounters>>("users.get", accessToken, request);
        }

        public Task<ApiRequest<UsersSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, int? city = null, int? country = null, string hometown = null, int? universityCountry = null, int? university = null, int? universityYear = null, int? universityFaculty = null, int? universityChair = null, int? sex = null, int? status = null, int? ageFrom = null, int? ageTo = null, int? birthDay = null, int? birthMonth = null, int? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, string religion = null, string interests = null, string company = null, string position = null, int? groupId = null, IEnumerable<string> fromList = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
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

            return RequestManager.CreateRequestAsync<UsersSearchResponse>("users.search", accessToken, request);
        }

        public Task<ApiRequest<bool?>> IsAppUser(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("users.isAppUser", accessToken, request);
        }

        public Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsResponse>("users.getSubscriptions", accessToken, request);
        }

        public Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(UserAccessToken accessToken, int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsExtendedResponse>("users.getSubscriptions", accessToken, request);
        }

        public Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsResponse>("users.getSubscriptions", null, request);
        }

        public Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
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

        public Task<ApiRequest<UsersGetSubscriptionsResponse>> GetSubscriptions(ServiceAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsResponse>("users.getSubscriptions", accessToken, request);
        }

        public Task<ApiRequest<UsersGetSubscriptionsExtendedResponse>> GetSubscriptionsExtended(ServiceAccessToken accessToken, int? userId = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<UsersGetSubscriptionsExtendedResponse>("users.getSubscriptions", accessToken, request);
        }

        public Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<UsersGetFollowersResponse>("users.getFollowers", accessToken, request);
        }

        public Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
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

        public Task<ApiRequest<UsersGetFollowersResponse>> GetFollowers(ServiceAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<UsersGetFollowersResponse>("users.getFollowers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? userId = null, string type = null, string comment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["type"] = type,
                ["comment"] = comment,
            };

            return RequestManager.CreateRequestAsync<bool?>("users.report", accessToken, request);
        }

        public Task<ApiRequest<UsersGetNearbyResponse>> GetNearby(UserAccessToken accessToken, double? latitude = null, double? longitude = null, int? accuracy = null, int? timeout = null, int? radius = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["accuracy"] = accuracy?.ToString(),
                ["timeout"] = timeout?.ToString(),
                ["radius"] = radius?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<UsersGetNearbyResponse>("users.getNearby", accessToken, request);
        }

    }
}
