using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGroupsArray
    {
        /// <summary>
        /// Communities number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<int> Items { get; set; } 
    }
}
