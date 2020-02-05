using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesConversation
    {
        public enum SpecialServiceType
        {
            [EnumMember(Value = "business_notify")]
            BusinessNotify,
        }

        public enum MessageRequest
        {
            [EnumMember(Value = "pending")]
            Pending,
            [EnumMember(Value = "rejected")]
            Rejected,
        }
        public MessagesConversationPeer Peer { get; set; } 

        /// <summary>
        /// ID of the last message in conversation.
        /// </summary>
        public int? LastMessageId { get; set; } 

        /// <summary>
        /// Last message user have read.
        /// </summary>
        public int? InRead { get; set; } 

        /// <summary>
        /// Last outcoming message have been read by the opponent.
        /// </summary>
        public int? OutRead { get; set; } 

        /// <summary>
        /// Unread messages number.
        /// </summary>
        public int? UnreadCount { get; set; } 

        public bool? Important { get; set; } 

        public bool? Unanswered { get; set; } 

        /// <summary>
        /// Ids of messages with mentions.
        /// </summary>
        public IEnumerable<int> Mentions { get; set; } 

        public MessagesKeyboard CurrentKeyboard { get; set; } 
    }
}
