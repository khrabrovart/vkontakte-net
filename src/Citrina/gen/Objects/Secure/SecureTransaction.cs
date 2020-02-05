using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class SecureTransaction
    {
        /// <summary>
        /// Transaction date in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Transaction ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// From ID.
        /// </summary>
        public int? UidFrom { get; set; } 

        /// <summary>
        /// To ID.
        /// </summary>
        public int? UidTo { get; set; } 

        /// <summary>
        /// Votes number.
        /// </summary>
        public int? Votes { get; set; } 
    }
}
