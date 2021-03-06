using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UtilsLastShortenedLink
    {
        /// <summary>
        /// Access key for private stats.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Link key (characters after vk.cc/).
        /// </summary>
        public string Key { get; set; } 

        /// <summary>
        /// Short link URL.
        /// </summary>
        public string ShortUrl { get; set; } 

        /// <summary>
        /// Creation time in Unixtime.
        /// </summary>
        public int? Timestamp { get; set; } 

        /// <summary>
        /// Full URL.
        /// </summary>
        public string Url { get; set; } 

        /// <summary>
        /// Total views number.
        /// </summary>
        public int? Views { get; set; } 
    }
}
