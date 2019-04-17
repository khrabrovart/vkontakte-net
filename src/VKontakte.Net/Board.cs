using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class BoardDefaultOrder
    {
    }

    public class BoardTopic
    {
        public int? Comments { get; set; } 

        public int? Created { get; set; } 

        public int? CreatedBy { get; set; } 

        public int? Id { get; set; } 

        public bool? IsClosed { get; set; } 

        public bool? IsFixed { get; set; } 

        public string Title { get; set; } 

        public int? Updated { get; set; } 

        public int? UpdatedBy { get; set; } 
    }

    public class BoardTopicComment
    {
        public IEnumerable<object> Attachments { get; set; } 

        public int? Date { get; set; } 

        public int? FromId { get; set; } 

        public int? Id { get; set; } 

        public int? RealOffset { get; set; } 

        public string Text { get; set; } 
    }

    public class BoardTopicPoll
    {
        public int? AnswerId { get; set; } 

        public IEnumerable<object> Answers { get; set; } 

        public int? Created { get; set; } 

        public bool? IsClosed { get; set; } 

        public int? OwnerId { get; set; } 

        public int? PollId { get; set; } 

        public string Question { get; set; } 

        public string Votes { get; set; } 
    }
}
