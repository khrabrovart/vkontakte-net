using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackMarketComment
    {
        public int? Id { get; set; } 

        public int? FromId { get; set; } 

        public int? Date { get; set; } 

        public string Text { get; set; } 

        public int? MarketOwnerOd { get; set; } 

        public int? PhotoId { get; set; } 
    }
}
