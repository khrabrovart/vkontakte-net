using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IPagesApi
    {
        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// </summary>
        Task<ApiRequest<bool?>> ClearCacheApi(string url = null);

        /// <summary>
        /// Returns information about a wiki page.
        /// </summary>
        Task<ApiRequest<PagesWikipageFull>> GetApi(int? ownerId = null, int? pageId = null, bool? global = null, bool? sitePreview = null, string title = null, bool? needSource = null, bool? needHtml = null);

        /// <summary>
        /// Returns a list of all previous versions of a wiki page.
        /// </summary>
        Task<ApiRequest<IEnumerable<PagesWikipageHistory>>> GetHistoryApi(int? pageId = null, int? groupId = null, int? userId = null);

        /// <summary>
        /// Returns a list of wiki pages in a group.
        /// </summary>
        Task<ApiRequest<IEnumerable<PagesWikipage>>> GetTitlesApi(int? groupId = null);

        /// <summary>
        /// Returns the text of one of the previous versions of a wiki page.
        /// </summary>
        Task<ApiRequest<PagesWikipageFull>> GetVersionApi(int? versionId = null, int? groupId = null, int? userId = null, bool? needHtml = null);

        /// <summary>
        /// Returns HTML representation of the wiki markup.
        /// </summary>
        Task<ApiRequest<string>> ParseWikiApi(string text = null, int? groupId = null);

        /// <summary>
        /// Saves the text of a wiki page.
        /// </summary>
        Task<ApiRequest<int?>> SaveApi(string text = null, int? pageId = null, int? groupId = null, int? userId = null, string title = null);

        /// <summary>
        /// Saves modified read and edit access settings for a wiki page.
        /// </summary>
        Task<ApiRequest<int?>> SaveAccessApi(int? pageId = null, int? groupId = null, int? userId = null, int? view = null, int? edit = null);
    }
}
