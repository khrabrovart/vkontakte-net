using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseError
    {
        /// <summary>
        /// Error code.
        /// </summary>
        public int? ErrorCode { get; set; } 

        /// <summary>
        /// Error message.
        /// </summary>
        public string ErrorMsg { get; set; } 

        public IEnumerable<BaseRequestParam> RequestParams { get; set; } 
    }
}
