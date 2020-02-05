using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class SearchGetHintsResponse
    {
        public int? Count { get; set; } 

        public IEnumerable<SearchHint> Items { get; set; } 

        public IEnumerable<string> SuggestedQueries { get; set; } 
    }
}
