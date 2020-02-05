using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesLastActivity
    {
        /// <summary>
        /// Information whether user is online.
        /// </summary>
        public bool? Online { get; set; } 

        /// <summary>
        /// Time when user was online in Unixtime.
        /// </summary>
        public int? Time { get; set; } 
    }
}
