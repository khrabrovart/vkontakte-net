using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IPlacesApi
    {
        /// <summary>
        /// Adds a new location to the location database.
        /// </summary>
        Task<ApiRequest<PlacesAddResponse>> Add(UserAccessToken accessToken, int? type = null, string title = null, double? latitude = null, double? longitude = null, int? country = null, int? city = null, string address = null);
        /// <summary>
        /// Returns information about locations by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<PlacesPlaceMin>>> GetById(UserAccessToken accessToken, IEnumerable<int?> places = null);
        /// <summary>
        /// Returns a list of locations that match the search criteria.
        /// </summary>
        Task<ApiRequest<PlacesSearchResponse>> Search(UserAccessToken accessToken, string q = null, int? city = null, double? latitude = null, double? longitude = null, int? radius = null, int? offset = null, int? count = null);
        /// <summary>
        /// Checks a user in at the specified location.
        /// </summary>
        Task<ApiRequest<PlacesCheckinResponse>> Checkin(UserAccessToken accessToken, int? placeId = null, string text = null, double? latitude = null, double? longitude = null, bool? friendsOnly = null, IEnumerable<string> services = null);
        /// <summary>
        /// Returns a list of user check-ins at locations according to the set parameters.
        /// </summary>
        Task<ApiRequest<PlacesGetCheckinsResponse>> GetCheckins(UserAccessToken accessToken, double? latitude = null, double? longitude = null, int? place = null, int? userId = null, DateTime? offset = null, DateTime? count = null, DateTime? timestamp = null, bool? friendsOnly = null, bool? needPlaces = null);
        /// <summary>
        /// Returns a list of all types of locations.
        /// </summary>
        Task<ApiRequest<IEnumerable<PlacesTypes>>> GetTypes(UserAccessToken accessToken);
    }
}
