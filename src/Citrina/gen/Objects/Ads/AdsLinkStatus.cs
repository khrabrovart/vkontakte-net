using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsLinkStatus
    {
        /// <summary>
        /// Reject reason.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// URL.
        /// </summary>
        public string RedirectUrl { get; set; } 

        /// <summary>
        /// Link status.
        /// </summary>
        public string Status { get; set; } 
    }
}
