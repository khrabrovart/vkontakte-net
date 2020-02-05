using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Database : IDatabase
    {
        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// </summary>
        public Task<ApiRequest<DatabaseGetChairsResponse>> GetChairsApi(int? facultyId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["faculty_id"] = facultyId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetChairsResponse>("database.getChairs", null, request);
        }

        /// <summary>
        /// Returns a list of cities.
        /// </summary>
        public Task<ApiRequest<DatabaseGetCitiesResponse>> GetCitiesApi(int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null)
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

        /// <summary>
        /// Returns information about cities by their IDs.
        /// </summary>
        public Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesByIdApi(IEnumerable<int> cityIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["city_ids"] = RequestHelpers.ParseEnumerable(cityIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseObject>>("database.getCitiesById", null, request);
        }

        /// <summary>
        /// Returns a list of countries.
        /// </summary>
        public Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountriesApi(bool? needAll = null, string code = null, int? offset = null, int? count = null)
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

        /// <summary>
        /// Returns information about countries by their IDs.
        /// </summary>
        public Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesByIdApi(IEnumerable<int> countryIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["country_ids"] = RequestHelpers.ParseEnumerable(countryIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<BaseCountry>>("database.getCountriesById", null, request);
        }

        /// <summary>
        /// Returns a list of faculties (i.e., university departments).
        /// </summary>
        public Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFacultiesApi(int? universityId = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["university_id"] = universityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetFacultiesResponse>("database.getFaculties", null, request);
        }

        /// <summary>
        /// Get metro stations by city.
        /// </summary>
        public Task<ApiRequest<DatabaseGetMetroStationsResponse>> GetMetroStationsApi(int? cityId = null, int? offset = null, int? count = null, bool? extended = null)
        {
            var request = new Dictionary<string, string>
            {
                ["city_id"] = cityId?.ToString(),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["extended"] = RequestHelpers.ParseBoolean(extended),
            };

            return RequestManager.CreateRequestAsync<DatabaseGetMetroStationsResponse>("database.getMetroStations", null, request);
        }

        /// <summary>
        /// Get metro station by his id.
        /// </summary>
        public Task<ApiRequest<IEnumerable<DatabaseStation>>> GetMetroStationsByIdApi(IEnumerable<int> stationIds = null)
        {
            var request = new Dictionary<string, string>
            {
                ["station_ids"] = RequestHelpers.ParseEnumerable(stationIds),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<DatabaseStation>>("database.getMetroStationsById", null, request);
        }

        /// <summary>
        /// Returns a list of regions.
        /// </summary>
        public Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegionsApi(int? countryId = null, string q = null, int? offset = null, int? count = null)
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

        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// </summary>
        public Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClassesApi(int? countryId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["country_id"] = countryId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", null, request);
        }

        /// <summary>
        /// Returns a list of schools.
        /// </summary>
        public Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchoolsApi(string q = null, int? cityId = null, int? offset = null, int? count = null)
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

        /// <summary>
        /// Returns a list of higher education institutions.
        /// </summary>
        public Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversitiesApi(string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null)
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
    }
}
