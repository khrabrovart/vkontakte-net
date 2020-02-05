using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesDeleteConversationResponse
    {
        /// <summary>
        /// Id of the last message, that was deleted.
        /// </summary>
        public int? LastDeletedId { get; set; } 
    }
}
