
namespace VKontakte.Net.Models
{
    public class PagesPrivacySettings
    {
    }

    public class PagesWikipage
    {
        public int? CreatorId { get; set; } 

        public int? CreatorName { get; set; } 

        public int? EditorId { get; set; } 

        public string EditorName { get; set; } 

        public int? GroupId { get; set; } 

        public int? Id { get; set; } 

        public string Title { get; set; } 

        public int? Views { get; set; } 

        public PagesPrivacySettings WhoCanEdit { get; set; } 

        public PagesPrivacySettings WhoCanView { get; set; } 
    }

    public class PagesWikipageFull
    {
        public int? Created { get; set; } 

        public int? CreatorId { get; set; } 

        public bool? CurrentUserCanEdit { get; set; } 

        public bool? CurrentUserCanEditAccess { get; set; } 

        public int? Edited { get; set; } 

        public int? EditorId { get; set; } 

        public int? GroupId { get; set; } 

        public string Html { get; set; } 

        public int? Id { get; set; } 

        public string Source { get; set; } 

        public string Title { get; set; } 

        public string ViewUrl { get; set; } 

        public int? Views { get; set; } 

        public PagesPrivacySettings WhoCanEdit { get; set; } 

        public PagesPrivacySettings WhoCanView { get; set; } 
    }

    public class PagesWikipageVersion
    {
        public int? Edited { get; set; } 

        public int? EditorId { get; set; } 

        public string EditorName { get; set; } 

        public int? Id { get; set; } 

        public int? Length { get; set; } 
    }
}
