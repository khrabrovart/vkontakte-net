using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetMembersFilterResponse
    {
        /// <summary>
        /// Total members number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<GroupsMemberRole> Items { get; set; } 
    }
}
