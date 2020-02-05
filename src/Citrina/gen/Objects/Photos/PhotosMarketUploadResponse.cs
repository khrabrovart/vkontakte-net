using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosMarketUploadResponse
    {
        /// <summary>
        /// Crop data.
        /// </summary>
        public string CropData { get; set; } 

        /// <summary>
        /// Crop hash.
        /// </summary>
        public string CropHash { get; set; } 

        /// <summary>
        /// Community ID.
        /// </summary>
        public int? GroupId { get; set; } 

        /// <summary>
        /// Uploading hash.
        /// </summary>
        public string Hash { get; set; } 

        /// <summary>
        /// Uploaded photo data.
        /// </summary>
        public string Photo { get; set; } 

        /// <summary>
        /// Upload server number.
        /// </summary>
        public int? Server { get; set; } 
    }
}
