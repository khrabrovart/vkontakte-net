using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WidgetsCommentMedia
    {
        /// <summary>
        /// Media item ID.
        /// </summary>
        public int? ItemId { get; set; } 

        /// <summary>
        /// Media owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// URL of the preview image (type=photo only).
        /// </summary>
        public string ThumbSrc { get; set; } 

        public string Type { get; set; } 
    }
}
