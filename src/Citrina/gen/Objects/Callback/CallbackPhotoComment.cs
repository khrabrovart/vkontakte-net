using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackPhotoComment
    {
        public int? Id { get; set; } 

        public int? FromId { get; set; } 

        public int? Date { get; set; } 

        public string Text { get; set; } 

        public int? PhotoOwnerOd { get; set; } 
    }
}
