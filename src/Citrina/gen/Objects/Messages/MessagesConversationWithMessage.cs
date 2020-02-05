using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesConversationWithMessage
    {
        public MessagesConversation Conversation { get; set; } 

        public MessagesMessage LastMessage { get; set; } 
    }
}
