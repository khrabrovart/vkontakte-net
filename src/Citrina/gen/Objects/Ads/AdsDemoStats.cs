using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsDemoStats
    {
        /// <summary>
        /// Object ID.
        /// </summary>
        public int? Id { get; set; } 

        public AdsDemostatsFormat Stats { get; set; } 

        public string Type { get; set; } 
    }
}
