using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
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
}
