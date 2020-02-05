using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsStats
    {
        /// <summary>
        /// Object ID.
        /// </summary>
        public int? Id { get; set; } 

        public AdsStatsFormat Stats { get; set; } 

        public string Type { get; set; } 
    }
}
