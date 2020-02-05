using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosPhotoAlbumFull
    {
        /// <summary>
        /// Information whether current user can upload photo to the album.
        /// </summary>
        public bool? CanUpload { get; set; } 

        /// <summary>
        /// Information whether album comments are disabled.
        /// </summary>
        public bool? CommentsDisabled { get; set; } 

        /// <summary>
        /// Date when the album has been created in Unixtime.
        /// </summary>
        public int? Created { get; set; } 

        /// <summary>
        /// Photo album description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Photo album ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Album owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Photos number.
        /// </summary>
        public int? Size { get; set; } 

        public IEnumerable<PhotosPhotoSizes> Sizes { get; set; } 

        /// <summary>
        /// Thumb photo ID.
        /// </summary>
        public int? ThumbId { get; set; } 

        /// <summary>
        /// Information whether the album thumb is last photo.
        /// </summary>
        public bool? ThumbIsLast { get; set; } 

        /// <summary>
        /// URL of the thumb image.
        /// </summary>
        public string ThumbSrc { get; set; } 

        /// <summary>
        /// Photo album title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Date when the album has been updated last time in Unixtime.
        /// </summary>
        public int? Updated { get; set; } 

        /// <summary>
        /// Information whether only community administrators can upload photos.
        /// </summary>
        public bool? UploadByAdminsOnly { get; set; } 
    }
}
