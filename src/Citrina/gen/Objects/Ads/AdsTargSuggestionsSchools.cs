using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsTargSuggestionsSchools
    {
        /// <summary>
        /// Full school title.
        /// </summary>
        public string Desc { get; set; } 

        /// <summary>
        /// School ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// School title.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// City name.
        /// </summary>
        public string Parent { get; set; } 

        public string Type { get; set; } 
    }
}
