using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesMessage
    {
        public MessagesMessageAction Action { get; set; } 

        /// <summary>
        /// Only for messages from community. Contains user ID of community admin, who sent this message.
        /// </summary>
        public int? AdminAuthorId { get; set; } 

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
        /// Is it an deleted message.
        /// </summary>
        public bool? Deleted { get; set; } 

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
        /// Is it an important message.
        /// </summary>
        public bool? Important { get; set; } 

        public bool? IsHidden { get; set; } 

        public MessagesKeyboard Keyboard { get; set; } 

        /// <summary>
        /// Members number.
        /// </summary>
        public int? MembersCount { get; set; } 

        /// <summary>
        /// Information whether the message is outcoming.
        /// </summary>
        public bool? @Out { get; set; } 

        public string Payload { get; set; } 

        /// <summary>
        /// Peer ID.
        /// </summary>
        public int? PeerId { get; set; } 

        /// <summary>
        /// ID used for sending messages. It returned only for outgoing messages.
        /// </summary>
        public int? RandomId { get; set; } 

        public string @Ref { get; set; } 

        public string RefSource { get; set; } 

        public MessagesForeignMessage ReplyMessage { get; set; } 

        /// <summary>
        /// Message text.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// Date when the message has been updated in Unixtime.
        /// </summary>
        public int? UpdateTime { get; set; } 
    }
}
