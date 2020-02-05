using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallAppPost
    {
        /// <summary>
        /// Application ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Application name.
        /// </summary>
        public string Name { get; set; } 

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
