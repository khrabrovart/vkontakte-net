using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsAccount
    {
        public string AccessRole { get; set; } 

        /// <summary>
        /// Account ID.
        /// </summary>
        public int? AccountId { get; set; } 

        /// <summary>
        /// Information whether account is active.
        /// </summary>
        public bool? AccountStatus { get; set; } 

        public string AccountType { get; set; } 
    }
}
