using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemFriendFriends
    {
        /// <summary>
        /// Number of friends has been added.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<BaseUserId> Items { get; set; } 
    }
}
