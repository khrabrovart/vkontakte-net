using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemVideoVideo
    {
        /// <summary>
        /// Tags number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<VideoVideo> Items { get; set; } 
    }
}
