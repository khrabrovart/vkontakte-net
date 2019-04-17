using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class PrettyCardsPrettyCard
    {
        public string Button { get; set; } 

        public string ButtonText { get; set; } 

        public string CardId { get; set; } 

        public IEnumerable<object> Images { get; set; } 

        public string LinkUrl { get; set; } 

        public string Photo { get; set; } 

        public string Price { get; set; } 

        public string PriceOld { get; set; } 

        public string Title { get; set; } 
    }
}
