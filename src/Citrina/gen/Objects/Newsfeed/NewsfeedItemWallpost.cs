using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemWallpost
    {
        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public NewsfeedEventActivity Activity { get; set; } 

        public IEnumerable<WallWallpostAttachment> Attachments { get; set; } 

        public BaseCommentsInfo Comments { get; set; } 

        public IEnumerable<WallWallpost> CopyHistory { get; set; } 

        public BaseGeo Geo { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 

        public WallPostSource PostSource { get; set; } 

        public string PostType { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        /// <summary>
        /// Post text.
        /// </summary>
        public string Text { get; set; } 
    }
}
