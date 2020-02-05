using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosImage
    {
        /// <summary>
        /// Height of the photo in px.
        /// </summary>
        public int? Height { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// Photo URL.
        /// </summary>
        public string Url { get; set; } 

        /// <summary>
        /// Width of the photo in px.
        /// </summary>
        public int? Width { get; set; } 
    }
}
