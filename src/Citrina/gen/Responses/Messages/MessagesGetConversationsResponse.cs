using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesGetConversationsResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Unread dialogs number.
        /// </summary>
        public int? UnreadCount { get; set; } 

        public IEnumerable<MessagesConversationWithMessage> Items { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 
    }
}
