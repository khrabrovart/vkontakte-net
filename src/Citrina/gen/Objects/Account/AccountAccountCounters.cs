using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountAccountCounters
    {
        /// <summary>
        /// New app requests number.
        /// </summary>
        public int? AppRequests { get; set; } 

        /// <summary>
        /// New events number.
        /// </summary>
        public int? Events { get; set; } 

        /// <summary>
        /// New friends requests number.
        /// </summary>
        public int? Friends { get; set; } 

        /// <summary>
        /// New friends suggestions number.
        /// </summary>
        public int? FriendsSuggestions { get; set; } 

        /// <summary>
        /// New gifts number.
        /// </summary>
        public int? Gifts { get; set; } 

        /// <summary>
        /// New groups number.
        /// </summary>
        public int? Groups { get; set; } 

        /// <summary>
        /// New messages number.
        /// </summary>
        public int? Messages { get; set; } 

        /// <summary>
        /// New notifications number.
        /// </summary>
        public int? Notifications { get; set; } 

        /// <summary>
        /// New photo tags number.
        /// </summary>
        public int? Photos { get; set; } 

        /// <summary>
        /// New video tags number.
        /// </summary>
        public int? Videos { get; set; } 
    }
}
