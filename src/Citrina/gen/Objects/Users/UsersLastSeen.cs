using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersLastSeen
    {
        /// <summary>
        /// Type of the platform that used for the last authorization.
        /// </summary>
        public int? Platform { get; set; } 

        /// <summary>
        /// Last visit date (in Unix time).
        /// </summary>
        public int? Time { get; set; } 
    }
}
