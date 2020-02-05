using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemTopic
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

        public BaseCommentsInfo Comments { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        /// <summary>
        /// Topic post ID.
        /// </summary>
        public int? PostId { get; set; } 

        /// <summary>
        /// Post text.
        /// </summary>
        public string Text { get; set; } 
    }
}
