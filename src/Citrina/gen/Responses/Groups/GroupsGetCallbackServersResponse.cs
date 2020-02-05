using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGetCallbackServersResponse
    {
        public int? Count { get; set; } 

        public IEnumerable<GroupsCallbackServer> Items { get; set; } 
    }
}
