using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DatabaseCity
    {
        /// <summary>
        /// Object ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Object title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Area title.
        /// </summary>
        public string Area { get; set; } 

        /// <summary>
        /// Region title.
        /// </summary>
        public string Region { get; set; } 

        /// <summary>
        /// Information whether the city is included in important cities list.
        /// </summary>
        public bool? Important { get; set; } 
    }
}
