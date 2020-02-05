using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsGetCategoriesResponse
    {
        /// <summary>
        /// Old categories.
        /// </summary>
        public IEnumerable<AdsCategory> V1 { get; set; } 

        /// <summary>
        /// Actual categories.
        /// </summary>
        public IEnumerable<AdsCategory> V2 { get; set; } 
    }
}
