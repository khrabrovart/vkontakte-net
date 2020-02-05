using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MarketMarketItemFull
    {
        /// <summary>
        /// Access key for the market item.
        /// </summary>
        public string AccessKey { get; set; } 

        public int? Availability { get; set; } 

        /// <summary>
        /// Title for button for url.
        /// </summary>
        public string ButtonTitle { get; set; } 

        public MarketMarketCategory Category { get; set; } 

        /// <summary>
        /// Date when the item has been created in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Item description.
        /// </summary>
        public string Description { get; set; } 

        public string ExternalId { get; set; } 

        /// <summary>
        /// Item ID.
        /// </summary>
        public int? Id { get; set; } 

        public bool? IsFavorite { get; set; } 

        /// <summary>
        /// Item owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        public MarketPrice Price { get; set; } 

        /// <summary>
        /// URL of the preview image.
        /// </summary>
        public string ThumbPhoto { get; set; } 

        /// <summary>
        /// Item title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// URL to item.
        /// </summary>
        public string Url { get; set; } 

        public IEnumerable<int> AlbumsIds { get; set; } 

        public IEnumerable<PhotosPhoto> Photos { get; set; } 

        /// <summary>
        /// Information whether current use can comment the item.
        /// </summary>
        public bool? CanComment { get; set; } 

        /// <summary>
        /// Information whether current use can repost the item.
        /// </summary>
        public bool? CanRepost { get; set; } 

        public BaseLikes Likes { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        /// <summary>
        /// Views number.
        /// </summary>
        public int? ViewsCount { get; set; } 
    }
}
