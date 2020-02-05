using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsRequests
    {
        /// <summary>
        /// ID of the user by whom friend has been suggested.
        /// </summary>
        public string From { get; set; } 

        public FriendsRequestsMutual Mutual { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 
    }
}
