using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesGetHistoryAttachmentsResponse
    {
        public IEnumerable<MessagesHistoryAttachment> Items { get; set; } 

        /// <summary>
        /// Value for pagination.
        /// </summary>
        public string NextFrom { get; set; } 
    }
}
