using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesDeleteChatPhotoResponse
    {
        /// <summary>
        /// Service message ID.
        /// </summary>
        public int? MessageId { get; set; } 

        public MessagesChat Chat { get; set; } 
    }
}
