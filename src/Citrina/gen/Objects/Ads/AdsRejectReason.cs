using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsRejectReason
    {
        /// <summary>
        /// Comment text.
        /// </summary>
        public string Comment { get; set; } 

        public IEnumerable<AdsRules> Rules { get; set; } 
    }
}
