using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessageChatPreview
    {
        public int? AdminId { get; set; } 

        public bool? Joined { get; set; } 

        public int? LocalId { get; set; } 

        public IEnumerable<int> Members { get; set; } 

        public int? MembersCount { get; set; } 

        public string Title { get; set; } 
    }
}
