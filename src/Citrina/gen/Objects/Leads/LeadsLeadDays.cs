using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class LeadsLeadDays
    {
        /// <summary>
        /// Completed offers number.
        /// </summary>
        public int? Completed { get; set; } 

        /// <summary>
        /// Impressions number.
        /// </summary>
        public int? Impressions { get; set; } 

        /// <summary>
        /// Amount of spent votes.
        /// </summary>
        public int? Spent { get; set; } 

        /// <summary>
        /// Started offers number.
        /// </summary>
        public int? Started { get; set; } 
    }
}
