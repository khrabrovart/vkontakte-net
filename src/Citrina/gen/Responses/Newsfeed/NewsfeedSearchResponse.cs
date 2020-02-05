using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedSearchResponse
    {
        public IEnumerable<WallWallpostFull> Items { get; set; } 

        public IEnumerable<string> SuggestedQueries { get; set; } 
    }
}
