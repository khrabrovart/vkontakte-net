﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IPagesApi
    {
        /// <summary>
        /// Returns information about a wiki page.
        /// </summary>
        Task<ApiRequest<PagesWikipageFull>> Get(UserAccessToken accessToken, int? ownerId = null, int? pageId = null, bool? global = null, bool? sitePreview = null, string title = null, bool? needSource = null, bool? needHtml = null);
        /// <summary>
        /// Saves the text of a wiki page.
        /// </summary>
        Task<ApiRequest<int?>> Save(UserAccessToken accessToken, string text = null, int? pageId = null, int? groupId = null, int? userId = null, string title = null);
        /// <summary>
        /// Saves modified read and edit access settings for a wiki page.
        /// </summary>
        Task<ApiRequest<int?>> SaveAccess(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null, int? view = null, int? edit = null);
        /// <summary>
        /// Returns a list of all previous versions of a wiki page.
        /// </summary>
        Task<ApiRequest<IEnumerable<PagesWikipageVersion>>> GetHistory(UserAccessToken accessToken, int? pageId = null, int? groupId = null, int? userId = null);
        /// <summary>
        /// Returns a list of wiki pages in a group.
        /// </summary>
        Task<ApiRequest<IEnumerable<PagesWikipage>>> GetTitles(UserAccessToken accessToken, int? groupId = null);
        /// <summary>
        /// Returns the text of one of the previous versions of a wiki page.
        /// </summary>
        Task<ApiRequest<PagesWikipageFull>> GetVersion(UserAccessToken accessToken, int? versionId = null, int? groupId = null, int? userId = null, bool? needHtml = null);
        /// <summary>
        /// Returns HTML representation of the wiki markup.
        /// </summary>
        Task<ApiRequest<string>> ParseWiki(UserAccessToken accessToken, string text = null, int? groupId = null);
        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// </summary>
        Task<ApiRequest<bool?>> ClearCache(UserAccessToken accessToken, string url = null);
        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// </summary>
        Task<ApiRequest<bool?>> ClearCache(string url = null);
        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// </summary>
        Task<ApiRequest<bool?>> ClearCache(ServiceAccessToken accessToken, string url = null);
    }
}
