using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WidgetsWidgetComment
    {
        public IEnumerable<WallCommentAttachment> Attachments { get; set; } 

        /// <summary>
        /// Information whether current user can delete the comment.
        /// </summary>
        public bool? CanDelete { get; set; } 

        public WidgetsCommentReplies Comments { get; set; } 

        /// <summary>
        /// Date when the comment has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Comment author ID.
        /// </summary>
        public int? FromId { get; set; } 

        /// <summary>
        /// Comment ID.
        /// </summary>
        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        public WidgetsCommentMedia Media { get; set; } 

        public WallPostSource PostSource { get; set; } 

        /// <summary>
        /// Post type.
        /// </summary>
        public int? PostType { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        /// <summary>
        /// Comment text.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// Wall owner.
        /// </summary>
        public int? ToId { get; set; } 

        public UsersUserFull User { get; set; } 
    }
}
