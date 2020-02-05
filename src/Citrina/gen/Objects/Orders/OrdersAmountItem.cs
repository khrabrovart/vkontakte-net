using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class OrdersAmountItem
    {
        /// <summary>
        /// Votes amount in user's currency.
        /// </summary>
        public int? Amount { get; set; } 

        /// <summary>
        /// Amount description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Votes number.
        /// </summary>
        public string Votes { get; set; } 
    }
}
