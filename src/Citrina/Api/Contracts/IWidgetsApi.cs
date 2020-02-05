using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IWidgetsApi
    {
        /// <summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        /// </summary>
        Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(UserAccessToken accessToken, int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null);
        /// <summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        /// </summary>
        Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null);
        /// <summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        /// </summary>
        Task<ApiRequest<WidgetsGetCommentsResponse>> GetComments(ServiceAccessToken accessToken, int? widgetApiId = null, string url = null, string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null);
        /// <summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        /// </summary>
        Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(UserAccessToken accessToken, int? widgetApiId = null, string order = null, string period = null, int? count = null);
        /// <summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        /// </summary>
        Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(int? widgetApiId = null, string order = null, string period = null, int? count = null);
        /// <summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        /// </summary>
        Task<ApiRequest<WidgetsGetPagesResponse>> GetPages(ServiceAccessToken accessToken, int? widgetApiId = null, string order = null, string period = null, int? count = null);
    }
}
