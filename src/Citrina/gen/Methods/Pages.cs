using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Pages : IPages
    {
        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// </summary>
        public Task<ApiRequest<bool?>> ClearCacheApi(string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", null, request);
        }

        /// <summary>
        /// Returns information about a wiki page.
        /// </summary>
        public Task<ApiRequest<PagesWikipageFull>> GetApi(int? ownerId = null, int? pageId = null, bool? global = null, bool? sitePreview = null, string title = null, bool? needSource = null, bool? needHtml = null)
        {
            var request = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId?.ToString(),
                ["page_id"] = pageId?.ToString(),
                ["global"] = RequestHelpers.ParseBoolean(global),
                ["site_preview"] = RequestHelpers.ParseBoolean(sitePreview),
                ["title"] = title,
                ["need_source"] = RequestHelpers.ParseBoolean(needSource),
                ["need_html"] = RequestHelpers.ParseBoolean(needHtml),
            };

            return RequestManager.CreateRequestAsync<PagesWikipageFull>("pages.get", null, request);
        }

        /// <summary>
        /// Returns a list of all previous versions of a wiki page.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PagesWikipageHistory>>> GetHistoryApi(int? pageId = null, int? groupId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["page_id"] = pageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PagesWikipageHistory>>("pages.getHistory", null, request);
        }

        /// <summary>
        /// Returns a list of wiki pages in a group.
        /// </summary>
        public Task<ApiRequest<IEnumerable<PagesWikipage>>> GetTitlesApi(int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PagesWikipage>>("pages.getTitles", null, request);
        }

        /// <summary>
        /// Returns the text of one of the previous versions of a wiki page.
        /// </summary>
        public Task<ApiRequest<PagesWikipageFull>> GetVersionApi(int? versionId = null, int? groupId = null, int? userId = null, bool? needHtml = null)
        {
            var request = new Dictionary<string, string>
            {
                ["version_id"] = versionId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["need_html"] = RequestHelpers.ParseBoolean(needHtml),
            };

            return RequestManager.CreateRequestAsync<PagesWikipageFull>("pages.getVersion", null, request);
        }

        /// <summary>
        /// Returns HTML representation of the wiki markup.
        /// </summary>
        public Task<ApiRequest<string>> ParseWikiApi(string text = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["text"] = text,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<string>("pages.parseWiki", null, request);
        }

        /// <summary>
        /// Saves the text of a wiki page.
        /// </summary>
        public Task<ApiRequest<int?>> SaveApi(string text = null, int? pageId = null, int? groupId = null, int? userId = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["text"] = text,
                ["page_id"] = pageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<int?>("pages.save", null, request);
        }

        /// <summary>
        /// Saves modified read and edit access settings for a wiki page.
        /// </summary>
        public Task<ApiRequest<int?>> SaveAccessApi(int? pageId = null, int? groupId = null, int? userId = null, int? view = null, int? edit = null)
        {
            var request = new Dictionary<string, string>
            {
                ["page_id"] = pageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["view"] = view?.ToString(),
                ["edit"] = edit?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("pages.saveAccess", null, request);
        }
    }
}
