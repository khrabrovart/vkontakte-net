using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UtilsStatsExtended
    {
        public IEnumerable<UtilsStatsCity> Cities { get; set; } 

        public IEnumerable<UtilsStatsCountry> Countries { get; set; } 

        public IEnumerable<UtilsStatsSexAge> SexAge { get; set; } 

        /// <summary>
        /// Start time.
        /// </summary>
        public int? Timestamp { get; set; } 

        /// <summary>
        /// Total views number.
        /// </summary>
        public int? Views { get; set; } 
    }
}
