using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedGetBannedResponse
    {
        public IEnumerable<int> Groups { get; set; } 

        public IEnumerable<int> Members { get; set; } 
    }
}
