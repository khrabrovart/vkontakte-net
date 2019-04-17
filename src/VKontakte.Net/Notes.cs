
namespace VKontakte.Net.Models
{
    public class NotesNote
    {
        public bool? CanComment { get; set; } 

        public int? Comments { get; set; } 

        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public string Text { get; set; } 

        public string TextWiki { get; set; } 

        public string Title { get; set; } 

        public string ViewUrl { get; set; } 
    }

    public class NotesNoteComment
    {
        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public string Message { get; set; } 

        public int? Nid { get; set; } 

        public int? Oid { get; set; } 

        public int? ReplyTo { get; set; } 

        public int? Uid { get; set; } 
    }
}
