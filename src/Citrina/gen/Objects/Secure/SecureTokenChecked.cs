using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class SecureTokenChecked
    {
        /// <summary>
        /// Date when access_token has been generated in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Date when access_token will expire in Unixtime.
        /// </summary>
        public int? Expire { get; set; } 

        /// <summary>
        /// Returns if successfully processed.
        /// </summary>
        public bool? Success { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 
    }
}
