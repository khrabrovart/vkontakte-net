using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MarketPrice
    {
        /// <summary>
        /// Amount.
        /// </summary>
        public string Amount { get; set; } 

        public MarketCurrency Currency { get; set; } 

        public int? DiscountRate { get; set; } 

        public string OldAmount { get; set; } 

        /// <summary>
        /// Text.
        /// </summary>
        public string Text { get; set; } 
    }
}
