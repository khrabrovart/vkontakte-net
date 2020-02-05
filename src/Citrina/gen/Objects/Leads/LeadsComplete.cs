using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class LeadsComplete
    {
        /// <summary>
        /// Offer cost.
        /// </summary>
        public int? Cost { get; set; } 

        /// <summary>
        /// Offer limit.
        /// </summary>
        public int? Limit { get; set; } 

        /// <summary>
        /// Amount of spent votes.
        /// </summary>
        public int? Spent { get; set; } 

        public bool? Success { get; set; } 

        /// <summary>
        /// Information whether test mode is enabled.
        /// </summary>
        public bool? TestMode { get; set; } 
    }
}
