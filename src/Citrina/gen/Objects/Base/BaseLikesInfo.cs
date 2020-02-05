using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseLikesInfo
    {
        /// <summary>
        /// Information whether current user can like the post.
        /// </summary>
        public bool? CanLike { get; set; } 

        /// <summary>
        /// Information whether current user can repost.
        /// </summary>
        public bool? CanPublish { get; set; } 

        /// <summary>
        /// Likes number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Information whether current uer has liked the post.
        /// </summary>
        public int? UserLikes { get; set; } 
    }
}
