using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesGetConversationsByIdExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<MessagesConversation> Items { get; set; } 

        public IEnumerable<UsersUser> Profiles { get; set; } 
    }
}
