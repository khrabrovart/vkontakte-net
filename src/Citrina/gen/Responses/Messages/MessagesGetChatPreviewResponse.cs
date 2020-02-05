using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesGetChatPreviewResponse
    {
        public MessageChatPreview Preview { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 
    }
}
