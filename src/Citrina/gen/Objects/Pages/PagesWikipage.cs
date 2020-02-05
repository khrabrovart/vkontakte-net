using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PagesWikipage
    {
        /// <summary>
        /// Page creator ID.
        /// </summary>
        public int? CreatorId { get; set; } 

        /// <summary>
        /// Page creator name.
        /// </summary>
        public int? CreatorName { get; set; } 

        /// <summary>
        /// Last editor ID.
        /// </summary>
        public int? EditorId { get; set; } 

        /// <summary>
        /// Last editor name.
        /// </summary>
        public string EditorName { get; set; } 

        /// <summary>
        /// Community ID.
        /// </summary>
        public int? GroupId { get; set; } 

        /// <summary>
        /// Page ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Page title.
        /// </summary>
        public string Title { get; set; } 

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
