using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesGetByIdResponse
    {
        /// <summary>
        /// Stories count.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<StoriesStory> Items { get; set; } 
    }
}
