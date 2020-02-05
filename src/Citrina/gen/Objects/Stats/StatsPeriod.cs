using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StatsPeriod
    {
        public StatsActivity Activity { get; set; } 

        /// <summary>
        /// Unix timestamp.
        /// </summary>
        public int? PeriodFrom { get; set; } 

        /// <summary>
        /// Unix timestamp.
        /// </summary>
        public int? PeriodTo { get; set; } 

        public StatsReach Reach { get; set; } 

        public StatsViews Visitors { get; set; } 
    }
}
