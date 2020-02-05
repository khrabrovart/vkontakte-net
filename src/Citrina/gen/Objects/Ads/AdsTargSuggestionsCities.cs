using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsTargSuggestionsCities
    {
        /// <summary>
        /// Object ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Object name.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// Parent object.
        /// </summary>
        public string Parent { get; set; } 
    }
}
