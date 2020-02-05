using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class OrdersAmount
    {
        public IEnumerable<OrdersAmountItem> Amounts { get; set; } 

        /// <summary>
        /// Currency name.
        /// </summary>
        public string Currency { get; set; } 
    }
}
