using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesGetConversationMembersResponse
    {
        /// <summary>
        /// Chat members count.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<MessagesConversationMember> Items { get; set; } 

        public MessagesChatRestrictions ChatRestrictions { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 
    }
}
