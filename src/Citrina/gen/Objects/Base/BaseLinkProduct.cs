using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseLinkProduct
    {
        public MarketPrice Price { get; set; } 

        public string Merchant { get; set; } 

        public int? OrdersCount { get; set; } 
    }
}
