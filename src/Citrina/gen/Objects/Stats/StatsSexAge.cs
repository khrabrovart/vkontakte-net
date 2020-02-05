using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StatsSexAge
    {
        /// <summary>
        /// Visitors number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Sex/age value.
        /// </summary>
        public string Value { get; set; } 
    }
}
