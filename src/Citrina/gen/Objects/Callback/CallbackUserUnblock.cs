using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackUserUnblock
    {
        public int? AdminId { get; set; } 

        public int? UserId { get; set; } 

        public int? ByEndDate { get; set; } 
    }
}
