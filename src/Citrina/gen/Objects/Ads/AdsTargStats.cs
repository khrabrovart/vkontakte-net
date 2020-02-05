using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsTargStats
    {
        /// <summary>
        /// Audience.
        /// </summary>
        public int? AudienceCount { get; set; } 

        /// <summary>
        /// Recommended CPC value.
        /// </summary>
        public double? RecommendedCpc { get; set; } 

        /// <summary>
        /// Recommended CPM value.
        /// </summary>
        public double? RecommendedCpm { get; set; } 
    }
}
