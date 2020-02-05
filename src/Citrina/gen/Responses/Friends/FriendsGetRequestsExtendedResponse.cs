using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsGetRequestsExtendedResponse
    {
        /// <summary>
        /// Total requests number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<FriendsRequestsXtrMessage> Items { get; set; } 
    }
}
