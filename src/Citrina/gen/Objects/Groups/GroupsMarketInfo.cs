using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsMarketInfo
    {
        /// <summary>
        /// Contact person ID.
        /// </summary>
        public int? ContactId { get; set; } 

        public MarketCurrency Currency { get; set; } 

        /// <summary>
        /// Currency name.
        /// </summary>
        public string CurrencyText { get; set; } 

        /// <summary>
        /// Information whether the market is enabled.
        /// </summary>
        public bool? Enabled { get; set; } 

        /// <summary>
        /// Main market album ID.
        /// </summary>
        public int? MainAlbumId { get; set; } 

        /// <summary>
        /// Maximum price.
        /// </summary>
        public int? PriceMax { get; set; } 

        /// <summary>
        /// Minimum price.
        /// </summary>
        public int? PriceMin { get; set; } 
    }
}
