using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallPostSource
    {
        /// <summary>
        /// Additional data.
        /// </summary>
        public string Data { get; set; } 

        /// <summary>
        /// Platform name.
        /// </summary>
        public string Platform { get; set; } 

        public string Type { get; set; } 

        /// <summary>
        /// URL to an external site used to publish the post.
        /// </summary>
        public string Url { get; set; } 
    }
}
