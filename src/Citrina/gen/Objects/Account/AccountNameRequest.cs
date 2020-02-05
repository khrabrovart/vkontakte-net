using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountNameRequest
    {
        /// <summary>
        /// First name in request.
        /// </summary>
        public string FirstName { get; set; } 

        /// <summary>
        /// Request ID needed to cancel the request.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Last name in request.
        /// </summary>
        public string LastName { get; set; } 

        public string Status { get; set; } 

        public string Lang { get; set; } 
    }
}
