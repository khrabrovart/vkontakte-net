using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallRepostResponse
    {
        public bool? Success { get; set; } 

        /// <summary>
        /// Created post ID.
        /// </summary>
        public int? PostId { get; set; } 

        /// <summary>
        /// Reposts number.
        /// </summary>
        public int? RepostsCount { get; set; } 

        /// <summary>
        /// Reposts number.
        /// </summary>
        public int? LikesCount { get; set; } 
    }
}
