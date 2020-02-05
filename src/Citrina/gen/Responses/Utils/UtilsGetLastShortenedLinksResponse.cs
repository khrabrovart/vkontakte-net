using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UtilsGetLastShortenedLinksResponse
    {
        /// <summary>
        /// Total number of available results.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<UtilsLastShortenedLink> Items { get; set; } 
    }
}
