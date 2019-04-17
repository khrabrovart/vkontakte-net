
namespace VKontakte.Net.Models
{
    public class SearchHint
    {
        public string Description { get; set; } 

        public bool? Global { get; set; } 

        public GroupsGroup Group { get; set; } 

        public UsersUserMin Profile { get; set; } 

        public SearchHintSection Section { get; set; } 

        public SearchHintType Type { get; set; } 
    }

    public class SearchHintSection
    {
    }

    public class SearchHintType
    {
    }
}
