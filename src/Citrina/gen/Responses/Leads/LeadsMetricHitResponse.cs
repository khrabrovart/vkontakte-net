using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class LeadsMetricHitResponse
    {
        /// <summary>
        /// Information whether request has been processed successfully.
        /// </summary>
        public bool? Result { get; set; } 

        /// <summary>
        /// Redirect link.
        /// </summary>
        public string RedirectLink { get; set; } 
    }
}
