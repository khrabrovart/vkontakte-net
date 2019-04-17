using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class AppsApp
    {
        public int? AuthorGroup { get; set; } 

        public int? AuthorId { get; set; } 

        public string AuthorUrl { get; set; } 

        public string Banner1120 { get; set; } 

        public string Banner560 { get; set; } 

        public int? CatalogPosition { get; set; } 

        public string Description { get; set; } 

        public string Genre { get; set; } 

        public int? GenreId { get; set; } 

        public string Icon139 { get; set; } 

        public string Icon150 { get; set; } 

        public string Icon278 { get; set; } 

        public string Icon75 { get; set; } 

        public int? Id { get; set; } 

        public int? International { get; set; } 

        public int? IsInCatalog { get; set; } 

        public AppsAppLeaderboardType LeaderboardType { get; set; } 

        public int? MembersCount { get; set; } 

        public int? PlatformId { get; set; } 

        public int? PublishedDate { get; set; } 

        public string ScreenName { get; set; } 

        public IEnumerable<object> Screenshots { get; set; } 

        public string Section { get; set; } 

        public string Title { get; set; } 

        public AppsAppType Type { get; set; } 
    }

    public class AppsAppLeaderboardType
    {
    }

    public class AppsAppType
    {
    }

    public class AppsLeaderboard
    {
        public int? Level { get; set; } 

        public int? Points { get; set; } 

        public int? Score { get; set; } 

        public int? UserId { get; set; } 
    }

    public class AppsScope
    {
        public string Name { get; set; } 

        public string Title { get; set; } 
    }
}
