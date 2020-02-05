using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StreamingGetServerUrlResponse
    {
        /// <summary>
        /// Server host.
        /// </summary>
        public string Endpoint { get; set; } 

        /// <summary>
        /// Access key.
        /// </summary>
        public string Key { get; set; } 
    }
}
