using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsRequestsMutual
    {
        /// <summary>
        /// Total mutual friends number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<int> Users { get; set; } 
    }
}
