using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class PollsAnswer
    {
        public int? Id { get; set; } 

        public double? Rate { get; set; } 

        public string Text { get; set; } 

        public int? Votes { get; set; } 
    }

    public class PollsPoll
    {
        public bool? Anonymous { get; set; } 

        public int? AnswerId { get; set; } 

        public IEnumerable<object> Answers { get; set; } 

        public int? Created { get; set; } 

        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public string Question { get; set; } 

        public string Votes { get; set; } 
    }

    public class PollsVoters
    {
        public int? AnswerId { get; set; } 

        public PollsVotersUsers Users { get; set; } 
    }

    public class PollsVotersUsers
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }
}
