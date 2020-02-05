using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetResponse
    {
        /// <summary>
        /// Total communities number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<int> Items { get; set; } 
    }
}
