using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class LikesIsLikedResponse
    {
        /// <summary>
        /// Information whether user liked the object.
        /// </summary>
        public bool? Liked { get; set; } 

        /// <summary>
        /// Information whether user reposted the object.
        /// </summary>
        public bool? Copied { get; set; } 
    }
}
