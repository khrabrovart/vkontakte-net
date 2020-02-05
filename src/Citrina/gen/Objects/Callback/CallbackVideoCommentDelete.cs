using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackVideoCommentDelete
    {
        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public int? UserId { get; set; } 

        public int? VideoId { get; set; } 
    }
}
