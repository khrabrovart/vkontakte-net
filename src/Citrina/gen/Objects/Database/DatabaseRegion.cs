using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DatabaseRegion
    {
        /// <summary>
        /// Region ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Region title.
        /// </summary>
        public string Title { get; set; } 
    }
}
