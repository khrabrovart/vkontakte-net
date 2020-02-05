using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsStatsSex
    {
        /// <summary>
        /// Clicks rate.
        /// </summary>
        public double? ClicksRate { get; set; } 

        /// <summary>
        /// Impressions rate.
        /// </summary>
        public double? ImpressionsRate { get; set; } 

        public string Value { get; set; } 
    }
}
