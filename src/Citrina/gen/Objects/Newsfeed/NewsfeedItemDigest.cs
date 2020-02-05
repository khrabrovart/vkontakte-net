using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemDigest
    {
        /// <summary>
        /// type of digest.
        /// </summary>
        public enum Template
        {
            [EnumMember(Value = "list")]
            List,
            [EnumMember(Value = "grid")]
            Grid,
        }
        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public string ButtonText { get; set; } 

        /// <summary>
        /// id of feed in digest.
        /// </summary>
        public string FeedId { get; set; } 

        public IEnumerable<WallWallpost> Items { get; set; } 

        public IEnumerable<string> MainPostIds { get; set; } 

        public string Title { get; set; } 

        public string TrackCode { get; set; } 
    }
}
