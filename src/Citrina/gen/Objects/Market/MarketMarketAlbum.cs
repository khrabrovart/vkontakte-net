using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MarketMarketAlbum
    {
        /// <summary>
        /// Items number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Market album ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Market album owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        /// <summary>
        /// Market album title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Date when album has been updated last time in Unixtime.
        /// </summary>
        public int? UpdatedTime { get; set; } 
    }
}
