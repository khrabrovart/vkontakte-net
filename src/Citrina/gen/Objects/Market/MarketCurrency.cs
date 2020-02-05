using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MarketCurrency
    {
        /// <summary>
        /// Currency ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Currency sign.
        /// </summary>
        public string Name { get; set; } 
    }
}
