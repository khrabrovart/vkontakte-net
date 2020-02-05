using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsCampaign
    {
        /// <summary>
        /// Campaign's total limit, rubles.
        /// </summary>
        public string AllLimit { get; set; } 

        /// <summary>
        /// Campaign's day limit, rubles.
        /// </summary>
        public string DayLimit { get; set; } 

        /// <summary>
        /// Campaign ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Campaign title.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// Campaign start time, as Unixtime.
        /// </summary>
        public int? StartTime { get; set; } 

        public int? Status { get; set; } 

        /// <summary>
        /// Campaign stop time, as Unixtime.
        /// </summary>
        public int? StopTime { get; set; } 

        public string Type { get; set; } 
    }
}
