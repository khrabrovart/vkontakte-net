using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WidgetsWidgetPage
    {
        public BaseObjectCount Comments { get; set; } 

        /// <summary>
        /// Date when widgets on the page has been initialized firstly in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Page description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Page ID.
        /// </summary>
        public int? Id { get; set; } 

        public BaseObjectCount Likes { get; set; } 

        /// <summary>
        /// page_id parameter value.
        /// </summary>
        public string PageId { get; set; } 

        /// <summary>
        /// URL of the preview image.
        /// </summary>
        public string Photo { get; set; } 

        /// <summary>
        /// Page title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Page absolute URL.
        /// </summary>
        public string Url { get; set; } 
    }
}
