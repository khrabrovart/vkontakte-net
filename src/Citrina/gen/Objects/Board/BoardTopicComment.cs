using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BoardTopicComment
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

        /// <summary>
        /// Real position of the comment.
        /// </summary>
        public int? RealOffset { get; set; } 

        /// <summary>
        /// Comment text.
        /// </summary>
        public string Text { get; set; } 
    }
}
