using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallPostedPhoto
    {
        /// <summary>
        /// Photo ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Photo owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// URL of the preview image with 130 px in width.
        /// </summary>
        public string Photo130 { get; set; } 

        /// <summary>
        /// URL of the preview image with 604 px in width.
        /// </summary>
        public string Photo604 { get; set; } 
    }
}
