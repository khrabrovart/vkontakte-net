using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesReplies
    {
        /// <summary>
        /// Replies number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// New replies number.
        /// </summary>
        public int? New { get; set; } 
    }
}
