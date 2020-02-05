using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DocsDocTypes
    {
        /// <summary>
        /// Number of docs.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Doc type ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Doc type title.
        /// </summary>
        public string Title { get; set; } 
    }
}
