using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Reach stats.
    /// </summary>
    public class StatsReach
    {
        public IEnumerable<StatsSexAge> Age { get; set; } 

        public IEnumerable<StatsCity> Cities { get; set; } 

        public IEnumerable<StatsCountry> Countries { get; set; } 

        /// <summary>
        /// Reach count from mobile devices.
        /// </summary>
        public int? MobileReach { get; set; } 

        /// <summary>
        /// Reach count.
        /// </summary>
        public int? Reach { get; set; } 

        /// <summary>
        /// Subscribers reach count.
        /// </summary>
        public int? ReachSubscribers { get; set; } 

        public IEnumerable<StatsSexAge> Sex { get; set; } 

        public IEnumerable<StatsSexAge> SexAge { get; set; } 
    }
}
