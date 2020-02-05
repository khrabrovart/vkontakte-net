using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class VideoVideoAlbumFull
    {
        /// <summary>
        /// Total number of videos in album.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Album ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Album cover image in different sizes.
        /// </summary>
        public IEnumerable<VideoVideoImage> Image { get; set; } 

        /// <summary>
        /// Information whether album is system.
        /// </summary>
        public int? IsSystem { get; set; } 

        /// <summary>
        /// Album owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Album title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Date when the album has been updated last time in Unixtime.
        /// </summary>
        public int? UpdatedTime { get; set; } 
    }
}
