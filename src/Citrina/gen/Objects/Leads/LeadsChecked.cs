using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class LeadsChecked
    {
        /// <summary>
        /// Reason why user can't start the lead.
        /// </summary>
        public string Reason { get; set; } 

        public string Result { get; set; } 

        /// <summary>
        /// Session ID.
        /// </summary>
        public string Sid { get; set; } 

        /// <summary>
        /// URL user should open to start the lead.
        /// </summary>
        public string StartLink { get; set; } 
    }
}
