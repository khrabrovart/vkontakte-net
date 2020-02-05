using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DocsDocPreviewVideo
    {
        /// <summary>
        /// Video file size in bites.
        /// </summary>
        public int? Filesize { get; set; } 

        /// <summary>
        /// Video's height in pixels.
        /// </summary>
        public int? Height { get; set; } 

        /// <summary>
        /// Video URL.
        /// </summary>
        public string Src { get; set; } 

        /// <summary>
        /// Video's width in pixels.
        /// </summary>
        public int? Width { get; set; } 
    }
}
