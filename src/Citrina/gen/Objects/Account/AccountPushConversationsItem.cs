using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountPushConversationsItem
    {
        /// <summary>
        /// Time until that notifications are disabled in seconds.
        /// </summary>
        public int? DisabledUntil { get; set; } 

        /// <summary>
        /// Peer ID.
        /// </summary>
        public int? PeerId { get; set; } 

        /// <summary>
        /// Information whether the sound are enabled.
        /// </summary>
        public bool? Sound { get; set; } 
    }
}
