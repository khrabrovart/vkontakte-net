using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesLongpollMessages
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<MessagesMessage> Items { get; set; } 
    }
}
