using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
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
}
