using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class MessageChatPreview
    {
        public int? AdminId { get; set; } 

        public bool? Joined { get; set; } 

        public int? LocalId { get; set; } 

        public IEnumerable<object> Members { get; set; } 

        public int? MembersCount { get; set; } 

        public string Title { get; set; } 
    }
}
