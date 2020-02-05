using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IDatabaseApi
    {
        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// </summary>
        Task<ApiRequest<DatabaseGetChairsResponse>> GetChairsApi(int? facultyId = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns a list of cities.
        /// </summary>
        Task<ApiRequest<DatabaseGetCitiesResponse>> GetCitiesApi(int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns information about cities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesByIdApi(IEnumerable<int> cityIds = null);

        /// <summary>
        /// Returns a list of countries.
        /// </summary>
        Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountriesApi(bool? needAll = null, string code = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns information about countries by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesByIdApi(IEnumerable<int> countryIds = null);

        /// <summary>
        /// Returns a list of faculties (i.e., university departments).
        /// </summary>
        Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFacultiesApi(int? universityId = null, int? offset = null, int? count = null);

        /// <summary>
        /// Get metro stations by city.
        /// </summary>
        Task<ApiRequest<DatabaseGetMetroStationsResponse>> GetMetroStationsApi(int? cityId = null, int? offset = null, int? count = null, bool? extended = null);

        /// <summary>
        /// Get metro station by his id.
        /// </summary>
        Task<ApiRequest<IEnumerable<DatabaseStation>>> GetMetroStationsByIdApi(IEnumerable<int> stationIds = null);

        /// <summary>
        /// Returns a list of regions.
        /// </summary>
        Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegionsApi(int? countryId = null, string q = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// </summary>
        Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClassesApi(int? countryId = null);

        /// <summary>
        /// Returns a list of schools.
        /// </summary>
        Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchoolsApi(string q = null, int? cityId = null, int? offset = null, int? count = null);

        /// <summary>
        /// Returns a list of higher education institutions.
        /// </summary>
        Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversitiesApi(string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null);
    }
}
