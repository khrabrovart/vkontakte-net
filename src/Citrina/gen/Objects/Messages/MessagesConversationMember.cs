using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesConversationMember
    {
        /// <summary>
        /// Is it possible for user to kick this member.
        /// </summary>
        public bool? CanKick { get; set; } 

        public int? InvitedBy { get; set; } 

        public bool? IsAdmin { get; set; } 

        public bool? IsOwner { get; set; } 

        public bool? IsMessageRequest { get; set; } 

        public int? JoinDate { get; set; } 

        /// <summary>
        /// Message request date.
        /// </summary>
        public int? RequestDate { get; set; } 

        public int? MemberId { get; set; } 
    }
}
