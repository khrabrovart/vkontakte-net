using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackMessageBase
    {
        public string Type { get; set; } 

        public object @Object { get; set; } 

        public int? GroupId { get; set; } 
    }
}
