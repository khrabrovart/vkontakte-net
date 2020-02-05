using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StatsCountry
    {
        /// <summary>
        /// Country code.
        /// </summary>
        public string Code { get; set; } 

        /// <summary>
        /// Visitors number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Country name.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// Country ID.
        /// </summary>
        public int? Value { get; set; } 
    }
}
