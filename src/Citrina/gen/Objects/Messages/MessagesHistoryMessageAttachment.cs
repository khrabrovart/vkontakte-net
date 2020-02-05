using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesHistoryMessageAttachment
    {
        public AudioAudio Audio { get; set; } 

        public MessagesAudioMessage AudioMessage { get; set; } 

        public DocsDoc Doc { get; set; } 

        public MessagesGraffiti Graffiti { get; set; } 

        public BaseLink Link { get; set; } 

        public BaseLink Market { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public BaseLink Share { get; set; } 

        public string Type { get; set; } 

        public VideoVideo Video { get; set; } 

        public BaseLink Wall { get; set; } 
    }
}
