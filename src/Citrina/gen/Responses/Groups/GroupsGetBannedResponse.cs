using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetBannedResponse
    {
        /// <summary>
        /// Total users number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<GroupsBannedItem> Items { get; set; } 
    }
}
