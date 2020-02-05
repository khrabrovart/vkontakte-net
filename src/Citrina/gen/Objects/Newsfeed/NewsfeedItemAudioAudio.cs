using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemAudioAudio
    {
        /// <summary>
        /// Audios number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<AudioAudio> Items { get; set; } 
    }
}
