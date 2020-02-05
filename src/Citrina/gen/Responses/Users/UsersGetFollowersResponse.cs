using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersGetFollowersResponse
    {
        /// <summary>
        /// Total friends number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<int> Items { get; set; } 
    }
}
