using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PagesWikipageHistory
    {
        /// <summary>
        /// Version ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Page size in bytes.
        /// </summary>
        public int? Length { get; set; } 

        /// <summary>
        /// Date when the page has been edited in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Last editor ID.
        /// </summary>
        public int? EditorId { get; set; } 

        /// <summary>
        /// Last editor name.
        /// </summary>
        public string EditorName { get; set; } 
    }
}
