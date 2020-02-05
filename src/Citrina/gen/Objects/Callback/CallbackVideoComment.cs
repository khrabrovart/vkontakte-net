using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackVideoComment
    {
        public int? Id { get; set; } 

        public int? FromId { get; set; } 

        public int? Date { get; set; } 

        public string Text { get; set; } 

        public int? VideoOwnerOd { get; set; } 
    }
}
