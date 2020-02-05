using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsDemostatsFormat
    {
        public IEnumerable<AdsStatsAge> Age { get; set; } 

        public IEnumerable<AdsStatsCities> Cities { get; set; } 

        /// <summary>
        /// Day as YYYY-MM-DD.
        /// </summary>
        public string Day { get; set; } 

        /// <summary>
        /// Month as YYYY-MM.
        /// </summary>
        public string Month { get; set; } 

        /// <summary>
        /// 1 if period=overall.
        /// </summary>
        public int? Overall { get; set; } 

        public IEnumerable<AdsStatsSex> Sex { get; set; } 

        public IEnumerable<AdsStatsSexAge> SexAge { get; set; } 
    }
}
