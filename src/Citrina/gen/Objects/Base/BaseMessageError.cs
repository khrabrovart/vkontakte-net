using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseMessageError
    {
        /// <summary>
        /// Error code.
        /// </summary>
        public int? Code { get; set; } 

        /// <summary>
        /// Error message.
        /// </summary>
        public string Description { get; set; } 
    }
}
