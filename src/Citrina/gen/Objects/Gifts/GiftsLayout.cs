using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GiftsLayout
    {
        /// <summary>
        /// Gift ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// URL of the preview image with 256 px in width.
        /// </summary>
        public string Thumb256 { get; set; } 

        /// <summary>
        /// URL of the preview image with 48 px in width.
        /// </summary>
        public string Thumb48 { get; set; } 

        /// <summary>
        /// URL of the preview image with 96 px in width.
        /// </summary>
        public string Thumb96 { get; set; } 
    }
}
