using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesAudioMessage
    {
        /// <summary>
        /// Access key for audio message.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Audio message duration in seconds.
        /// </summary>
        public int? Duration { get; set; } 

        /// <summary>
        /// Audio message ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// MP3 file URL.
        /// </summary>
        public string LinkMp3 { get; set; } 

        /// <summary>
        /// OGG file URL.
        /// </summary>
        public string LinkOgg { get; set; } 

        /// <summary>
        /// Audio message owner ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        public IEnumerable<int> Waveform { get; set; } 
    }
}
