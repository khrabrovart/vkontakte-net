using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackConfirmationMessage
    {
        public string Type { get; set; } 

        public int? GroupId { get; set; } 

        public string Secret { get; set; } 
    }
}
