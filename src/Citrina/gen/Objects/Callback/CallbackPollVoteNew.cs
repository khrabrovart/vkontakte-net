using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackPollVoteNew
    {
        public int? OwnerId { get; set; } 

        public int? PollId { get; set; } 

        public int? OptionId { get; set; } 

        public int? UserId { get; set; } 
    }
}
