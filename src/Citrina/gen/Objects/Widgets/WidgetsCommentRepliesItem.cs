using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WidgetsCommentRepliesItem
    {
        /// <summary>
        /// Comment ID.
        /// </summary>
        public int? Cid { get; set; } 

        /// <summary>
        /// Date when the comment has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public WidgetsWidgetLikes Likes { get; set; } 

        /// <summary>
        /// Comment text.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? Uid { get; set; } 

        public UsersUserFull User { get; set; } 
    }
}
