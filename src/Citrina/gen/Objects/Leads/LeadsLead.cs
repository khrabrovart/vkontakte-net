using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class LeadsLead
    {
        /// <summary>
        /// Completed offers number.
        /// </summary>
        public int? Completed { get; set; } 

        /// <summary>
        /// Offer cost.
        /// </summary>
        public int? Cost { get; set; } 

        public LeadsLeadDays Days { get; set; } 

        /// <summary>
        /// Impressions number.
        /// </summary>
        public int? Impressions { get; set; } 

        /// <summary>
        /// Lead limit.
        /// </summary>
        public int? Limit { get; set; } 

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
