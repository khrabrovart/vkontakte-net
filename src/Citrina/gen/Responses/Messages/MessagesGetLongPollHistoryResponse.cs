using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesGetLongPollHistoryResponse
    {
        public IEnumerable<IEnumerable<int>> History { get; set; } 

        public IEnumerable<GroupsGroup> Groups { get; set; } 

        public MessagesLongpollMessages Messages { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<MessagesChat> Chats { get; set; } 

        /// <summary>
        /// Persistence timestamp.
        /// </summary>
        public int? NewPts { get; set; } 

        /// <summary>
        /// Has more.
        /// </summary>
        public bool? More { get; set; } 

        public IEnumerable<MessagesConversation> Conversations { get; set; } 
    }
}
