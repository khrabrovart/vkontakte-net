using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallGraffiti
    {
        /// <summary>
        /// Graffiti ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Graffiti owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// URL of the preview image with 200 px in width.
        /// </summary>
        public string Photo200 { get; set; } 

        /// <summary>
        /// URL of the preview image with 586 px in width.
        /// </summary>
        public string Photo586 { get; set; } 
    }
}
