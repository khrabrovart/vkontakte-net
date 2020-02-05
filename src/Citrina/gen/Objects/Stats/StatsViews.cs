using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Views stats.
    /// </summary>
    public class StatsViews
    {
        public IEnumerable<StatsSexAge> Age { get; set; } 

        public IEnumerable<StatsCity> Cities { get; set; } 

        public IEnumerable<StatsCountry> Countries { get; set; } 

        /// <summary>
        /// Number of views from mobile devices.
        /// </summary>
        public int? MobileViews { get; set; } 

        public IEnumerable<StatsSexAge> Sex { get; set; } 

        public IEnumerable<StatsSexAge> SexAge { get; set; } 

        /// <summary>
        /// Views number.
        /// </summary>
        public int? Views { get; set; } 

        /// <summary>
        /// Visitors number.
        /// </summary>
        public int? Visitors { get; set; } 
    }
}
