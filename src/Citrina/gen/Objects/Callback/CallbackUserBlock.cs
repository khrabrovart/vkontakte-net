using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackUserBlock
    {
        public int? AdminId { get; set; } 

        public int? UserId { get; set; } 

        public int? UnblockDate { get; set; } 

        public int? Reason { get; set; } 

        public string Comment { get; set; } 
    }
}
