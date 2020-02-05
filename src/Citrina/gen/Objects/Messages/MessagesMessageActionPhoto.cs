using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesMessageActionPhoto
    {
        /// <summary>
        /// URL of the preview image with 100px in width.
        /// </summary>
        public string Photo100 { get; set; } 

        /// <summary>
        /// URL of the preview image with 200px in width.
        /// </summary>
        public string Photo200 { get; set; } 

        /// <summary>
        /// URL of the preview image with 50px in width.
        /// </summary>
        public string Photo50 { get; set; } 
    }
}
