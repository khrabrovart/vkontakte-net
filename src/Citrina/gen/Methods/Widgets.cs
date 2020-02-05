using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Widgets : IWidgets
    {
        /// <summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        /// </summary>
        public Task<ApiRequest<WidgetsGetCommentsResponse>> GetCommentsApi(int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<UsersFields> fields = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["widget_api_id"] = widgetApiId?.ToString(),
                ["url"] = url,
                ["page_id"] = pageId,
                ["order"] = order,
                ["fields"] = RequestHelpers.ParseEnumerable(fields),
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WidgetsGetCommentsResponse>("widgets.getComments", null, request);
        }

        /// <summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        /// </summary>
        public Task<ApiRequest<WidgetsGetPagesResponse>> GetPagesApi(int? widgetApiId = null, string order = null, string period = null, int? offset = null, int? count = null)
        {
            var request = new Dictionary<string, string>
            {
                ["widget_api_id"] = widgetApiId?.ToString(),
                ["order"] = order,
                ["period"] = period,
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
            };

            return RequestManager.CreateRequestAsync<WidgetsGetPagesResponse>("widgets.getPages", null, request);
        }
    }
}
