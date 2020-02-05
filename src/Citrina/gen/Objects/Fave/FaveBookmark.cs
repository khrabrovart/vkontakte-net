using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FaveBookmark
    {
        /// <summary>
        /// Timestamp, when this item was bookmarked.
        /// </summary>
        public int? AddedDate { get; set; } 

        public BaseLink Link { get; set; } 

        public WallWallpostFull Post { get; set; } 

        public MarketMarketItem Product { get; set; } 

        /// <summary>
        /// Has user seen this item.
        /// </summary>
        public bool? Seen { get; set; } 

        public IEnumerable<FaveTag> Tags { get; set; } 

        /// <summary>
        /// Item type.
        /// </summary>
        public string Type { get; set; } 

        public VideoVideo Video { get; set; } 
    }
}
