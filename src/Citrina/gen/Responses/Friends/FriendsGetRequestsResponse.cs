using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsGetRequestsResponse
    {
        /// <summary>
        /// Total requests number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<int> Items { get; set; } 

        /// <summary>
        /// Total unread requests number.
        /// </summary>
        public int? CountUnread { get; set; } 
    }
}
