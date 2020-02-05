using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WidgetsCommentReplies
    {
        /// <summary>
        /// Information whether current user can comment the post.
        /// </summary>
        public bool? CanPost { get; set; } 

        /// <summary>
        /// Comments number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<WidgetsCommentRepliesItem> Replies { get; set; } 
    }
}
