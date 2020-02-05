using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackGroupOfficersEdit
    {
        public int? AdminId { get; set; } 

        public int? UserId { get; set; } 

        public int? LevelOld { get; set; } 

        public int? LevelNew { get; set; } 
    }
}
