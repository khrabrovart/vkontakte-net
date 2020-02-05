using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsStatsSexAge
    {
        /// <summary>
        /// Clicks rate.
        /// </summary>
        public double? ClicksRate { get; set; } 

        /// <summary>
        /// Impressions rate.
        /// </summary>
        public double? ImpressionsRate { get; set; } 

        /// <summary>
        /// Sex and age interval.
        /// </summary>
        public string Value { get; set; } 
    }
}
