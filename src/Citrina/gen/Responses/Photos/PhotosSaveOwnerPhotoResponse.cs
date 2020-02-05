using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosSaveOwnerPhotoResponse
    {
        /// <summary>
        /// Photo hash.
        /// </summary>
        public string PhotoHash { get; set; } 

        /// <summary>
        /// Uploaded image url.
        /// </summary>
        public string PhotoSrc { get; set; } 

        /// <summary>
        /// Uploaded image url.
        /// </summary>
        public string PhotoSrcBig { get; set; } 

        /// <summary>
        /// Uploaded image url.
        /// </summary>
        public string PhotoSrcSmall { get; set; } 

        /// <summary>
        /// Returns 1 if profile photo is saved.
        /// </summary>
        public int? Saved { get; set; } 

        /// <summary>
        /// Created post ID.
        /// </summary>
        public int? PostId { get; set; } 
    }
}
