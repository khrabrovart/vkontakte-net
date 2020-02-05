using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetMembersResponse
    {
        /// <summary>
        /// Total members number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<int> Items { get; set; } 
    }
}
