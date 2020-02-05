using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemAudio
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

        public NewsfeedItemAudioAudio Audio { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 
    }
}
