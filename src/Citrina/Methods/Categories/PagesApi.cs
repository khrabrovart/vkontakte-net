using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
    internal class PagesApi : IPagesApi
    {
        public Task<ApiRequest<PagesWikipageFull>> Get(UserAccessToken accessToken, int? ownerId = null, int? pageId = null, bool? global = null, bool? sitePreview = null, string title = null, bool? needSource = null, bool? needHtml = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["owner_id"] = ownerId?.ToString(),
                ["page_id"] = pageId?.ToString(),
                ["global"] = RequestHelpers.ParseBoolean(global),
                ["site_preview"] = RequestHelpers.ParseBoolean(sitePreview),
                ["title"] = title,
                ["need_source"] = RequestHelpers.ParseBoolean(needSource),
                ["need_html"] = RequestHelpers.ParseBoolean(needHtml),
            };

            return RequestManager.CreateRequestAsync<PagesWikipageFull>("pages.get", accessToken, request);
        }

        public Task<ApiRequest<int?>> Save(UserAccessToken accessToken, string text = null, int? pageId = null, int? groupId = null, int? userId = null, string title = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["text"] = text,
                ["page_id"] = pageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["title"] = title,
            };

            return RequestManager.CreateRequestAsync<int?>("pages.save", accessToken, request);
        }

        public Task<ApiRequest<int?>> SaveAccess(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null, int? view = null, int? edit = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["page_id"] = pageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["view"] = view?.ToString(),
                ["edit"] = edit?.ToString(),
            };

            return RequestManager.CreateRequestAsync<int?>("pages.saveAccess", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PagesWikipageVersion>>> GetHistory(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["page_id"] = pageId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PagesWikipageVersion>>("pages.getHistory", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<PagesWikipage>>> GetTitles(UserAccessToken accessToken, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<PagesWikipage>>("pages.getTitles", accessToken, request);
        }

        public Task<ApiRequest<PagesWikipageFull>> GetVersion(UserAccessToken accessToken, int? versionId = null, int? groupId = null, int? userId = null, bool? needHtml = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["version_id"] = versionId?.ToString(),
                ["group_id"] = groupId?.ToString(),
                ["user_id"] = userId?.ToString(),
                ["need_html"] = RequestHelpers.ParseBoolean(needHtml),
            };

            return RequestManager.CreateRequestAsync<PagesWikipageFull>("pages.getVersion", accessToken, request);
        }

        public Task<ApiRequest<string>> ParseWiki(UserAccessToken accessToken, string text = null, int? groupId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["text"] = text,
                ["group_id"] = groupId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<string>("pages.parseWiki", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ClearCache(UserAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", accessToken, request);
        }

        public Task<ApiRequest<bool?>> ClearCache(string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", null, request);
        }

        public Task<ApiRequest<bool?>> ClearCache(ServiceAccessToken accessToken, string url = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["url"] = url,
            };

            return RequestManager.CreateRequestAsync<bool?>("pages.clearCache", accessToken, request);
        }
    }

}
