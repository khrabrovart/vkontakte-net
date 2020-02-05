using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosPhotoUploadResponse
    {
        /// <summary>
        /// Album ID.
        /// </summary>
        public int? Aid { get; set; } 

        /// <summary>
        /// Uploading hash.
        /// </summary>
        public string Hash { get; set; } 

        /// <summary>
        /// Uploaded photos data.
        /// </summary>
        public string PhotosList { get; set; } 

        /// <summary>
        /// Upload server number.
        /// </summary>
        public int? Server { get; set; } 
    }
}
