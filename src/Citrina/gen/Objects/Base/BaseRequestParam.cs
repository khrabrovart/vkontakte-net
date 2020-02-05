using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseRequestParam
    {
        /// <summary>
        /// Parameter name.
        /// </summary>
        public string Key { get; set; } 

        /// <summary>
        /// Parameter value.
        /// </summary>
        public string Value { get; set; } 
    }
}
