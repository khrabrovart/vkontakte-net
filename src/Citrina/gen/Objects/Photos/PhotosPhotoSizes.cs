using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosPhotoSizes
    {
        /// <summary>
        /// Height in px.
        /// </summary>
        public int? Height { get; set; } 

        /// <summary>
        /// URL of the image.
        /// </summary>
        public string Url { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Width in px.
        /// </summary>
        public int? Width { get; set; } 
    }
}
