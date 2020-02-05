using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class VideoSaveResult
    {
        /// <summary>
        /// Video access key.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Video description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Video owner ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Video title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// URL for the video uploading.
        /// </summary>
        public string UploadUrl { get; set; } 

        /// <summary>
        /// Video ID.
        /// </summary>
        public int? VideoId { get; set; } 
    }
}
