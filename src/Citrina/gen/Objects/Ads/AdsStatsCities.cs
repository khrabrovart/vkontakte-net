using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsStatsCities
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
        /// City name.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// City ID.
        /// </summary>
        public int? Value { get; set; } 
    }
}
