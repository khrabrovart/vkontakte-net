using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountPushSettings
    {
        /// <summary>
        /// Information whether notifications are disabled.
        /// </summary>
        public bool? Disabled { get; set; } 

        /// <summary>
        /// Time until that notifications are disabled in Unixtime.
        /// </summary>
        public int? DisabledUntil { get; set; } 

        public AccountPushParams Settings { get; set; } 

        public AccountPushConversations Conversations { get; set; } 
    }
}
