using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseImage
    {
        /// <summary>
        /// Image height.
        /// </summary>
        public int? Height { get; set; } 

        /// <summary>
        /// Image url.
        /// </summary>
        public string Url { get; set; } 

        /// <summary>
        /// Image width.
        /// </summary>
        public int? Width { get; set; } 
    }
}
