using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesMessageAction
    {
        /// <summary>
        /// Message ID.
        /// </summary>
        public int? ConversationMessageId { get; set; } 

        /// <summary>
        /// Email address for chat_invite_user or chat_kick_user actions.
        /// </summary>
        public string Email { get; set; } 

        /// <summary>
        /// User or email peer ID.
        /// </summary>
        public int? MemberId { get; set; } 

        /// <summary>
        /// Message body of related message.
        /// </summary>
        public string Message { get; set; } 

        public MessagesMessageActionPhoto Photo { get; set; } 

        /// <summary>
        /// New chat title for chat_create and chat_title_update actions.
        /// </summary>
        public string Text { get; set; } 

        public string Type { get; set; } 
    }
}
