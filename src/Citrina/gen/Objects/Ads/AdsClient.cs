using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsClient
    {
        /// <summary>
        /// Client's total limit, rubles.
        /// </summary>
        public string AllLimit { get; set; } 

        /// <summary>
        /// Client's day limit, rubles.
        /// </summary>
        public string DayLimit { get; set; } 

        /// <summary>
        /// Client ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Client name.
        /// </summary>
        public string Name { get; set; } 
    }
}
