using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class LeadsStart
    {
        /// <summary>
        /// Information whether test mode is enabled.
        /// </summary>
        public bool? TestMode { get; set; } 

        /// <summary>
        /// Session data.
        /// </summary>
        public string VkSid { get; set; } 
    }
}
