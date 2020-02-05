using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesGetVideoUploadServerResponse
    {
        /// <summary>
        /// Upload URL.
        /// </summary>
        public string UploadUrl { get; set; } 

        /// <summary>
        /// Users ID who can to see story.
        /// </summary>
        public IEnumerable<int> UserIds { get; set; } 
    }
}
