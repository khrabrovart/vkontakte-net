using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods
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

    internal class AuthApi : IAuthApi
    {
        public Task<ApiRequest<bool?>> CheckPhone(string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null)
        {
            var request = new Dictionary<string, string>
            {
                ["phone"] = phone,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["auth_by_phone"] = RequestHelpers.ParseBoolean(authByPhone),
            };

            return RequestManager.CreateRequestAsync<bool?>("auth.checkPhone", null, request);
        }

        public Task<ApiRequest<bool?>> CheckPhone(ServiceAccessToken accessToken, string phone = null, int? clientId = null, string clientSecret = null, bool? authByPhone = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["phone"] = phone,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["auth_by_phone"] = RequestHelpers.ParseBoolean(authByPhone),
            };

            return RequestManager.CreateRequestAsync<bool?>("auth.checkPhone", accessToken, request);
        }

        public Task<ApiRequest<AuthSignupResponse>> Signup(string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["first_name"] = firstName,
                ["last_name"] = lastName,
                ["birthday"] = birthday,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["phone"] = phone,
                ["password"] = password,
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["voice"] = RequestHelpers.ParseBoolean(voice),
                ["sex"] = sex?.ToString(),
                ["sid"] = sid,
            };

            return RequestManager.CreateRequestAsync<AuthSignupResponse>("auth.signup", null, request);
        }

        public Task<ApiRequest<AuthSignupResponse>> Signup(ServiceAccessToken accessToken, string firstName = null, string lastName = null, string birthday = null, int? clientId = null, string clientSecret = null, string phone = null, string password = null, bool? testMode = null, bool? voice = null, int? sex = null, string sid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["first_name"] = firstName,
                ["last_name"] = lastName,
                ["birthday"] = birthday,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["phone"] = phone,
                ["password"] = password,
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["voice"] = RequestHelpers.ParseBoolean(voice),
                ["sex"] = sex?.ToString(),
                ["sid"] = sid,
            };

            return RequestManager.CreateRequestAsync<AuthSignupResponse>("auth.signup", accessToken, request);
        }

        public Task<ApiRequest<AuthConfirmResponse>> Confirm(int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null)
        {
            var request = new Dictionary<string, string>
            {
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["phone"] = phone,
                ["code"] = code,
                ["password"] = password,
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["intro"] = intro?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AuthConfirmResponse>("auth.confirm", null, request);
        }

        public Task<ApiRequest<AuthConfirmResponse>> Confirm(ServiceAccessToken accessToken, int? clientId = null, string clientSecret = null, string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["client_id"] = clientId?.ToString(),
                ["client_secret"] = clientSecret,
                ["phone"] = phone,
                ["code"] = code,
                ["password"] = password,
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
                ["intro"] = intro?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AuthConfirmResponse>("auth.confirm", accessToken, request);
        }

        public Task<ApiRequest<AuthRestoreResponse>> Restore(string phone = null, string lastName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["phone"] = phone,
                ["last_name"] = lastName,
            };

            return RequestManager.CreateRequestAsync<AuthRestoreResponse>("auth.restore", null, request);
        }

        public Task<ApiRequest<AuthRestoreResponse>> Restore(ServiceAccessToken accessToken, string phone = null, string lastName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["phone"] = phone,
                ["last_name"] = lastName,
            };

            return RequestManager.CreateRequestAsync<AuthRestoreResponse>("auth.restore", accessToken, request);
        }

    }

    internal class WallApi : IWallApi
    {
        public Task<ApiRequest<WallGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetResponse>("wall.get", accessToken, request);
        }

        public Task<ApiRequest<WallGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetExtendedResponse>("wall.get", accessToken, request);
        }

        public Task<ApiRequest<WallGetResponse>> Get(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetResponse>("wall.get", accessToken, request);
        }

        public Task<ApiRequest<WallGetExtendedResponse>> GetExtended(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, int? offset = null, int? count = null, string filter = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["filter"] = filter,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetExtendedResponse>("wall.get", accessToken, request);
        }

        public Task<ApiRequest<WallSearchResponse>> Search(UserAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchResponse>("wall.search", accessToken, request);
        }

        public Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchExtendedResponse>("wall.search", accessToken, request);
        }

        public Task<ApiRequest<WallSearchResponse>> Search(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchResponse>("wall.search", accessToken, request);
        }

        public Task<ApiRequest<WallSearchExtendedResponse>> SearchExtended(ServiceAccessToken accessToken, int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null, int? count = null, int? offset = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["domain"] = domain,
                ["query"] = query,
                ["owners_only"] = RequestHelpers.ParseBoolean(ownersOnly),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallSearchExtendedResponse>("wall.search", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(UserAccessToken accessToken, IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", accessToken, request);
        }

        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetByIdExtendedResponse>("wall.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", null, request);
        }

        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetByIdExtendedResponse>("wall.getById", null, request);
        }

        public Task<ApiRequest<IEnumerable<WallWallpostFull>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> posts = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<WallWallpostFull>>("wall.getById", accessToken, request);
        }

        public Task<ApiRequest<WallGetByIdExtendedResponse>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> posts = null, bool? extended = null, int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["posts"] = RequestHelpers.ParseEnumerable(posts),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["copy_history_depth"] = copyHistoryDepth?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<WallGetByIdExtendedResponse>("wall.getById", accessToken, request);
        }

        public Task<ApiRequest<WallPostResponse>> Post(UserAccessToken accessToken, int? ownerId = null, bool? friendsOnly = null, bool? fromGroup = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, DateTime? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, int? postId = null, string guid = null, bool? markAsAds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["services"] = services,
                ["signed"] = RequestHelpers.ParseBoolean(signed),
                ["publish_date"] = RequestHelpers.ParseDateTime(publishDate),
                ["lat"] = lat?.ToString(),
                ["@long"] = @long?.ToString(),
                ["place_id"] = placeId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["guid"] = guid,
                ["mark_as_ads"] = RequestHelpers.ParseBoolean(markAsAds),
            };

            return RequestManager.CreateRequestAsync<WallPostResponse>("wall.post", accessToken, request);
        }

        public Task<ApiRequest<WallRepostResponse>> Repost(UserAccessToken accessToken, string @object = null, string message = null, int? groupId = null, bool? markAsAds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["@object"] = @object,
                ["message"] = message,
                ["group_id"] = groupId?.ToString(),
                ["mark_as_ads"] = RequestHelpers.ParseBoolean(markAsAds),
            };

            return RequestManager.CreateRequestAsync<WallRepostResponse>("wall.repost", accessToken, request);
        }

        public Task<ApiRequest<WallGetRepostsResponse>> GetReposts(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetRepostsResponse>("wall.getReposts", accessToken, request);
        }

        public Task<ApiRequest<WallGetRepostsResponse>> GetReposts(int? ownerId = null, int? postId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetRepostsResponse>("wall.getReposts", null, request);
        }

        public Task<ApiRequest<WallGetRepostsResponse>> GetReposts(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetRepostsResponse>("wall.getReposts", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? friendsOnly = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, DateTime? publishDate = null, double? lat = null, double? @long = null, int? placeId = null, bool? markAsAds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["services"] = services,
                ["signed"] = RequestHelpers.ParseBoolean(signed),
                ["publish_date"] = RequestHelpers.ParseDateTime(publishDate),
                ["lat"] = lat?.ToString(),
                ["@long"] = @long?.ToString(),
                ["place_id"] = placeId?.ToString(),
                ["mark_as_ads"] = RequestHelpers.ParseBoolean(markAsAds),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Pin(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.pin", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Unpin(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.unpin", accessToken, request);
        }

        public Task<ApiRequest<WallGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", accessToken, request);
        }

        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", accessToken, request);
        }

        public Task<ApiRequest<WallGetCommentsResponse>> GetComments(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", null, request);
        }

        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", null, request);
        }

        public Task<ApiRequest<WallGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsResponse>("wall.getComments", accessToken, request);
        }

        public Task<ApiRequest<WallGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? ownerId = null, int? postId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, int? previewLength = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["preview_length"] = previewLength?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<WallGetCommentsExtendedResponse>("wall.getComments", accessToken, request);
        }

        public Task<ApiRequest<WallCreateCommentResponse>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? fromGroup = null, string message = null, int? replyToComment = null, IEnumerable<string> attachments = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["from_group"] = fromGroup?.ToString(),
                ["message"] = message,
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<WallCreateCommentResponse>("wall.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.editComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReportPost(UserAccessToken accessToken, int? ownerId = null, int? postId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.reportPost", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("wall.reportComment", accessToken, request);
        }

    }

    internal class PhotosApi : IPhotosApi
    {
        public Task<ApiRequest<PhotosPhotoAlbumFull>> CreateAlbum(UserAccessToken accessToken, string title = null, int? groupId = null, string description = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["title"] = title,
                ["group_id"] = groupId?.ToString(),
                ["description"] = description,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["upload_by_admins_only"] = RequestHelpers.ParseBoolean(uploadByAdminsOnly),
                ["comments_disabled"] = RequestHelpers.ParseBoolean(commentsDisabled),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoAlbumFull>("photos.createAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? albumId = null, string title = null, string description = null, int? ownerId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? uploadByAdminsOnly = null, bool? commentsDisabled = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["album_id"] = albumId?.ToString(),
                ["title"] = title,
                ["description"] = description,
                ["owner_id"] = ownerId?.ToString(),
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["upload_by_admins_only"] = RequestHelpers.ParseBoolean(uploadByAdminsOnly),
                ["comments_disabled"] = RequestHelpers.ParseBoolean(commentsDisabled),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.editAlbum", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["need_system"] = RequestHelpers.ParseBoolean(needSystem),
                ["need_covers"] = RequestHelpers.ParseBoolean(needCovers),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["need_system"] = RequestHelpers.ParseBoolean(needSystem),
                ["need_covers"] = RequestHelpers.ParseBoolean(needCovers),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", null, request);
        }

        public Task<ApiRequest<PhotosGetAlbumsResponse>> GetAlbums(ServiceAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null, int? offset = null, int? count = null, bool? needSystem = null, bool? needCovers = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["need_system"] = RequestHelpers.ParseBoolean(needSystem),
                ["need_covers"] = RequestHelpers.ParseBoolean(needCovers),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetResponse>> Get(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", null, request);
        }

        public Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", null, request);
        }

        public Task<ApiRequest<PhotosGetResponse>> Get(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetResponse>("photos.get", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetExtendedResponse>> GetExtended(ServiceAccessToken accessToken, int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null, bool? rev = null, bool? extended = null, string feedType = null, DateTime? feed = null, bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId,
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
                ["rev"] = RequestHelpers.ParseBoolean(rev),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["feed_type"] = feedType,
                ["feed"] = RequestHelpers.ParseDateTime(feed),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetExtendedResponse>("photos.get", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetAlbumsCount(UserAccessToken accessToken, int? userId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("photos.getAlbumsCount", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(IEnumerable<string> photos = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", null, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", null, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> GetById(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.getById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoFull>>> GetByIdExtended(ServiceAccessToken accessToken, IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photos"] = RequestHelpers.ParseEnumerable(photos),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoFull>>("photos.getById", accessToken, request);
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetUploadServer(UserAccessToken accessToken, int? albumId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["album_id"] = albumId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(UserAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_x2"] = cropX2?.ToString(),
                ["crop_y2"] = cropY2?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetOwnerCoverPhotoUploadServerResponse>("photos.getOwnerCoverPhotoUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetOwnerCoverPhotoUploadServerResponse>> GetOwnerCoverPhotoUploadServer(GroupAccessToken accessToken, int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_x2"] = cropX2?.ToString(),
                ["crop_y2"] = cropY2?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetOwnerCoverPhotoUploadServerResponse>("photos.getOwnerCoverPhotoUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetOwnerPhotoUploadServerResponse>> GetOwnerPhotoUploadServer(UserAccessToken accessToken, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetOwnerPhotoUploadServerResponse>("photos.getOwnerPhotoUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetChatUploadServerResponse>> GetChatUploadServer(UserAccessToken accessToken, int? chatId = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["chat_id"] = chatId?.ToString(),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_width"] = cropWidth?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetChatUploadServerResponse>("photos.getChatUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetMarketUploadServerResponse>> GetMarketUploadServer(UserAccessToken accessToken, int? groupId = null, bool? mainPhoto = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["main_photo"] = RequestHelpers.ParseBoolean(mainPhoto),
                ["crop_x"] = cropX?.ToString(),
                ["crop_y"] = cropY?.ToString(),
                ["crop_width"] = cropWidth?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetMarketUploadServerResponse>("photos.getMarketUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetMarketAlbumUploadServerResponse>> GetMarketAlbumUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetMarketAlbumUploadServerResponse>("photos.getMarketAlbumUploadServer", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null, string cropData = null, string cropHash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
                ["crop_data"] = cropData,
                ["crop_hash"] = cropHash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMarketPhoto", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<BaseImage>>> SaveOwnerCoverPhoto(UserAccessToken accessToken, string photo = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photo"] = photo,
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseImage>>("photos.saveOwnerCoverPhoto", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMarketAlbumPhoto(UserAccessToken accessToken, int? groupId = null, string photo = null, int? server = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMarketAlbumPhoto", accessToken, request);
        }

        public Task<ApiRequest<PhotosSaveOwnerPhotoResponse>> SaveOwnerPhoto(UserAccessToken accessToken, string server = null, string hash = null, string photo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["server"] = server,
                ["hash"] = hash,
                ["photo"] = photo,
            };

            return RequestManager.CreateRequestAsync<PhotosSaveOwnerPhotoResponse>("photos.saveOwnerPhoto", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveWallPhoto(UserAccessToken accessToken, int? userId = null, int? groupId = null, string photo = null, int? server = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["caption"] = caption,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveWallPhoto", accessToken, request);
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getWallUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getMessagesUploadServer", accessToken, request);
        }

        public Task<ApiRequest<PhotosPhotoUpload>> GetMessagesUploadServer(GroupAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<PhotosPhotoUpload>("photos.getMessagesUploadServer", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(UserAccessToken accessToken, string photo = null, int? server = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMessagesPhoto", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> SaveMessagesPhoto(GroupAccessToken accessToken, string photo = null, int? server = null, string hash = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["photo"] = photo,
                ["server"] = server?.ToString(),
                ["hash"] = hash,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.saveMessagesPhoto", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.report", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.reportComment", accessToken, request);
        }

        public Task<ApiRequest<PhotosSearchResponse>> Search(UserAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["lat"] = lat?.ToString(),
                ["@long"] = @long?.ToString(),
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["sort"] = sort?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["radius"] = radius?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosSearchResponse>("photos.search", accessToken, request);
        }

        public Task<ApiRequest<PhotosSearchResponse>> Search(string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["lat"] = lat?.ToString(),
                ["@long"] = @long?.ToString(),
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["sort"] = sort?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["radius"] = radius?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosSearchResponse>("photos.search", null, request);
        }

        public Task<ApiRequest<PhotosSearchResponse>> Search(ServiceAccessToken accessToken, string q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["lat"] = lat?.ToString(),
                ["@long"] = @long?.ToString(),
                ["start_time"] = startTime?.ToString(),
                ["end_time"] = endTime?.ToString(),
                ["sort"] = sort?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["radius"] = radius?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosSearchResponse>("photos.search", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhoto>>> Save(UserAccessToken accessToken, int? albumId = null, int? groupId = null, int? server = null, string photosList = null, string hash = null, double? latitude = null, double? longitude = null, string caption = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["album_id"] = albumId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["server"] = server?.ToString(),
                ["photos_list"] = photosList,
                ["hash"] = hash,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["caption"] = caption,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhoto>>("photos.save", accessToken, request);
        }

        public Task<ApiRequest<int?>> Copy(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<int?>("photos.copy", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string caption = null, double? latitude = null, double? longitude = null, string placeStr = null, string foursquareId = null, bool? deletePlace = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["caption"] = caption,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["place_str"] = placeStr,
                ["foursquare_id"] = foursquareId,
                ["delete_place"] = RequestHelpers.ParseBoolean(deletePlace),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Move(UserAccessToken accessToken, int? ownerId = null, int? targetAlbumId = null, int? photoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["target_album_id"] = targetAlbumId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.move", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MakeCover(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.makeCover", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.reorderAlbums", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderPhotos(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.reorderPhotos", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAllResponse>> GetAll(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["no_service_albums"] = RequestHelpers.ParseBoolean(noServiceAlbums),
                ["need_hidden"] = RequestHelpers.ParseBoolean(needHidden),
                ["skip_hidden"] = RequestHelpers.ParseBoolean(skipHidden),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAllResponse>("photos.getAll", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAllExtendedResponse>> GetAllExtended(UserAccessToken accessToken, int? ownerId = null, bool? extended = null, int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null, bool? needHidden = null, bool? skipHidden = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
                ["no_service_albums"] = RequestHelpers.ParseBoolean(noServiceAlbums),
                ["need_hidden"] = RequestHelpers.ParseBoolean(needHidden),
                ["skip_hidden"] = RequestHelpers.ParseBoolean(skipHidden),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAllExtendedResponse>("photos.getAll", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetUserPhotosResponse>> GetUserPhotos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<PhotosGetUserPhotosResponse>("photos.getUserPhotos", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? albumId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["album_id"] = albumId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.deleteAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? photoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? photoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ConfirmTag(UserAccessToken accessToken, int? ownerId = null, string photoId = null, int? tagId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId,
                ["tag_id"] = tagId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.confirmTag", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["access_key"] = accessKey,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<PhotosGetCommentsResponse>("photos.getComments", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, string accessKey = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["access_key"] = accessKey,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<PhotosGetCommentsExtendedResponse>("photos.getComments", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetAllCommentsResponse>> GetAllComments(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, bool? needLikes = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetAllCommentsResponse>("photos.getAllComments", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string accessKey = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["sticker_id"] = stickerId?.ToString(),
                ["access_key"] = accessKey,
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("photos.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.editComment", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PhotosPhotoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PhotosPhotoTag>>("photos.getTags", accessToken, request);
        }

        public Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? userId = null, double? x = null, double? y = null, double? x2 = null, double? y2 = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["x"] = x?.ToString(),
                ["y"] = y?.ToString(),
                ["x2"] = x2?.ToString(),
                ["y2"] = y2?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("photos.putTag", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? ownerId = null, int? photoId = null, int? tagId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["photo_id"] = photoId?.ToString(),
                ["tag_id"] = tagId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("photos.removeTag", accessToken, request);
        }

        public Task<ApiRequest<PhotosGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PhotosGetNewTagsResponse>("photos.getNewTags", accessToken, request);
        }

    }

    internal class FriendsApi : IFriendsApi
    {
        public Task<ApiRequest<FriendsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(UserAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetResponse>> Get(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", null, request);
        }

        public Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", null, request);
        }

        public Task<ApiRequest<FriendsGetResponse>> Get(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetResponse>("friends.get", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetFieldsResponse>> GetFields(ServiceAccessToken accessToken, int? userId = null, string order = null, int? listId = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["order"] = order,
                ["list_id"] = listId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetFieldsResponse>("friends.get", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetOnline(UserAccessToken accessToken, int? userId = null, int? listId = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["list_id"] = listId?.ToString(),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getOnline", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetOnlineOnlineMobileResponse>> GetOnlineOnlineMobile(UserAccessToken accessToken, int? userId = null, int? listId = null, bool? onlineMobile = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["list_id"] = listId?.ToString(),
                ["online_mobile"] = RequestHelpers.ParseBoolean(onlineMobile),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FriendsGetOnlineOnlineMobileResponse>("friends.getOnline", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetMutual(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["source_uid"] = sourceUid?.ToString(),
                ["target_uid"] = targetUid?.ToString(),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getMutual", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<FriendsMutualFriend>>> GetMutualTargetUids(UserAccessToken accessToken, int? sourceUid = null, int? targetUid = null, IEnumerable<int?> targetUids = null, string order = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["source_uid"] = sourceUid?.ToString(),
                ["target_uid"] = targetUid?.ToString(),
                ["target_uids"] = RequestHelpers.ParseEnumerable(targetUids),
                ["order"] = order,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<FriendsMutualFriend>>("friends.getMutual", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetRecent(UserAccessToken accessToken, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getRecent", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetRequestsResponse>> GetRequests(UserAccessToken accessToken, int? offset = null, int? count = null, bool? @out = null, int? sort = null, bool? suggested = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["@out"] = RequestHelpers.ParseBoolean(@out),
                ["sort"] = sort?.ToString(),
                ["suggested"] = RequestHelpers.ParseBoolean(suggested),
            };

            return RequestManager.CreateRequestAsync<FriendsGetRequestsResponse>("friends.getRequests", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetRequestsNeedMutualResponse>> GetRequestsNeedMutual(UserAccessToken accessToken, int? offset = null, int? count = null, bool? needMutual = null, bool? @out = null, int? sort = null, bool? suggested = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["need_mutual"] = RequestHelpers.ParseBoolean(needMutual),
                ["@out"] = RequestHelpers.ParseBoolean(@out),
                ["sort"] = sort?.ToString(),
                ["suggested"] = RequestHelpers.ParseBoolean(suggested),
            };

            return RequestManager.CreateRequestAsync<FriendsGetRequestsNeedMutualResponse>("friends.getRequests", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetRequestsExtendedResponse>> GetRequestsExtended(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null, bool? @out = null, int? sort = null, bool? suggested = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["@out"] = RequestHelpers.ParseBoolean(@out),
                ["sort"] = sort?.ToString(),
                ["suggested"] = RequestHelpers.ParseBoolean(suggested),
            };

            return RequestManager.CreateRequestAsync<FriendsGetRequestsExtendedResponse>("friends.getRequests", accessToken, request);
        }

        public Task<ApiRequest<int?>> Add(UserAccessToken accessToken, int? userId = null, string text = null, bool? follow = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["text"] = text,
                ["follow"] = RequestHelpers.ParseBoolean(follow),
            };

            return RequestManager.CreateRequestAsync<int?>("friends.add", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? userId = null, IEnumerable<int?> listIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["list_ids"] = RequestHelpers.ParseEnumerable(listIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.edit", accessToken, request);
        }

        public Task<ApiRequest<FriendsDeleteResponse>> Delete(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FriendsDeleteResponse>("friends.delete", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetListsResponse>> GetLists(UserAccessToken accessToken, int? userId = null, bool? returnSystem = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["return_system"] = RequestHelpers.ParseBoolean(returnSystem),
            };

            return RequestManager.CreateRequestAsync<FriendsGetListsResponse>("friends.getLists", accessToken, request);
        }

        public Task<ApiRequest<FriendsAddListResponse>> AddList(UserAccessToken accessToken, string name = null, IEnumerable<int?> userIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["name"] = name,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<FriendsAddListResponse>("friends.addList", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditList(UserAccessToken accessToken, string name = null, int? listId = null, IEnumerable<int?> userIds = null, IEnumerable<int?> addUserIds = null, IEnumerable<int?> deleteUserIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["name"] = name,
                ["list_id"] = listId?.ToString(),
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["add_user_ids"] = RequestHelpers.ParseEnumerable(addUserIds),
                ["delete_user_ids"] = RequestHelpers.ParseEnumerable(deleteUserIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.editList", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteList(UserAccessToken accessToken, int? listId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["list_id"] = listId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.deleteList", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetAppUsers(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("friends.getAppUsers", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<FriendsUserXtrPhone>>> GetByPhones(UserAccessToken accessToken, IEnumerable<string> phones = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["phones"] = RequestHelpers.ParseEnumerable(phones),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<FriendsUserXtrPhone>>("friends.getByPhones", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAllRequests(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<bool?>("friends.deleteAllRequests", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetSuggestionsResponse>> GetSuggestions(UserAccessToken accessToken, IEnumerable<string> filter = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["filter"] = RequestHelpers.ParseEnumerable(filter),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetSuggestionsResponse>("friends.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<FriendsFriendStatus>>> AreFriends(UserAccessToken accessToken, IEnumerable<int?> userIds = null, bool? needSign = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["need_sign"] = RequestHelpers.ParseBoolean(needSign),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<FriendsFriendStatus>>("friends.areFriends", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetAvailableForCallResponse>> GetAvailableForCall(UserAccessToken accessToken, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetAvailableForCallResponse>("friends.getAvailableForCall", accessToken, request);
        }

        public Task<ApiRequest<FriendsGetAvailableForCallFieldsResponse>> GetAvailableForCallFields(UserAccessToken accessToken, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<FriendsGetAvailableForCallFieldsResponse>("friends.getAvailableForCall", accessToken, request);
        }

        public Task<ApiRequest<FriendsSearchResponse>> Search(UserAccessToken accessToken, int? userId = null, string q = null, IEnumerable<string> fields = null, string nameCase = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["q"] = q,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FriendsSearchResponse>("friends.search", accessToken, request);
        }

    }

    internal class WidgetsApi : IWidgetsApi
    {
        public Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["widget_api_id"] = widgetApiId?.ToString(),
                ["url"] = url,
                ["page_id"] = pageId,
                ["order"] = order,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WidgetsGetCommentsResponse>("widgets.getComments", accessToken, request);
        }

        public Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["widget_api_id"] = widgetApiId?.ToString(),
                ["url"] = url,
                ["page_id"] = pageId,
                ["order"] = order,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WidgetsGetCommentsResponse>("widgets.getComments", null, request);
        }

        public Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["widget_api_id"] = widgetApiId?.ToString(),
                ["url"] = url,
                ["page_id"] = pageId,
                ["order"] = order,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WidgetsGetCommentsResponse>("widgets.getComments", accessToken, request);
        }

        public Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(UserAccessToken accessToken, int? widgetApiId = null, string order = null, string period = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["widget_api_id"] = widgetApiId?.ToString(),
                ["order"] = order,
                ["period"] = period,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WidgetsGetPagesResponse>("widgets.getPages", accessToken, request);
        }

        public Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(int? widgetApiId = null, string order = null, string period = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["widget_api_id"] = widgetApiId?.ToString(),
                ["order"] = order,
                ["period"] = period,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WidgetsGetPagesResponse>("widgets.getPages", null, request);
        }

        public Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(ServiceAccessToken accessToken, int? widgetApiId = null, string order = null, string period = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["widget_api_id"] = widgetApiId?.ToString(),
                ["order"] = order,
                ["period"] = period,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WidgetsGetPagesResponse>("widgets.getPages", accessToken, request);
        }

    }

    internal class SecureApi : ISecureApi
    {
        public Task<ApiRequest<int?>> GetAppBalance(ServiceAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<int?>("secure.getAppBalance", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<SecureTransaction>>> GetTransactionsHistory(ServiceAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SecureTransaction>>("secure.getTransactionsHistory", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<SecureSmsNotification>>> GetSMSHistory(ServiceAccessToken accessToken, int? userId = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? limit = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["date_from"] = RequestHelpers.ParseDateTime(dateFrom),
                ["date_to"] = RequestHelpers.ParseDateTime(dateTo),
                ["limit"] = limit?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SecureSmsNotification>>("secure.getSMSHistory", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SendSMSNotification(ServiceAccessToken accessToken, int? userId = null, string message = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["message"] = message,
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.sendSMSNotification", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> SendNotification(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null, int? userId = null, string message = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
                ["user_id"] = userId?.ToString(),
                ["message"] = message,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("secure.sendNotification", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetCounter(ServiceAccessToken accessToken, IEnumerable<string> counters = null, int? userId = null, int? counter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["counters"] = RequestHelpers.ParseEnumerable(counters),
                ["user_id"] = userId?.ToString(),
                ["counter"] = counter?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.setCounter", accessToken, request);
        }

        public Task<ApiRequest<bool?>> SetUserLevel(ServiceAccessToken accessToken, IEnumerable<string> levels = null, int? userId = null, int? level = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["levels"] = RequestHelpers.ParseEnumerable(levels),
                ["user_id"] = userId?.ToString(),
                ["level"] = level?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.setUserLevel", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<SecureLevel>>> GetUserLevel(ServiceAccessToken accessToken, IEnumerable<int?> userIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_ids"] = RequestHelpers.ParseEnumerable(userIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SecureLevel>>("secure.getUserLevel", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddAppEvent(UserAccessToken accessToken, int? userId = null, int? activityId = null, int? value = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["activity_id"] = activityId?.ToString(),
                ["value"] = value?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("secure.addAppEvent", accessToken, request);
        }

        public Task<ApiRequest<SecureTokenChecked>> CheckToken(UserAccessToken accessToken, string token = null, string ip = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["token"] = token,
                ["ip"] = ip,
            };

            return RequestManager.CreateRequestAsync<SecureTokenChecked>("secure.checkToken", accessToken, request);
        }

    }

    internal class StreamingApi : IStreamingApi
    {
        public Task<ApiRequest<StreamingGetServerUrlResponse>> GetServerUrl(ServiceAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<StreamingGetServerUrlResponse>("streaming.getServerUrl", accessToken, request);
        }

    }

    internal class StorageApi : IStorageApi
    {
        public Task<ApiRequest<string>> Get(UserAccessToken accessToken, string key = null, IEnumerable<string> keys = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["keys"] = RequestHelpers.ParseEnumerable(keys),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<string>("storage.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string key = null, string value = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["value"] = value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("storage.set", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<string>>> GetKeys(UserAccessToken accessToken, int? userId = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<string>>("storage.getKeys", accessToken, request);
        }

    }

    internal class OrdersApi : IOrdersApi
    {
        public Task<ApiRequest<IEnumerable<OrdersOrder>>> Get(UserAccessToken accessToken, int? count = null, bool? testMode = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<OrdersOrder>>("orders.get", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<OrdersOrder>>> GetById(UserAccessToken accessToken, int? orderId = null, IEnumerable<int?> orderIds = null, bool? testMode = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["order_id"] = orderId?.ToString(),
                ["order_ids"] = RequestHelpers.ParseEnumerable(orderIds),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<OrdersOrder>>("orders.getById", accessToken, request);
        }

        public Task<ApiRequest<string>> ChangeState(UserAccessToken accessToken, int? orderId = null, string action = null, int? appOrderId = null, bool? testMode = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["order_id"] = orderId?.ToString(),
                ["action"] = action,
                ["app_order_id"] = appOrderId?.ToString(),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
            };

            return RequestManager.CreateRequestAsync<string>("orders.changeState", accessToken, request);
        }

        public Task<ApiRequest<OrdersAmount>> GetAmount(int? userId = null, IEnumerable<string> votes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["votes"] = RequestHelpers.ParseEnumerable(votes),
            };

            return RequestManager.CreateRequestAsync<OrdersAmount>("orders.getAmount", null, request);
        }

    }

    internal class StatusApi : IStatusApi
    {
        public Task<ApiRequest<StatusStatus>> Get(UserAccessToken accessToken, int? userId = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<StatusStatus>("status.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Set(UserAccessToken accessToken, string text = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["text"] = text,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("status.set", accessToken, request);
        }

    }

    internal class LeadsApi : ILeadsApi
    {
        public Task<ApiRequest<LeadsComplete>> Complete(UserAccessToken accessToken, string vkSid = null, string secret = null, string comment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["vk_sid"] = vkSid,
                ["secret"] = secret,
                ["comment"] = comment,
            };

            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", accessToken, request);
        }

        public Task<ApiRequest<LeadsComplete>> Complete(string vkSid = null, string secret = null, string comment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["vk_sid"] = vkSid,
                ["secret"] = secret,
                ["comment"] = comment,
            };

            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", null, request);
        }

        public Task<ApiRequest<LeadsComplete>> Complete(ServiceAccessToken accessToken, string vkSid = null, string secret = null, string comment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["vk_sid"] = vkSid,
                ["secret"] = secret,
                ["comment"] = comment,
            };

            return RequestManager.CreateRequestAsync<LeadsComplete>("leads.complete", accessToken, request);
        }

        public Task<ApiRequest<LeadsStart>> Start(UserAccessToken accessToken, int? leadId = null, string secret = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
            };

            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", accessToken, request);
        }

        public Task<ApiRequest<LeadsStart>> Start(int? leadId = null, string secret = null)
        {
            var request = new Dictionary<string, string>
            {
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
            };

            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", null, request);
        }

        public Task<ApiRequest<LeadsStart>> Start(ServiceAccessToken accessToken, int? leadId = null, string secret = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
            };

            return RequestManager.CreateRequestAsync<LeadsStart>("leads.start", accessToken, request);
        }

        public Task<ApiRequest<LeadsLead>> GetStats(UserAccessToken accessToken, int? leadId = null, string secret = null, string dateStart = null, string dateEnd = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lead_id"] = leadId?.ToString(),
                ["secret"] = secret,
                ["date_start"] = dateStart,
                ["date_end"] = dateEnd,
            };

            return RequestManager.CreateRequestAsync<LeadsLead>("leads.getStats", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(UserAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offer_id"] = offerId?.ToString(),
                ["secret"] = secret,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["status"] = status?.ToString(),
                ["reverse"] = RequestHelpers.ParseBoolean(reverse),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<LeadsEntry>>("leads.getUsers", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offer_id"] = offerId?.ToString(),
                ["secret"] = secret,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["status"] = status?.ToString(),
                ["reverse"] = RequestHelpers.ParseBoolean(reverse),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<LeadsEntry>>("leads.getUsers", null, request);
        }

        public Task<ApiRequest<IEnumerable<LeadsEntry>>> GetUsers(ServiceAccessToken accessToken, int? offerId = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offer_id"] = offerId?.ToString(),
                ["secret"] = secret,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["status"] = status?.ToString(),
                ["reverse"] = RequestHelpers.ParseBoolean(reverse),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<LeadsEntry>>("leads.getUsers", accessToken, request);
        }

        public Task<ApiRequest<LeadsChecked>> CheckUser(UserAccessToken accessToken, int? leadId = null, int? testResult = null, int? age = null, string country = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lead_id"] = leadId?.ToString(),
                ["test_result"] = testResult?.ToString(),
                ["age"] = age?.ToString(),
                ["country"] = country,
            };

            return RequestManager.CreateRequestAsync<LeadsChecked>("leads.checkUser", accessToken, request);
        }

        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(UserAccessToken accessToken, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", accessToken, request);
        }

        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", null, request);
        }

        public Task<ApiRequest<LeadsMetricHitResponse>> MetricHit(ServiceAccessToken accessToken, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<LeadsMetricHitResponse>("leads.metricHit", accessToken, request);
        }

    }

    internal class PagesApi : IPagesApi
    {
        public Task<ApiRequest<PagesWikipageFull>> Get(UserAccessToken accessToken, int? ownerId = null, int? pageId = null, bool? global = null, bool? sitePreview = null, string title = null, bool? needSource = null, bool? needHtml = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["page_id"] = pageId?.ToString(),
                ["global"] = RequestHelpers.ParseBoolean(global),
                ["site_preview"] = RequestHelpers.ParseBoolean(sitePreview),
                ["title"] = title,
                ["need_source"] = RequestHelpers.ParseBoolean(needSource),
                ["need_html"] = RequestHelpers.ParseBoolean(needHtml),
            };

            return RequestManager.CreateRequestAsync<PagesWikipageFull>("pages.get", accessToken, request);
        }

        public Task<ApiRequest<int?>> Save(UserAccessToken accessToken, string text = null, int? pageId = null, int? groupId = null, int? userId = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["text"] = text,
                ["page_id"] = pageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<int?>("pages.save", accessToken, request);
        }

        public Task<ApiRequest<int?>> SaveAccess(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null, int? view = null, int? edit = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["page_id"] = pageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["view"] = view?.ToString(),
                ["edit"] = edit?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("pages.saveAccess", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PagesWikipageVersion>>> GetHistory(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["page_id"] = pageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PagesWikipageVersion>>("pages.getHistory", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PagesWikipage>>> GetTitles(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PagesWikipage>>("pages.getTitles", accessToken, request);
        }

        public Task<ApiRequest<PagesWikipageFull>> GetVersion(UserAccessToken accessToken, int? versionId = null, int? groupId = null, int? userId = null, bool? needHtml = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["version_id"] = versionId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["need_html"] = RequestHelpers.ParseBoolean(needHtml),
            };

            return RequestManager.CreateRequestAsync<PagesWikipageFull>("pages.getVersion", accessToken, request);
        }

        public Task<ApiRequest<string>> ParseWiki(UserAccessToken accessToken, string text = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["text"] = text,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<string>("pages.parseWiki", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ClearCache(UserAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ClearCache(string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", null, request);
        }

        public Task<ApiRequest<bool?>> ClearCache(ServiceAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", accessToken, request);
        }
    }

    internal class BoardApi : IBoardApi
    {
        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", accessToken, request);
        }

        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(UserAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsExtendedResponse>("board.getTopics", accessToken, request);
        }

        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", null, request);
        }

        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsExtendedResponse>("board.getTopics", null, request);
        }

        public Task<ApiRequest<BoardGetTopicsResponse>> GetTopics(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsResponse>("board.getTopics", accessToken, request);
        }

        public Task<ApiRequest<BoardGetTopicsExtendedResponse>> GetTopicsExtended(ServiceAccessToken accessToken, int? groupId = null, IEnumerable<int?> topicIds = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? previewLength = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_ids"] = RequestHelpers.ParseEnumerable(topicIds),
                ["order"] = order?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["preview"] = preview?.ToString(),
                ["preview_length"] = previewLength?.ToString(),
            };

            return RequestManager.CreateRequestAsync<BoardGetTopicsExtendedResponse>("board.getTopics", accessToken, request);
        }

        public Task<ApiRequest<BoardGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", accessToken, request);
        }

        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsExtendedResponse>("board.getComments", accessToken, request);
        }

        public Task<ApiRequest<BoardGetCommentsResponse>> GetComments(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", null, request);
        }

        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsExtendedResponse>("board.getComments", null, request);
        }

        public Task<ApiRequest<BoardGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsResponse>("board.getComments", accessToken, request);
        }

        public Task<ApiRequest<BoardGetCommentsExtendedResponse>> GetCommentsExtended(ServiceAccessToken accessToken, int? groupId = null, int? topicId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<BoardGetCommentsExtendedResponse>("board.getComments", accessToken, request);
        }

        public Task<ApiRequest<int?>> AddTopic(UserAccessToken accessToken, int? groupId = null, string title = null, string text = null, bool? fromGroup = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["title"] = title,
                ["text"] = text,
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<int?>("board.addTopic", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("board.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.deleteTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<bool?>("board.editTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.editComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(GroupAccessToken accessToken, int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> OpenTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.openTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> CloseTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.closeTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> FixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.fixTopic", accessToken, request);
        }

        public Task<ApiRequest<bool?>> UnfixTopic(UserAccessToken accessToken, int? groupId = null, int? topicId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["topic_id"] = topicId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("board.unfixTopic", accessToken, request);
        }

    }

    internal class VideoApi : IVideoApi
    {
        public Task<ApiRequest<VideoGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["videos"] = RequestHelpers.ParseEnumerable(videos),
                ["album_id"] = albumId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetResponse>("video.get", accessToken, request);
        }

        public Task<ApiRequest<VideoGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, IEnumerable<string> videos = null, int? albumId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["videos"] = RequestHelpers.ParseEnumerable(videos),
                ["album_id"] = albumId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetExtendedResponse>("video.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string name = null, string desc = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["name"] = name,
                ["desc"] = desc,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["no_comments"] = RequestHelpers.ParseBoolean(noComments),
                ["repeat"] = RequestHelpers.ParseBoolean(repeat),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Add(UserAccessToken accessToken, int? targetId = null, int? videoId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["target_id"] = targetId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.add", accessToken, request);
        }

        public Task<ApiRequest<VideoSaveResult>> Save(UserAccessToken accessToken, string name = null, string description = null, bool? isPrivate = null, bool? wallpost = null, string link = null, int? groupId = null, int? albumId = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null, bool? noComments = null, bool? repeat = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["name"] = name,
                ["description"] = description,
                ["is_private"] = RequestHelpers.ParseBoolean(isPrivate),
                ["wallpost"] = RequestHelpers.ParseBoolean(wallpost),
                ["link"] = link,
                ["group_id"] = groupId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
                ["no_comments"] = RequestHelpers.ParseBoolean(noComments),
                ["repeat"] = RequestHelpers.ParseBoolean(repeat),
            };

            return RequestManager.CreateRequestAsync<VideoSaveResult>("video.save", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? videoId = null, int? ownerId = null, int? targetId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["video_id"] = videoId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["target_id"] = targetId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? videoId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["video_id"] = videoId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.restore", accessToken, request);
        }

        public Task<ApiRequest<VideoSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["sort"] = sort?.ToString(),
                ["hd"] = hd?.ToString(),
                ["adult"] = RequestHelpers.ParseBoolean(adult),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["search_own"] = RequestHelpers.ParseBoolean(searchOwn),
                ["offset"] = offset?.ToString(),
                ["longer"] = longer?.ToString(),
                ["shorter"] = shorter?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoSearchResponse>("video.search", accessToken, request);
        }

        public Task<ApiRequest<VideoSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["sort"] = sort?.ToString(),
                ["hd"] = hd?.ToString(),
                ["adult"] = RequestHelpers.ParseBoolean(adult),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["search_own"] = RequestHelpers.ParseBoolean(searchOwn),
                ["offset"] = offset?.ToString(),
                ["longer"] = longer?.ToString(),
                ["shorter"] = shorter?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoSearchExtendedResponse>("video.search", accessToken, request);
        }

        public Task<ApiRequest<VideoGetUserVideosResponse>> GetUserVideos(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetUserVideosResponse>("video.getUserVideos", accessToken, request);
        }

        public Task<ApiRequest<VideoGetUserVideosExtendedResponse>> GetUserVideosExtended(UserAccessToken accessToken, int? userId = null, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetUserVideosExtendedResponse>("video.getUserVideos", accessToken, request);
        }

        public Task<ApiRequest<VideoGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetAlbumsResponse>("video.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<VideoGetAlbumsExtendedResponse>> GetAlbumsExtended(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetAlbumsExtendedResponse>("video.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<VideoVideoAlbumFull>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoVideoAlbumFull>("video.getAlbumById", accessToken, request);
        }

        public Task<ApiRequest<VideoAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? groupId = null, string title = null, IEnumerable<string> privacy = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["title"] = title,
                ["privacy"] = RequestHelpers.ParseEnumerable(privacy),
            };

            return RequestManager.CreateRequestAsync<VideoAddAlbumResponse>("video.addAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null, string title = null, IEnumerable<string> privacy = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["title"] = title,
                ["privacy"] = RequestHelpers.ParseEnumerable(privacy),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.editAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? groupId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.deleteAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.reorderAlbums", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderVideos(UserAccessToken accessToken, int? targetId = null, int? albumId = null, int? ownerId = null, int? videoId = null, int? beforeOwnerId = null, int? beforeVideoId = null, int? afterOwnerId = null, int? afterVideoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["target_id"] = targetId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["before_owner_id"] = beforeOwnerId?.ToString(),
                ["before_video_id"] = beforeVideoId?.ToString(),
                ["after_owner_id"] = afterOwnerId?.ToString(),
                ["after_video_id"] = afterVideoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.reorderVideos", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddToAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.addToAlbum", null, request);
        }

        public Task<ApiRequest<bool?>> RemoveFromAlbum(int? targetId = null, int? albumId = null, IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.removeFromAlbum", null, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> GetAlbumsByVideo(int? targetId = null, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("video.getAlbumsByVideo", null, request);
        }

        public Task<ApiRequest<VideoGetAlbumsByVideoExtendedResponse>> GetAlbumsByVideoExtended(int? targetId = null, int? ownerId = null, int? videoId = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["target_id"] = targetId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetAlbumsByVideoExtendedResponse>("video.getAlbumsByVideo", null, request);
        }

        public Task<ApiRequest<VideoGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
            };

            return RequestManager.CreateRequestAsync<VideoGetCommentsResponse>("video.getComments", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCommentsExtendedResponse>> GetCommentsExtended(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, string sort = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCommentsExtendedResponse>("video.getComments", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("video.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.editComment", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<VideoVideoTag>>> GetTags(UserAccessToken accessToken, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<VideoVideoTag>>("video.getTags", accessToken, request);
        }

        public Task<ApiRequest<int?>> PutTag(UserAccessToken accessToken, int? userId = null, int? ownerId = null, int? videoId = null, string taggedName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["tagged_name"] = taggedName,
            };

            return RequestManager.CreateRequestAsync<int?>("video.putTag", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveTag(UserAccessToken accessToken, int? tagId = null, int? ownerId = null, int? videoId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["tag_id"] = tagId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.removeTag", accessToken, request);
        }

        public Task<ApiRequest<VideoGetNewTagsResponse>> GetNewTags(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetNewTagsResponse>("video.getNewTags", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? videoId = null, int? reason = null, string comment = null, string searchQuery = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["video_id"] = videoId?.ToString(),
                ["reason"] = reason?.ToString(),
                ["comment"] = comment,
                ["search_query"] = searchQuery,
            };

            return RequestManager.CreateRequestAsync<bool?>("video.report", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.reportComment", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogResponse>("video.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(UserAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogExtendedResponse>("video.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogResponse>("video.getCatalog", null, request);
        }

        public Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogExtendedResponse>("video.getCatalog", null, request);
        }

        public Task<ApiRequest<VideoGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogResponse>("video.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogExtendedResponse>> GetCatalogExtended(ServiceAccessToken accessToken, int? count = null, int? itemsCount = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["items_count"] = itemsCount?.ToString(),
                ["from"] = from,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogExtendedResponse>("video.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionResponse>("video.getCatalogSection", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(UserAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(string sectionId = null, string from = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionResponse>("video.getCatalogSection", null, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(string sectionId = null, string from = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", null, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionResponse>> GetCatalogSection(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionResponse>("video.getCatalogSection", accessToken, request);
        }

        public Task<ApiRequest<VideoGetCatalogSectionExtendedResponse>> GetCatalogSectionExtended(ServiceAccessToken accessToken, string sectionId = null, string from = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId,
                ["from"] = from,
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<VideoGetCatalogSectionExtendedResponse>("video.getCatalogSection", accessToken, request);
        }

        public Task<ApiRequest<bool?>> HideCatalogSection(UserAccessToken accessToken, int? sectionId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section_id"] = sectionId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("video.hideCatalogSection", accessToken, request);
        }

    }

    internal class NotesApi : INotesApi
    {
        public Task<ApiRequest<NotesGetResponse>> Get(UserAccessToken accessToken, IEnumerable<int?> noteIds = null, int? userId = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_ids"] = RequestHelpers.ParseEnumerable(noteIds),
                ["user_id"] = userId?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NotesGetResponse>("notes.get", accessToken, request);
        }

        public Task<ApiRequest<NotesNote>> GetById(UserAccessToken accessToken, int? noteId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NotesNote>("notes.getById", accessToken, request);
        }

        public Task<ApiRequest<int?>> Add(UserAccessToken accessToken, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["title"] = title,
                ["text"] = text,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
            };

            return RequestManager.CreateRequestAsync<int?>("notes.add", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? noteId = null, string title = null, string text = null, IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
                ["title"] = title,
                ["text"] = text,
                ["privacy_view"] = RequestHelpers.ParseEnumerable(privacyView),
                ["privacy_comment"] = RequestHelpers.ParseEnumerable(privacyComment),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? noteId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.delete", accessToken, request);
        }

        public Task<ApiRequest<NotesGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<NotesGetCommentsResponse>("notes.getComments", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? noteId = null, int? ownerId = null, int? replyTo = null, string message = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["note_id"] = noteId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["reply_to"] = replyTo?.ToString(),
                ["message"] = message,
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("notes.createComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null, string message = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["comment_id"] = commentId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
                ["message"] = message,
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.editComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["comment_id"] = commentId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? commentId = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["comment_id"] = commentId?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("notes.restoreComment", accessToken, request);
        }

    }

    internal class PlacesApi : IPlacesApi
    {
        public Task<ApiRequest<PlacesAddResponse>> Add(UserAccessToken accessToken, int? type = null, string title = null, double? latitude = null, double? longitude = null, int? country = null, int? city = null, string address = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type?.ToString(),
                ["title"] = title,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["country"] = country?.ToString(),
                ["city"] = city?.ToString(),
                ["address"] = address,
            };

            return RequestManager.CreateRequestAsync<PlacesAddResponse>("places.add", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PlacesPlaceMin>>> GetById(UserAccessToken accessToken, IEnumerable<int?> places = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["places"] = RequestHelpers.ParseEnumerable(places),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PlacesPlaceMin>>("places.getById", accessToken, request);
        }

        public Task<ApiRequest<PlacesSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? city = null, double? latitude = null, double? longitude = null, int? radius = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["city"] = city?.ToString(),
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["radius"] = radius?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PlacesSearchResponse>("places.search", accessToken, request);
        }

        public Task<ApiRequest<PlacesCheckinResponse>> Checkin(UserAccessToken accessToken, int? placeId = null, string text = null, double? latitude = null, double? longitude = null, bool? friendsOnly = null, IEnumerable<string> services = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["place_id"] = placeId?.ToString(),
                ["text"] = text,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["services"] = RequestHelpers.ParseEnumerable(services),
            };

            return RequestManager.CreateRequestAsync<PlacesCheckinResponse>("places.checkin", accessToken, request);
        }

        public Task<ApiRequest<PlacesGetCheckinsResponse>> GetCheckins(UserAccessToken accessToken, double? latitude = null, double? longitude = null, int? place = null, int? userId = null, DateTime? offset = null, DateTime? count = null, DateTime? timestamp = null, bool? friendsOnly = null, bool? needPlaces = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["latitude"] = latitude?.ToString(),
                ["longitude"] = longitude?.ToString(),
                ["place"] = place?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["offset"] = RequestHelpers.ParseDateTime(offset),
                ["count"] = RequestHelpers.ParseDateTime(count),
                ["timestamp"] = RequestHelpers.ParseDateTime(timestamp),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["need_places"] = RequestHelpers.ParseBoolean(needPlaces),
            };

            return RequestManager.CreateRequestAsync<PlacesGetCheckinsResponse>("places.getCheckins", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PlacesTypes>>> GetTypes(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PlacesTypes>>("places.getTypes", accessToken, request);
        }

    }

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

    internal class LikesApi : ILikesApi
    {
        public Task<ApiRequest<LikesGetListResponse>> GetList(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", accessToken, request);
        }

        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", accessToken, request);
        }

        public Task<ApiRequest<LikesGetListResponse>> GetList(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", null, request);
        }

        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", null, request);
        }

        public Task<ApiRequest<LikesGetListResponse>> GetList(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListResponse>("likes.getList", accessToken, request);
        }

        public Task<ApiRequest<LikesGetListExtendedResponse>> GetListExtended(ServiceAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, bool? extended = null, int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["page_url"] = pageUrl,
                ["filter"] = filter,
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["skip_own"] = RequestHelpers.ParseBoolean(skipOwn),
            };

            return RequestManager.CreateRequestAsync<LikesGetListExtendedResponse>("likes.getList", accessToken, request);
        }

        public Task<ApiRequest<LikesAddResponse>> Add(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<LikesAddResponse>("likes.add", accessToken, request);
        }

        public Task<ApiRequest<LikesDeleteResponse>> Delete(UserAccessToken accessToken, string type = null, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<LikesDeleteResponse>("likes.delete", accessToken, request);
        }

        public Task<ApiRequest<LikesIsLikedResponse>> IsLiked(UserAccessToken accessToken, int? userId = null, string type = null, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["type"] = type,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<LikesIsLikedResponse>("likes.isLiked", accessToken, request);
        }

    }

    internal class PollsApi : IPollsApi
    {
        public Task<ApiRequest<PollsPoll>> GetById(UserAccessToken accessToken, int? ownerId = null, bool? isBoard = null, int? pollId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
                ["poll_id"] = pollId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<PollsPoll>("polls.getById", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["answer_id"] = answerId?.ToString(),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
            };

            return RequestManager.CreateRequestAsync<bool?>("polls.addVote", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteVote(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, int? answerId = null, bool? isBoard = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["answer_id"] = answerId?.ToString(),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
            };

            return RequestManager.CreateRequestAsync<bool?>("polls.deleteVote", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PollsVoters>>> GetVoters(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, IEnumerable<int?> answerIds = null, bool? isBoard = null, bool? friendsOnly = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["answer_ids"] = RequestHelpers.ParseEnumerable(answerIds),
                ["is_board"] = RequestHelpers.ParseBoolean(isBoard),
                ["friends_only"] = RequestHelpers.ParseBoolean(friendsOnly),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PollsVoters>>("polls.getVoters", accessToken, request);
        }

        public Task<ApiRequest<PollsPoll>> Create(UserAccessToken accessToken, string question = null, bool? isAnonymous = null, int? ownerId = null, JsonArray addAnswers = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["question"] = question,
                ["is_anonymous"] = RequestHelpers.ParseBoolean(isAnonymous),
                ["owner_id"] = ownerId?.ToString(),
                ["add_answers"] = addAnswers?.JsonValue,
            };

            return RequestManager.CreateRequestAsync<PollsPoll>("polls.create", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? pollId = null, string question = null, JsonArray addAnswers = null, JsonArray editAnswers = null, JsonArray deleteAnswers = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["poll_id"] = pollId?.ToString(),
                ["question"] = question,
                ["add_answers"] = addAnswers?.JsonValue,
                ["edit_answers"] = editAnswers?.JsonValue,
                ["delete_answers"] = deleteAnswers?.JsonValue,
            };

            return RequestManager.CreateRequestAsync<bool?>("polls.edit", accessToken, request);
        }

    }

    internal class DocsApi : IDocsApi
    {
        public Task<ApiRequest<DocsGetResponse>> Get(UserAccessToken accessToken, int? count = null, int? offset = null, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetResponse>("docs.get", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<DocsDoc>>> GetById(UserAccessToken accessToken, IEnumerable<string> docs = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["docs"] = RequestHelpers.ParseEnumerable(docs),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.getById", accessToken, request);
        }

        public Task<ApiRequest<DocsGetUploadServerResponse>> GetUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetUploadServerResponse>("docs.getUploadServer", accessToken, request);
        }

        public Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetWallUploadServerResponse>("docs.getWallUploadServer", accessToken, request);
        }

        public Task<ApiRequest<DocsGetWallUploadServerResponse>> GetWallUploadServer(GroupAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetWallUploadServerResponse>("docs.getWallUploadServer", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<DocsDoc>>> Save(UserAccessToken accessToken, string file = null, string title = null, string tags = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["file"] = file,
                ["title"] = title,
                ["tags"] = tags,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.save", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<DocsDoc>>> Save(GroupAccessToken accessToken, string file = null, string title = null, string tags = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["file"] = file,
                ["title"] = title,
                ["tags"] = tags,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DocsDoc>>("docs.save", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? docId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["doc_id"] = docId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("docs.delete", accessToken, request);
        }

        public Task<ApiRequest<DocsAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string accessKey = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["doc_id"] = docId?.ToString(),
                ["access_key"] = accessKey,
            };

            return RequestManager.CreateRequestAsync<DocsAddResponse>("docs.add", accessToken, request);
        }

        public Task<ApiRequest<DocsGetTypesResponse>> GetTypes(UserAccessToken accessToken, int? ownerId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsGetTypesResponse>("docs.getTypes", accessToken, request);
        }

        public Task<ApiRequest<DocsSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsSearchResponse>("docs.search", accessToken, request);
        }

        public Task<ApiRequest<DocsSearchResponse>> Search(GroupAccessToken accessToken, string q = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DocsSearchResponse>("docs.search", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? docId = null, string title = null, IEnumerable<string> tags = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["doc_id"] = docId?.ToString(),
                ["title"] = title,
                ["tags"] = RequestHelpers.ParseEnumerable(tags),
            };

            return RequestManager.CreateRequestAsync<bool?>("docs.edit", accessToken, request);
        }

    }

    internal class FaveApi : IFaveApi
    {
        public Task<ApiRequest<FaveGetUsersResponse>> GetUsers(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FaveGetUsersResponse>("fave.getUsers", accessToken, request);
        }

        public Task<ApiRequest<FaveGetPhotosResponse>> GetPhotos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? photoSizes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["photo_sizes"] = RequestHelpers.ParseBoolean(photoSizes),
            };

            return RequestManager.CreateRequestAsync<FaveGetPhotosResponse>("fave.getPhotos", accessToken, request);
        }

        public Task<ApiRequest<FaveGetPostsResponse>> GetPosts(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<FaveGetPostsResponse>("fave.getPosts", accessToken, request);
        }

        public Task<ApiRequest<FaveGetVideosResponse>> GetVideos(UserAccessToken accessToken, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<FaveGetVideosResponse>("fave.getVideos", accessToken, request);
        }

        public Task<ApiRequest<FaveGetLinksResponse>> GetLinks(UserAccessToken accessToken, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<FaveGetLinksResponse>("fave.getLinks", accessToken, request);
        }

        public Task<ApiRequest<FaveGetMarketItemsResponse>> GetMarketItems(UserAccessToken accessToken, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<FaveGetMarketItemsResponse>("fave.getMarketItems", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddUser(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addUser", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveUser(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeUser", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddGroup(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveGroup(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddLink(UserAccessToken accessToken, string link = null, string text = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["link"] = link,
                ["text"] = text,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.addLink", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveLink(UserAccessToken accessToken, string linkId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["link_id"] = linkId,
            };

            return RequestManager.CreateRequestAsync<bool?>("fave.removeLink", accessToken, request);
        }

    }

    internal class NotificationsApi : INotificationsApi
    {
        public Task<ApiRequest<NotificationsGetResponse>> Get(UserAccessToken accessToken, int? count = null, string startFrom = null, IEnumerable<string> filters = null, DateTime? startTime = null, DateTime? endTime = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["start_from"] = startFrom,
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["start_time"] = RequestHelpers.ParseDateTime(startTime),
                ["end_time"] = RequestHelpers.ParseDateTime(endTime),
            };

            return RequestManager.CreateRequestAsync<NotificationsGetResponse>("notifications.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> MarkAsViewed(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<bool?>("notifications.markAsViewed", accessToken, request);
        }

    }

    internal class StatsApi : IStatsApi
    {
        public Task<ApiRequest<IEnumerable<StatsPeriod>>> Get(UserAccessToken accessToken, int? groupId = null, int? appId = null, string dateFrom = null, string dateTo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
                ["app_id"] = appId?.ToString(),
                ["date_from"] = dateFrom,
                ["date_to"] = dateTo,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<StatsPeriod>>("stats.get", accessToken, request);
        }

        public Task<ApiRequest<bool?>> TrackVisitor(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<bool?>("stats.trackVisitor", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<StatsWallpostStat>>> GetPostReach(UserAccessToken accessToken, int? ownerId = null, int? postId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["post_id"] = postId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<StatsWallpostStat>>("stats.getPostReach", accessToken, request);
        }

    }

    internal class SearchApi : ISearchApi
    {
        public Task<ApiRequest<IEnumerable<SearchHint>>> GetHints(UserAccessToken accessToken, string q = null, int? limit = null, IEnumerable<string> filters = null, bool? searchGlobal = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["limit"] = limit?.ToString(),
                ["filters"] = RequestHelpers.ParseEnumerable(filters),
                ["search_global"] = RequestHelpers.ParseBoolean(searchGlobal),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<SearchHint>>("search.getHints", accessToken, request);
        }

    }

    internal class AppsApi : IAppsApi
    {
        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(UserAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["platform"] = platform,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["return_friends"] = RequestHelpers.ParseBoolean(returnFriends),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
                ["q"] = q,
                ["genre_id"] = genreId?.ToString(),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<AppsGetCatalogResponse>("apps.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["platform"] = platform,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["return_friends"] = RequestHelpers.ParseBoolean(returnFriends),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
                ["q"] = q,
                ["genre_id"] = genreId?.ToString(),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<AppsGetCatalogResponse>("apps.getCatalog", null, request);
        }

        public Task<ApiRequest<AppsGetCatalogResponse>> GetCatalog(ServiceAccessToken accessToken, string sort = null, int? offset = null, int? count = null, string platform = null, bool? extended = null, bool? returnFriends = null, IEnumerable<string> fields = null, string nameCase = null, string q = null, int? genreId = null, string filter = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["sort"] = sort,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["platform"] = platform,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["return_friends"] = RequestHelpers.ParseBoolean(returnFriends),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
                ["q"] = q,
                ["genre_id"] = genreId?.ToString(),
                ["filter"] = filter,
            };

            return RequestManager.CreateRequestAsync<AppsGetCatalogResponse>("apps.getCatalog", accessToken, request);
        }

        public Task<ApiRequest<AppsGetResponse>> Get(UserAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["app_id"] = appId?.ToString(),
                ["app_ids"] = RequestHelpers.ParseEnumerable(appIds),
                ["platform"] = platform,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", accessToken, request);
        }

        public Task<ApiRequest<AppsGetResponse>> Get(int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["app_id"] = appId?.ToString(),
                ["app_ids"] = RequestHelpers.ParseEnumerable(appIds),
                ["platform"] = platform,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", null, request);
        }

        public Task<ApiRequest<AppsGetResponse>> Get(ServiceAccessToken accessToken, int? appId = null, IEnumerable<string> appIds = null, string platform = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["app_id"] = appId?.ToString(),
                ["app_ids"] = RequestHelpers.ParseEnumerable(appIds),
                ["platform"] = platform,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["name_case"] = nameCase,
            };

            return RequestManager.CreateRequestAsync<AppsGetResponse>("apps.get", accessToken, request);
        }

        public Task<ApiRequest<int?>> SendRequest(UserAccessToken accessToken, int? userId = null, string text = null, string type = null, string name = null, string key = null, bool? separate = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["text"] = text,
                ["type"] = type,
                ["name"] = name,
                ["key"] = key,
                ["separate"] = RequestHelpers.ParseBoolean(separate),
            };

            return RequestManager.CreateRequestAsync<int?>("apps.sendRequest", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAppRequests(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<bool?>("apps.deleteAppRequests", accessToken, request);
        }

        public Task<ApiRequest<AppsGetFriendsListResponse>> GetFriendsList(UserAccessToken accessToken, int? count = null, string type = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["type"] = type,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<AppsGetFriendsListResponse>("apps.getFriendsList", accessToken, request);
        }

        public Task<ApiRequest<AppsGetLeaderboardResponse>> GetLeaderboard(UserAccessToken accessToken, string type = null, bool? global = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["global"] = RequestHelpers.ParseBoolean(global),
            };

            return RequestManager.CreateRequestAsync<AppsGetLeaderboardResponse>("apps.getLeaderboard", accessToken, request);
        }

        public Task<ApiRequest<AppsGetLeaderboardExtendedResponse>> GetLeaderboardExtended(UserAccessToken accessToken, string type = null, bool? global = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["type"] = type,
                ["global"] = RequestHelpers.ParseBoolean(global),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<AppsGetLeaderboardExtendedResponse>("apps.getLeaderboard", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetScore(UserAccessToken accessToken, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("apps.getScore", accessToken, request);
        }

    }

    internal class UtilsApi : IUtilsApi
    {
        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(UserAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(GroupAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", null, request);
        }

        public Task<ApiRequest<UtilsLinkChecked>> CheckLink(ServiceAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<UtilsLinkChecked>("utils.checkLink", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(UserAccessToken accessToken, string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(GroupAccessToken accessToken, string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", null, request);
        }

        public Task<ApiRequest<bool?>> DeleteFromLastShortened(ServiceAccessToken accessToken, string key = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
            };

            return RequestManager.CreateRequestAsync<bool?>("utils.deleteFromLastShortened", accessToken, request);
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(UserAccessToken accessToken, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", accessToken, request);
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(GroupAccessToken accessToken, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", accessToken, request);
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", null, request);
        }

        public Task<ApiRequest<UtilsGetLastShortenedLinksResponse>> GetLastShortenedLinks(ServiceAccessToken accessToken, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(UserAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(GroupAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", null, request);
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", null, request);
        }

        public Task<ApiRequest<UtilsLinkStats>> GetLinkStats(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStats>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsLinkStatsExtended>> GetLinkStatsExtended(ServiceAccessToken accessToken, string key = null, string accessKey = null, string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["key"] = key,
                ["access_key"] = accessKey,
                ["interval"] = interval,
                ["intervals_count"] = intervalsCount?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<UtilsLinkStatsExtended>("utils.getLinkStats", accessToken, request);
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(UserAccessToken accessToken, string url = null, bool? @private = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
                ["@private"] = RequestHelpers.ParseBoolean(@private),
            };

            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(GroupAccessToken accessToken, string url = null, bool? @private = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
                ["@private"] = RequestHelpers.ParseBoolean(@private),
            };

            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(string url = null, bool? @private = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
                ["@private"] = RequestHelpers.ParseBoolean(@private),
            };

            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", null, request);
        }

        public Task<ApiRequest<UtilsShortLink>> GetShortLink(ServiceAccessToken accessToken, string url = null, bool? @private = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
                ["@private"] = RequestHelpers.ParseBoolean(@private),
            };

            return RequestManager.CreateRequestAsync<UtilsShortLink>("utils.getShortLink", accessToken, request);
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(UserAccessToken accessToken, string screenName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["screen_name"] = screenName,
            };

            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", accessToken, request);
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(GroupAccessToken accessToken, string screenName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["screen_name"] = screenName,
            };

            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", accessToken, request);
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(string screenName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["screen_name"] = screenName,
            };

            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", null, request);
        }

        public Task<ApiRequest<UtilsDomainResolved>> ResolveScreenName(ServiceAccessToken accessToken, string screenName = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["screen_name"] = screenName,
            };

            return RequestManager.CreateRequestAsync<UtilsDomainResolved>("utils.resolveScreenName", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetServerTime(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetServerTime(GroupAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetServerTime()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", null, request);
        }

        public Task<ApiRequest<int?>> GetServerTime(ServiceAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
            };

            return RequestManager.CreateRequestAsync<int?>("utils.getServerTime", accessToken, request);
        }

    }

    internal class DatabaseApi : IDatabaseApi
    {
        public Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(UserAccessToken accessToken, bool? needAll = null, string code = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["need_all"] = RequestHelpers.ParseBoolean(needAll),
                ["code"] = code,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetCountriesResponse>("database.getCountries", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(bool? needAll = null, string code = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["need_all"] = RequestHelpers.ParseBoolean(needAll),
                ["code"] = code,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetCountriesResponse>("database.getCountries", null, request);
        }

        public Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(ServiceAccessToken accessToken, bool? needAll = null, string code = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["need_all"] = RequestHelpers.ParseBoolean(needAll),
                ["code"] = code,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetCountriesResponse>("database.getCountries", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(UserAccessToken accessToken, int? countryId = null, string q = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["country_id"] = countryId?.ToString(),
                ["q"] = q,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetRegionsResponse>("database.getRegions", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(int? countryId = null, string q = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["country_id"] = countryId?.ToString(),
                ["q"] = q,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetRegionsResponse>("database.getRegions", null, request);
        }

        public Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(ServiceAccessToken accessToken, int? countryId = null, string q = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["country_id"] = countryId?.ToString(),
                ["q"] = q,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetRegionsResponse>("database.getRegions", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(UserAccessToken accessToken, IEnumerable<int?> streetIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["street_ids"] = RequestHelpers.ParseEnumerable(streetIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DatabaseStreet>>("database.getStreetsById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(IEnumerable<int?> streetIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["street_ids"] = RequestHelpers.ParseEnumerable(streetIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DatabaseStreet>>("database.getStreetsById", null, request);
        }

        public Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(ServiceAccessToken accessToken, IEnumerable<int?> streetIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["street_ids"] = RequestHelpers.ParseEnumerable(streetIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DatabaseStreet>>("database.getStreetsById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(UserAccessToken accessToken, IEnumerable<int?> countryIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["country_ids"] = RequestHelpers.ParseEnumerable(countryIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseCountry>>("database.getCountriesById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(IEnumerable<int?> countryIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["country_ids"] = RequestHelpers.ParseEnumerable(countryIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseCountry>>("database.getCountriesById", null, request);
        }

        public Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(ServiceAccessToken accessToken, IEnumerable<int?> countryIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["country_ids"] = RequestHelpers.ParseEnumerable(countryIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseCountry>>("database.getCountriesById", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(UserAccessToken accessToken, int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["country_id"] = countryId?.ToString(),
                ["region_id"] = regionId?.ToString(),
                ["q"] = q,
                ["need_all"] = RequestHelpers.ParseBoolean(needAll),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetCitiesResponse>("database.getCities", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["country_id"] = countryId?.ToString(),
                ["region_id"] = regionId?.ToString(),
                ["q"] = q,
                ["need_all"] = RequestHelpers.ParseBoolean(needAll),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetCitiesResponse>("database.getCities", null, request);
        }

        public Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(ServiceAccessToken accessToken, int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["country_id"] = countryId?.ToString(),
                ["region_id"] = regionId?.ToString(),
                ["q"] = q,
                ["need_all"] = RequestHelpers.ParseBoolean(needAll),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetCitiesResponse>("database.getCities", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(UserAccessToken accessToken, IEnumerable<int?> cityIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["city_ids"] = RequestHelpers.ParseEnumerable(cityIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseObject>>("database.getCitiesById", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(IEnumerable<int?> cityIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["city_ids"] = RequestHelpers.ParseEnumerable(cityIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseObject>>("database.getCitiesById", null, request);
        }

        public Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(ServiceAccessToken accessToken, IEnumerable<int?> cityIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["city_ids"] = RequestHelpers.ParseEnumerable(cityIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseObject>>("database.getCitiesById", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(UserAccessToken accessToken, string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["country_id"] = countryId?.ToString(),
                ["city_id"] = cityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetUniversitiesResponse>("database.getUniversities", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["country_id"] = countryId?.ToString(),
                ["city_id"] = cityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetUniversitiesResponse>("database.getUniversities", null, request);
        }

        public Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(ServiceAccessToken accessToken, string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["country_id"] = countryId?.ToString(),
                ["city_id"] = cityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetUniversitiesResponse>("database.getUniversities", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(UserAccessToken accessToken, string q = null, int? cityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["city_id"] = cityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetSchoolsResponse>("database.getSchools", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(string q = null, int? cityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["q"] = q,
                ["city_id"] = cityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetSchoolsResponse>("database.getSchools", null, request);
        }

        public Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(ServiceAccessToken accessToken, string q = null, int? cityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["q"] = q,
                ["city_id"] = cityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetSchoolsResponse>("database.getSchools", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(UserAccessToken accessToken, int? countryId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["country_id"] = countryId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(int? countryId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["country_id"] = countryId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", null, request);
        }

        public Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(ServiceAccessToken accessToken, int? countryId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["country_id"] = countryId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(UserAccessToken accessToken, int? universityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["university_id"] = universityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetFacultiesResponse>("database.getFaculties", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(int? universityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["university_id"] = universityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetFacultiesResponse>("database.getFaculties", null, request);
        }

        public Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(ServiceAccessToken accessToken, int? universityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["university_id"] = universityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetFacultiesResponse>("database.getFaculties", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(UserAccessToken accessToken, int? facultyId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["faculty_id"] = facultyId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetChairsResponse>("database.getChairs", accessToken, request);
        }

        public Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(int? facultyId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["faculty_id"] = facultyId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetChairsResponse>("database.getChairs", null, request);
        }

        public Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(ServiceAccessToken accessToken, int? facultyId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["faculty_id"] = facultyId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetChairsResponse>("database.getChairs", accessToken, request);
        }

    }

    internal class GiftsApi : IGiftsApi
    {
        public Task<ApiRequest<GiftsGetResponse>> Get(UserAccessToken accessToken, int? userId = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["user_id"] = userId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<GiftsGetResponse>("gifts.get", accessToken, request);
        }

    }

    internal class AdsApi : IAdsApi
    {
        public Task<ApiRequest<IEnumerable<AdsAccount>>> GetAccounts(UserAccessToken accessToken)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsAccount>>("ads.getAccounts", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsClient>>> GetClients(UserAccessToken accessToken, int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsClient>>("ads.getClients", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> CreateClients(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.createClients", accessToken, request);
        }

        public Task<ApiRequest<int?>> UpdateClients(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.updateClients", accessToken, request);
        }

        public Task<ApiRequest<int?>> DeleteClients(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.deleteClients", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsCampaign>>> GetCampaigns(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["campaign_ids"] = campaignIds,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsCampaign>>("ads.getCampaigns", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> CreateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.createCampaigns", accessToken, request);
        }

        public Task<ApiRequest<int?>> UpdateCampaigns(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.updateCampaigns", accessToken, request);
        }

        public Task<ApiRequest<int?>> DeleteCampaigns(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.deleteCampaigns", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsAd>>> GetAds(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["campaign_ids"] = campaignIds,
                ["ad_ids"] = adIds,
                ["limit"] = limit?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsAd>>("ads.getAds", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsAdLayout>>> GetAdsLayout(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["campaign_ids"] = campaignIds,
                ["ad_ids"] = adIds,
                ["limit"] = limit?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsAdLayout>>("ads.getAdsLayout", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSettings>>> GetAdsTargeting(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["include_deleted"] = RequestHelpers.ParseBoolean(includeDeleted),
                ["campaign_ids"] = campaignIds,
                ["ad_ids"] = adIds,
                ["limit"] = limit?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSettings>>("ads.getAdsTargeting", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> CreateAds(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.createAds", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> UpdateAds(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.updateAds", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<int?>>> DeleteAds(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<int?>>("ads.deleteAds", accessToken, request);
        }

        public Task<ApiRequest<AdsLinkStatus>> CheckLink(UserAccessToken accessToken, int? accountId = null, string linkType = null, string linkUrl = null, int? campaignId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["link_type"] = linkType,
                ["link_url"] = linkUrl,
                ["campaign_id"] = campaignId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsLinkStatus>("ads.checkLink", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsStats>>> GetStatistics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids_type"] = idsType,
                ["ids"] = ids,
                ["period"] = period,
                ["date_from"] = dateFrom,
                ["date_to"] = dateTo,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsStats>>("ads.getStatistics", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsDemoStats>>> GetDemographics(UserAccessToken accessToken, int? accountId = null, string idsType = null, string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids_type"] = idsType,
                ["ids"] = ids,
                ["period"] = period,
                ["date_from"] = dateFrom,
                ["date_to"] = dateTo,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsDemoStats>>("ads.getDemographics", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsPostStats>>> GetAdsPostsReach(UserAccessToken accessToken, int? accountId = null, string adsIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ads_ids"] = adsIds,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsPostStats>>("ads.getAdsPostsReach", accessToken, request);
        }

        public Task<ApiRequest<int?>> GetBudget(UserAccessToken accessToken, int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("ads.getBudget", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsUsers>>> GetOfficeUsers(UserAccessToken accessToken, int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsUsers>>("ads.getOfficeUsers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddOfficeUsers(UserAccessToken accessToken, int? accountId = null, string data = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["data"] = data,
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.addOfficeUsers", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveOfficeUsers(UserAccessToken accessToken, int? accountId = null, string ids = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ids"] = ids,
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.removeOfficeUsers", accessToken, request);
        }

        public Task<ApiRequest<AdsTargStats>> GetTargetingStats(UserAccessToken accessToken, int? accountId = null, string criteria = null, int? adId = null, int? adFormat = null, string adPlatform = null, string linkUrl = null, string linkDomain = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["criteria"] = criteria,
                ["ad_id"] = adId?.ToString(),
                ["ad_format"] = adFormat?.ToString(),
                ["ad_platform"] = adPlatform,
                ["link_url"] = linkUrl,
                ["link_domain"] = linkDomain,
            };

            return RequestManager.CreateRequestAsync<AdsTargStats>("ads.getTargetingStats", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestions>>> GetSuggestions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestions>>("ads.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsRegions>>> GetSuggestionsRegions(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsRegions>>("ads.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsCities>>> GetSuggestionsCities(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["cities"] = cities,
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsCities>>("ads.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargSuggestionsSchools>>> GetSuggestionsSchools(UserAccessToken accessToken, string section = null, string ids = null, string q = null, int? country = null, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["section"] = section,
                ["ids"] = ids,
                ["q"] = q,
                ["country"] = country?.ToString(),
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargSuggestionsSchools>>("ads.getSuggestions", accessToken, request);
        }

        public Task<ApiRequest<AdsGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, string lang = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["lang"] = lang,
            };

            return RequestManager.CreateRequestAsync<AdsGetCategoriesResponse>("ads.getCategories", accessToken, request);
        }

        public Task<ApiRequest<string>> GetUploadURL(UserAccessToken accessToken, int? adFormat = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["ad_format"] = adFormat?.ToString(),
            };

            return RequestManager.CreateRequestAsync<string>("ads.getUploadURL", accessToken, request);
        }

        public Task<ApiRequest<string>> GetVideoUploadURL()
        {
            var request = new Dictionary<string, string>
            {
            };

            return RequestManager.CreateRequestAsync<string>("ads.getVideoUploadURL", null, request);
        }

        public Task<ApiRequest<AdsFloodStats>> GetFloodStats(UserAccessToken accessToken, int? accountId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsFloodStats>("ads.getFloodStats", accessToken, request);
        }

        public Task<ApiRequest<AdsRejectReason>> GetRejectionReason(UserAccessToken accessToken, int? accountId = null, int? adId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["ad_id"] = adId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsRejectReason>("ads.getRejectionReason", accessToken, request);
        }

        public Task<ApiRequest<AdsCreateTargetGroupResponse>> CreateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, string name = null, string domain = null, int? lifetime = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["name"] = name,
                ["domain"] = domain,
                ["lifetime"] = lifetime?.ToString(),
            };

            return RequestManager.CreateRequestAsync<AdsCreateTargetGroupResponse>("ads.createTargetGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> UpdateTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string name = null, string domain = null, int? lifetime = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["target_group_id"] = targetGroupId?.ToString(),
                ["name"] = name,
                ["domain"] = domain,
                ["lifetime"] = lifetime?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.updateTargetGroup", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteTargetGroup(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["target_group_id"] = targetGroupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("ads.deleteTargetGroup", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<AdsTargetGroup>>> GetTargetGroups(UserAccessToken accessToken, int? accountId = null, int? clientId = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<AdsTargetGroup>>("ads.getTargetGroups", accessToken, request);
        }

        public Task<ApiRequest<int?>> ImportTargetContacts(UserAccessToken accessToken, int? accountId = null, int? clientId = null, int? targetGroupId = null, string contacts = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["account_id"] = accountId?.ToString(),
                ["client_id"] = clientId?.ToString(),
                ["target_group_id"] = targetGroupId?.ToString(),
                ["contacts"] = contacts,
            };

            return RequestManager.CreateRequestAsync<int?>("ads.importTargetContacts", accessToken, request);
        }

    }

    internal class MarketApi : IMarketApi
    {
        public Task<ApiRequest<MarketGetResponse>> Get(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketGetResponse>("market.get", accessToken, request);
        }

        public Task<ApiRequest<MarketGetExtendedResponse>> GetExtended(UserAccessToken accessToken, int? ownerId = null, int? count = null, int? offset = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketGetExtendedResponse>("market.get", accessToken, request);
        }

        public Task<ApiRequest<MarketGetByIdResponse>> GetById(UserAccessToken accessToken, IEnumerable<string> itemIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["item_ids"] = RequestHelpers.ParseEnumerable(itemIds),
            };

            return RequestManager.CreateRequestAsync<MarketGetByIdResponse>("market.getById", accessToken, request);
        }

        public Task<ApiRequest<MarketGetByIdExtendedResponse>> GetByIdExtended(UserAccessToken accessToken, IEnumerable<string> itemIds = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["item_ids"] = RequestHelpers.ParseEnumerable(itemIds),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketGetByIdExtendedResponse>("market.getById", accessToken, request);
        }

        public Task<ApiRequest<MarketSearchResponse>> Search(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["q"] = q,
                ["price_from"] = priceFrom?.ToString(),
                ["price_to"] = priceTo?.ToString(),
                ["tags"] = RequestHelpers.ParseEnumerable(tags),
                ["rev"] = rev?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketSearchResponse>("market.search", accessToken, request);
        }

        public Task<ApiRequest<MarketSearchExtendedResponse>> SearchExtended(UserAccessToken accessToken, int? ownerId = null, string q = null, int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["q"] = q,
                ["price_from"] = priceFrom?.ToString(),
                ["price_to"] = priceTo?.ToString(),
                ["tags"] = RequestHelpers.ParseEnumerable(tags),
                ["rev"] = rev?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<MarketSearchExtendedResponse>("market.search", accessToken, request);
        }

        public Task<ApiRequest<MarketGetAlbumsResponse>> GetAlbums(UserAccessToken accessToken, int? ownerId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketGetAlbumsResponse>("market.getAlbums", accessToken, request);
        }

        public Task<ApiRequest<MarketGetAlbumByIdResponse>> GetAlbumById(UserAccessToken accessToken, int? ownerId = null, IEnumerable<int?> albumIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
            };

            return RequestManager.CreateRequestAsync<MarketGetAlbumByIdResponse>("market.getAlbumById", accessToken, request);
        }

        public Task<ApiRequest<int?>> CreateComment(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string message = null, IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null, int? stickerId = null, string guid = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
                ["from_group"] = RequestHelpers.ParseBoolean(fromGroup),
                ["reply_to_comment"] = replyToComment?.ToString(),
                ["sticker_id"] = stickerId?.ToString(),
                ["guid"] = guid,
            };

            return RequestManager.CreateRequestAsync<int?>("market.createComment", accessToken, request);
        }

        public Task<ApiRequest<MarketGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, bool? needLikes = null, int? startCommentId = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["need_likes"] = RequestHelpers.ParseBoolean(needLikes),
                ["start_comment_id"] = startCommentId?.ToString(),
                ["count"] = count?.ToString(),
                ["sort"] = sort,
                ["extended"] = RequestHelpers.ParseBoolean(extended),
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
            };

            return RequestManager.CreateRequestAsync<MarketGetCommentsResponse>("market.getComments", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.deleteComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RestoreComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.restoreComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, string message = null, IEnumerable<string> attachments = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["message"] = message,
                ["attachments"] = RequestHelpers.ParseEnumerable(attachments),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.editComment", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReportComment(UserAccessToken accessToken, int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["comment_id"] = commentId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.reportComment", accessToken, request);
        }

        public Task<ApiRequest<MarketGetCategoriesResponse>> GetCategories(UserAccessToken accessToken, int? count = null, int? offset = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["offset"] = offset?.ToString(),
            };

            return RequestManager.CreateRequestAsync<MarketGetCategoriesResponse>("market.getCategories", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Report(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, int? reason = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["reason"] = reason?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.report", accessToken, request);
        }

        public Task<ApiRequest<MarketAddResponse>> Add(UserAccessToken accessToken, int? ownerId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["name"] = name,
                ["description"] = description,
                ["category_id"] = categoryId?.ToString(),
                ["price"] = price?.ToString(),
                ["deleted"] = RequestHelpers.ParseBoolean(deleted),
                ["main_photo_id"] = mainPhotoId?.ToString(),
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
            };

            return RequestManager.CreateRequestAsync<MarketAddResponse>("market.add", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Edit(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, string name = null, string description = null, int? categoryId = null, double? price = null, bool? deleted = null, int? mainPhotoId = null, IEnumerable<int?> photoIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["name"] = name,
                ["description"] = description,
                ["category_id"] = categoryId?.ToString(),
                ["price"] = price?.ToString(),
                ["deleted"] = RequestHelpers.ParseBoolean(deleted),
                ["main_photo_id"] = mainPhotoId?.ToString(),
                ["photo_ids"] = RequestHelpers.ParseEnumerable(photoIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.edit", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Delete(UserAccessToken accessToken, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.delete", accessToken, request);
        }

        public Task<ApiRequest<bool?>> Restore(UserAccessToken accessToken, int? ownerId = null, int? itemId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.restore", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderItems(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? itemId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.reorderItems", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ReorderAlbums(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["before"] = before?.ToString(),
                ["after"] = after?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.reorderAlbums", accessToken, request);
        }

        public Task<ApiRequest<MarketAddAlbumResponse>> AddAlbum(UserAccessToken accessToken, int? ownerId = null, string title = null, int? photoId = null, bool? mainAlbum = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["title"] = title,
                ["photo_id"] = photoId?.ToString(),
                ["main_album"] = RequestHelpers.ParseBoolean(mainAlbum),
            };

            return RequestManager.CreateRequestAsync<MarketAddAlbumResponse>("market.addAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> EditAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null, string title = null, int? photoId = null, bool? mainAlbum = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
                ["title"] = title,
                ["photo_id"] = photoId?.ToString(),
                ["main_album"] = RequestHelpers.ParseBoolean(mainAlbum),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.editAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> DeleteAlbum(UserAccessToken accessToken, int? ownerId = null, int? albumId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["album_id"] = albumId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.deleteAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> RemoveFromAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.removeFromAlbum", accessToken, request);
        }

        public Task<ApiRequest<bool?>> AddToAlbum(UserAccessToken accessToken, int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["item_id"] = itemId?.ToString(),
                ["album_ids"] = RequestHelpers.ParseEnumerable(albumIds),
            };

            return RequestManager.CreateRequestAsync<bool?>("market.addToAlbum", accessToken, request);
        }

    }

}