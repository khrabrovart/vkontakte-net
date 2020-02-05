using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesChatRestrictions
    {
        /// <summary>
        /// Only admins can promote users to admins.
        /// </summary>
        public bool? AdminsPromoteUsers { get; set; } 

        /// <summary>
        /// Only admins can change chat info.
        /// </summary>
        public bool? OnlyAdminsEditInfo { get; set; } 

        /// <summary>
        /// Only admins can edit pinned message.
        /// </summary>
        public bool? OnlyAdminsEditPin { get; set; } 

        /// <summary>
        /// Only admins can invite users to this chat.
        /// </summary>
        public bool? OnlyAdminsInvite { get; set; } 

        /// <summary>
        /// Only admins can kick users from this chat.
        /// </summary>
        public bool? OnlyAdminsKick { get; set; } 
    }
}
