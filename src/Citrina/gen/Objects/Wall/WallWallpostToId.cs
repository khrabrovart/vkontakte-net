using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallWallpostToId
    {
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; } 

        public BaseCommentsInfo Comments { get; set; } 

        /// <summary>
        /// ID of the source post owner.
        /// </summary>
        public int? CopyOwnerId { get; set; } 

        /// <summary>
        /// ID of the source post.
        /// </summary>
        public int? CopyPostId { get; set; } 

        /// <summary>
        /// Date of publishing in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Post author ID.
        /// </summary>
        public int? FromId { get; set; } 

        public WallGeo Geo { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        /// <summary>
        /// wall post ID (if comment).
        /// </summary>
        public int? PostId { get; set; } 

        public WallPostSource PostSource { get; set; } 

        public string PostType { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        /// <summary>
        /// Post signer ID.
        /// </summary>
        public int? SignerId { get; set; } 

        /// <summary>
        /// Post text.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// Wall owner's ID.
        /// </summary>
        public int? ToId { get; set; } 
    }
}
