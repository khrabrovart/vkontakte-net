using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesStoryLink
    {
        /// <summary>
        /// Link text.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// Link URL.
        /// </summary>
        public string Url { get; set; } 
    }
}
