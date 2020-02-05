using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackPhotoCommentDelete
    {
        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public int? UserId { get; set; } 

        public int? PhotoId { get; set; } 
    }
}
