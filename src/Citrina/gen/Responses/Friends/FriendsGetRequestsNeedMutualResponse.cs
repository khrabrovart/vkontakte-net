using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsGetRequestsNeedMutualResponse
    {
        /// <summary>
        /// Total requests number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<FriendsRequests> Items { get; set; } 
    }
}
