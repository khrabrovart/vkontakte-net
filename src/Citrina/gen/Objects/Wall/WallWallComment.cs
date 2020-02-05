using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallWallComment
    {
        public IEnumerable<WallCommentAttachment> Attachments { get; set; } 

        /// <summary>
        /// Date when the comment has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Author ID.
        /// </summary>
        public int? FromId { get; set; } 

        /// <summary>
        /// Comment ID.
        /// </summary>
        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        /// <summary>
        /// Real position of the comment.
        /// </summary>
        public int? RealOffset { get; set; } 

        /// <summary>
        /// Replied comment ID.
        /// </summary>
        public int? ReplyToComment { get; set; } 

        /// <summary>
        /// Replied user ID.
        /// </summary>
        public int? ReplyToUser { get; set; } 

        /// <summary>
        /// Comment text.
        /// </summary>
        public string Text { get; set; } 

        public CommentThread Thread { get; set; } 

        public int? PostId { get; set; } 

        public int? OwnerId { get; set; } 

        public IEnumerable<int> ParentsStack { get; set; } 

        public bool? Deleted { get; set; } 
    }
}
