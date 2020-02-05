using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesHistoryAttachment
    {
        public MessagesHistoryMessageAttachment Attachment { get; set; } 

        /// <summary>
        /// Message ID.
        /// </summary>
        public int? MessageId { get; set; } 

        /// <summary>
        /// Message author's ID.
        /// </summary>
        public int? FromId { get; set; } 
    }
}
