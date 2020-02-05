using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AppsAppMin
    {
        public string Type { get; set; } 

        /// <summary>
        /// Application ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Application title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Application author's ID.
        /// </summary>
        public int? AuthorId { get; set; } 

        /// <summary>
        /// URL of the app icon with 139 px in width.
        /// </summary>
        public string Icon139 { get; set; } 

        /// <summary>
        /// URL of the app icon with 150 px in width.
        /// </summary>
        public string Icon150 { get; set; } 

        /// <summary>
        /// URL of the app icon with 278 px in width.
        /// </summary>
        public string Icon278 { get; set; } 

        /// <summary>
        /// URL of the app icon with 75 px in width.
        /// </summary>
        public string Icon75 { get; set; } 
    }
}
