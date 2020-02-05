using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class DocsSaveResponse
    {
        public string Type { get; set; } 

        public MessagesAudioMessage AudioMessage { get; set; } 

        public DocsDoc Doc { get; set; } 

        public MessagesGraffiti Graffiti { get; set; } 
    }
}
