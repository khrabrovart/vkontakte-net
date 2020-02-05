using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetMembersFieldsResponse
    {
        /// <summary>
        /// Total members number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<GroupsUserXtrRole> Items { get; set; } 
    }
}
