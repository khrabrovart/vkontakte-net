using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PagesWikipageFull
    {
        /// <summary>
        /// Date when the page has been created in Unixtime.
        /// </summary>
        public int? Created { get; set; } 

        /// <summary>
        /// Page creator ID.
        /// </summary>
        public int? CreatorId { get; set; } 

        /// <summary>
        /// Information whether current user can edit the page.
        /// </summary>
        public bool? CurrentUserCanEdit { get; set; } 

        /// <summary>
        /// Information whether current user can edit the page access settings.
        /// </summary>
        public bool? CurrentUserCanEditAccess { get; set; } 

        /// <summary>
        /// Date when the page has been edited in Unixtime.
        /// </summary>
        public int? Edited { get; set; } 

        /// <summary>
        /// Last editor ID.
        /// </summary>
        public int? EditorId { get; set; } 

        /// <summary>
        /// Community ID.
        /// </summary>
        public int? GroupId { get; set; } 

        /// <summary>
        /// Page content, HTML.
        /// </summary>
        public string Html { get; set; } 

        /// <summary>
        /// Page ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Page content, wiki.
        /// </summary>
        public string Source { get; set; } 

        /// <summary>
        /// Page title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// URL of the page preview.
        /// </summary>
        public string ViewUrl { get; set; } 

        /// <summary>
        /// Views number.
        /// </summary>
        public int? Views { get; set; } 

        /// <summary>
        /// Edit settings of the page.
        /// </summary>
        public int? WhoCanEdit { get; set; } 

        /// <summary>
        /// View settings of the page.
        /// </summary>
        public int? WhoCanView { get; set; } 
    }
}
