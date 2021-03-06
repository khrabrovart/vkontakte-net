using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosPhoto
    {
        /// <summary>
        /// Access key for the photo.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Album ID.
        /// </summary>
        public int? AlbumId { get; set; } 

        /// <summary>
        /// Date when uploaded.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Original photo height.
        /// </summary>
        public int? Height { get; set; } 

        /// <summary>
        /// Photo ID.
        /// </summary>
        public int? Id { get; set; } 

        public IEnumerable<PhotosImage> Images { get; set; } 

        /// <summary>
        /// Latitude.
        /// </summary>
        public double? Lat { get; set; } 

        /// <summary>
        /// Longitude.
        /// </summary>
        public double? @Long { get; set; } 

        /// <summary>
        /// Photo owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 

        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; } 

        /// <summary>
        /// Photo caption.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// ID of the user who have uploaded the photo.
        /// </summary>
        public int? UserId { get; set; } 

        /// <summary>
        /// Original photo width.
        /// </summary>
        public int? Width { get; set; } 
    }
}
