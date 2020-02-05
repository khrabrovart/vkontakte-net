using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsMutualFriend
    {
        /// <summary>
        /// Total mutual friends number.
        /// </summary>
        public int? CommonCount { get; set; } 

        public IEnumerable<int> CommonFriends { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? Id { get; set; } 
    }
}
