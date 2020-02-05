using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IDatabaseApi
    {
        /// <summary>
        /// Returns a list of countries.
        /// </summary>
        Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(UserAccessToken accessToken, bool? needAll = null, string code = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of countries.
        /// </summary>
        Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(bool? needAll = null, string code = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of countries.
        /// </summary>
        Task<ApiRequest<DatabaseGetCountriesResponse>> GetCountries(ServiceAccessToken accessToken, bool? needAll = null, string code = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of regions.
        /// </summary>
        Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(UserAccessToken accessToken, int? countryId = null, string q = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of regions.
        /// </summary>
        Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(int? countryId = null, string q = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of regions.
        /// </summary>
        Task<ApiRequest<DatabaseGetRegionsResponse>> GetRegions(ServiceAccessToken accessToken, int? countryId = null, string q = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns information about streets by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(UserAccessToken accessToken, IEnumerable<int?> streetIds = null);
        /// <summary>
        /// Returns information about streets by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(IEnumerable<int?> streetIds = null);
        /// <summary>
        /// Returns information about streets by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<DatabaseStreet>>> GetStreetsById(ServiceAccessToken accessToken, IEnumerable<int?> streetIds = null);
        /// <summary>
        /// Returns information about countries by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(UserAccessToken accessToken, IEnumerable<int?> countryIds = null);
        /// <summary>
        /// Returns information about countries by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(IEnumerable<int?> countryIds = null);
        /// <summary>
        /// Returns information about countries by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseCountry>>> GetCountriesById(ServiceAccessToken accessToken, IEnumerable<int?> countryIds = null);
        /// <summary>
        /// Returns a list of cities.
        /// </summary>
        Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(UserAccessToken accessToken, int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of cities.
        /// </summary>
        Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of cities.
        /// </summary>
        Task<ApiRequest<DatabaseGetCitiesResponse>> GetCities(ServiceAccessToken accessToken, int? countryId = null, int? regionId = null, string q = null, bool? needAll = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns information about cities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(UserAccessToken accessToken, IEnumerable<int?> cityIds = null);
        /// <summary>
        /// Returns information about cities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(IEnumerable<int?> cityIds = null);
        /// <summary>
        /// Returns information about cities by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<BaseObject>>> GetCitiesById(ServiceAccessToken accessToken, IEnumerable<int?> cityIds = null);
        /// <summary>
        /// Returns a list of higher education institutions.
        /// </summary>
        Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(UserAccessToken accessToken, string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of higher education institutions.
        /// </summary>
        Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of higher education institutions.
        /// </summary>
        Task<ApiRequest<DatabaseGetUniversitiesResponse>> GetUniversities(ServiceAccessToken accessToken, string q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of schools.
        /// </summary>
        Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(UserAccessToken accessToken, string q = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of schools.
        /// </summary>
        Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(string q = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of schools.
        /// </summary>
        Task<ApiRequest<DatabaseGetSchoolsResponse>> GetSchools(ServiceAccessToken accessToken, string q = null, int? cityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// </summary>
        Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(UserAccessToken accessToken, int? countryId = null);
        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// </summary>
        Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(int? countryId = null);
        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// </summary>
        Task<ApiRequest<IEnumerable<IEnumerable<string>>>> GetSchoolClasses(ServiceAccessToken accessToken, int? countryId = null);
        /// <summary>
        /// Returns a list of faculties (i.e., university departments).
        /// </summary>
        Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(UserAccessToken accessToken, int? universityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of faculties (i.e., university departments).
        /// </summary>
        Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(int? universityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns a list of faculties (i.e., university departments).
        /// </summary>
        Task<ApiRequest<DatabaseGetFacultiesResponse>> GetFaculties(ServiceAccessToken accessToken, int? universityId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// </summary>
        Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(UserAccessToken accessToken, int? facultyId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// </summary>
        Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(int? facultyId = null, int? offset = null, int? count = null);
        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// </summary>
        Task<ApiRequest<DatabaseGetChairsResponse>> GetChairs(ServiceAccessToken accessToken, int? facultyId = null, int? offset = null, int? count = null);
    }
}
