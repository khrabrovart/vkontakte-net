using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FaveGetPagesResponse
    {
        public int? Count { get; set; } 

        public IEnumerable<FavePage> Items { get; set; } 
    }
}
