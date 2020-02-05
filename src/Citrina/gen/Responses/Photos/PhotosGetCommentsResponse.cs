using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosGetCommentsResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Real offset of the comments.
        /// </summary>
        public int? RealOffset { get; set; } 

        public IEnumerable<WallWallComment> Items { get; set; } 
    }
}
