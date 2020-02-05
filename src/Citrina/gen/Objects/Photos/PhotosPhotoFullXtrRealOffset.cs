using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosPhotoFullXtrRealOffset
    {
        /// <summary>
        /// Access key for the photo.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Album ID.
        /// </summary>
        public int? AlbumId { get; set; } 

        public bool? CanComment { get; set; } 

        public BaseObjectCount Comments { get; set; } 

        /// <summary>
        /// Date when uploaded.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Original photo height.
        /// </summary>
        public int? Height { get; set; } 

        /// <summary>
        /// Returns if the photo is hidden above the wall.
        /// </summary>
        public int? Hidden { get; set; } 

        /// <summary>
        /// Photo ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Latitude.
        /// </summary>
        public double? Lat { get; set; } 

        public BaseLikes Likes { get; set; } 

        /// <summary>
        /// Longitude.
        /// </summary>
        public double? @Long { get; set; } 

        /// <summary>
        /// Photo owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// URL of image with 1280 px width.
        /// </summary>
        public string Photo1280 { get; set; } 

        /// <summary>
        /// URL of image with 130 px width.
        /// </summary>
        public string Photo130 { get; set; } 

        /// <summary>
        /// URL of image with 2560 px width.
        /// </summary>
        public string Photo2560 { get; set; } 

        /// <summary>
        /// URL of image with 604 px width.
        /// </summary>
        public string Photo604 { get; set; } 

        /// <summary>
        /// URL of image with 75 px width.
        /// </summary>
        public string Photo75 { get; set; } 

        /// <summary>
        /// URL of image with 807 px width.
        /// </summary>
        public string Photo807 { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 

        /// <summary>
        /// Real position of the photo.
        /// </summary>
        public int? RealOffset { get; set; } 

        public BaseObjectCount Reposts { get; set; } 

        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; } 

        public BaseObjectCount Tags { get; set; } 

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
