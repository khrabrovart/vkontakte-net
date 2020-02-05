using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsFloodStats
    {
        /// <summary>
        /// Requests left.
        /// </summary>
        public int? Left { get; set; } 

        /// <summary>
        /// Time to refresh in seconds.
        /// </summary>
        public int? Refresh { get; set; } 
    }
}
