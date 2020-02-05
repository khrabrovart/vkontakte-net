using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesStoryStatsStat
    {
        /// <summary>
        /// Stat value.
        /// </summary>
        public int? Count { get; set; } 

        public string State { get; set; } 
    }
}
