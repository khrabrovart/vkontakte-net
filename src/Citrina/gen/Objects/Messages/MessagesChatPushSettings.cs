using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesChatPushSettings
    {
        /// <summary>
        /// Time until that notifications are disabled.
        /// </summary>
        public int? DisabledUntil { get; set; } 

        /// <summary>
        /// Information whether the sound is on.
        /// </summary>
        public bool? Sound { get; set; } 
    }
}
