using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IWidgetsApi
    {
        /// <summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        /// </summary>
        Task<ApiRequest<WidgetsGetCommentsResponse>> GetCommentsApi(int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<UsersFields> fields = null, int? offset = null, int? count = null);

        /// <summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        /// </summary>
        Task<ApiRequest<WidgetsGetPagesResponse>> GetPagesApi(int? widgetApiId = null, string order = null, string period = null, int? offset = null, int? count = null);
    }
}
