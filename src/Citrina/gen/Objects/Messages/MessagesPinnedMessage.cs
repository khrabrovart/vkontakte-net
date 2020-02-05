using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesPinnedMessage
    {
        public IEnumerable<MessagesMessageAttachment> Attachments { get; set; } 

        /// <summary>
        /// Unique auto-incremented number for all messages with this peer.
        /// </summary>
        public int? ConversationMessageId { get; set; } 

        /// <summary>
        /// Date when the message has been sent in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Message author's ID.
        /// </summary>
        public int? FromId { get; set; } 

        /// <summary>
        /// Forwarded messages.
        /// </summary>
        public IEnumerable<MessagesForeignMessage> FwdMessages { get; set; } 

        public BaseGeo Geo { get; set; } 

        /// <summary>
        /// Message ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Peer ID.
        /// </summary>
        public int? PeerId { get; set; } 

        public MessagesForeignMessage ReplyMessage { get; set; } 

        /// <summary>
        /// Message text.
        /// </summary>
        public string Text { get; set; } 

        public MessagesKeyboard Keyboard { get; set; } 
    }
}
