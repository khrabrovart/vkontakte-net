using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsGetFieldsResponse
    {
        /// <summary>
        /// Total friends number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<FriendsUserXtrLists> Items { get; set; } 
    }
}
