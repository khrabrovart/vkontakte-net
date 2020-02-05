using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class LeadsEntry
    {
        /// <summary>
        /// Application ID.
        /// </summary>
        public int? Aid { get; set; } 

        /// <summary>
        /// Comment text.
        /// </summary>
        public string Comment { get; set; } 

        /// <summary>
        /// Date when the action has been started in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Session string ID.
        /// </summary>
        public string Sid { get; set; } 

        /// <summary>
        /// Start date in Unixtime (for status=2).
        /// </summary>
        public int? StartDate { get; set; } 

        /// <summary>
        /// Action type.
        /// </summary>
        public int? Status { get; set; } 

        /// <summary>
        /// Information whether test mode is enabled.
        /// </summary>
        public bool? TestMode { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? Uid { get; set; } 
    }
}
