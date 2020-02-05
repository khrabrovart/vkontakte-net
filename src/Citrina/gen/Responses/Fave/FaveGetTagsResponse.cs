using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FaveGetTagsResponse
    {
        public int? Count { get; set; } 

        public IEnumerable<FaveTag> Items { get; set; } 
    }
}
