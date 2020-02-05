using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetAddressesResponse
    {
        /// <summary>
        /// Total count of addresses.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<GroupsAddress> Items { get; set; } 
    }
}
