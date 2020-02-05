using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackWallCommentDelete
    {
        public int? OwnerId { get; set; } 

        public int? Id { get; set; } 

        public int? UserId { get; set; } 

        public int? PostId { get; set; } 
    }
}
