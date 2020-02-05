using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseLinkButtonAction
    {
        public string Type { get; set; } 

        /// <summary>
        /// Action URL.
        /// </summary>
        public string Url { get; set; } 
    }
}
