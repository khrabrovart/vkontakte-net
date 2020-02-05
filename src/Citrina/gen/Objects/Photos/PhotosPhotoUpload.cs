using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosPhotoUpload
    {
        /// <summary>
        /// Album ID.
        /// </summary>
        public int? AlbumId { get; set; } 

        /// <summary>
        /// URL to upload photo.
        /// </summary>
        public string UploadUrl { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 
    }
}
