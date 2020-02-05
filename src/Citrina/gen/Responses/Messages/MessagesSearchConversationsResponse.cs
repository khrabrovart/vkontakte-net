using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesSearchConversationsResponse
    {
        /// <summary>
        /// Total results number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<MessagesConversation> Items { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 
    }
}
