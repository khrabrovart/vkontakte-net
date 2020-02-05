using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StatsCity
    {
        /// <summary>
        /// Visitors number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// City name.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// City ID.
        /// </summary>
        public int? Value { get; set; } 
    }
}
