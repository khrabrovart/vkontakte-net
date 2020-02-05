using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseLikes
    {
        /// <summary>
        /// Likes number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Information whether current user likes the photo.
        /// </summary>
        public bool? UserLikes { get; set; } 
    }
}
