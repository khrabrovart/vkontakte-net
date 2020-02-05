using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesChatFull
    {
        /// <summary>
        /// Chat creator ID.
        /// </summary>
        public int? AdminId { get; set; } 

        /// <summary>
        /// Chat ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Shows that user has been kicked from the chat.
        /// </summary>
        public bool? Kicked { get; set; } 

        /// <summary>
        /// Shows that user has been left the chat.
        /// </summary>
        public bool? Left { get; set; } 

        /// <summary>
        /// URL of the preview image with 100 px in width.
        /// </summary>
        public string Photo100 { get; set; } 

        /// <summary>
        /// URL of the preview image with 200 px in width.
        /// </summary>
        public string Photo200 { get; set; } 

        /// <summary>
        /// URL of the preview image with 50 px in width.
        /// </summary>
        public string Photo50 { get; set; } 

        public MessagesChatPushSettings PushSettings { get; set; } 

        /// <summary>
        /// Chat title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Chat type.
        /// </summary>
        public string Type { get; set; } 

        public IEnumerable<MessagesUserXtrInvitedBy> Users { get; set; } 
    }
}
