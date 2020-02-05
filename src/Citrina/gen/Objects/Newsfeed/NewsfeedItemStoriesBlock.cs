using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemStoriesBlock
    {
        public enum BlockType
        {
            [EnumMember(Value = "local")]
            Local,
            [EnumMember(Value = "remote")]
            Remote,
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

        public IEnumerable<StoriesStory> Stories { get; set; } 

        public string Title { get; set; } 

        public string TrackCode { get; set; } 
    }
}
