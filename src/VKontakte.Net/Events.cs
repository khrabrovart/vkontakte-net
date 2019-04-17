using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class EventsEventAttach
    {
        public string Address { get; set; } 

        public string ButtonText { get; set; } 

        public IEnumerable<object> Friends { get; set; } 

        public int? Id { get; set; } 

        public bool? IsFavorite { get; set; } 

        public GroupsGroupFullMemberStatus MemberStatus { get; set; } 

        public string Text { get; set; } 

        public int? Time { get; set; } 
    }
}
