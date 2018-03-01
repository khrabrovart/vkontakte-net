using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
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
}
