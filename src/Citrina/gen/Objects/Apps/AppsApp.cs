using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AppsApp
    {
        public string Type { get; set; } 

        /// <summary>
        /// Application ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Application title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Application author's ID.
        /// </summary>
        public int? AuthorId { get; set; } 

        /// <summary>
        /// URL of the app icon with 139 px in width.
        /// </summary>
        public string Icon139 { get; set; } 

        /// <summary>
        /// URL of the app icon with 150 px in width.
        /// </summary>
        public string Icon150 { get; set; } 

        /// <summary>
        /// URL of the app icon with 278 px in width.
        /// </summary>
        public string Icon278 { get; set; } 

        /// <summary>
        /// URL of the app icon with 75 px in width.
        /// </summary>
        public string Icon75 { get; set; } 

        /// <summary>
        /// Official community's ID.
        /// </summary>
        public int? AuthorGroup { get; set; } 

        /// <summary>
        /// Application author's URL.
        /// </summary>
        public string AuthorUrl { get; set; } 

        /// <summary>
        /// URL of the app banner with 1120 px in width.
        /// </summary>
        public string Banner1120 { get; set; } 

        /// <summary>
        /// URL of the app banner with 560 px in width.
        /// </summary>
        public string Banner560 { get; set; } 

        public IEnumerable<int> Friends { get; set; } 

        /// <summary>
        /// Catalog position.
        /// </summary>
        public int? CatalogPosition { get; set; } 

        /// <summary>
        /// Application description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Genre name.
        /// </summary>
        public string Genre { get; set; } 

        /// <summary>
        /// Genre ID.
        /// </summary>
        public int? GenreId { get; set; } 

        /// <summary>
        /// Information whether the application is multilanguage.
        /// </summary>
        public int? International { get; set; } 

        /// <summary>
        /// Information whether application is in mobile catalog.
        /// </summary>
        public int? IsInCatalog { get; set; } 

        public int? LeaderboardType { get; set; } 

        /// <summary>
        /// Members number.
        /// </summary>
        public int? MembersCount { get; set; } 

        /// <summary>
        /// Application ID in store.
        /// </summary>
        public int? PlatformId { get; set; } 

        /// <summary>
        /// Date when the application has been published in Unixtime.
        /// </summary>
        public int? PublishedDate { get; set; } 

        /// <summary>
        /// Screen name.
        /// </summary>
        public string ScreenName { get; set; } 

        public IEnumerable<PhotosPhoto> Screenshots { get; set; } 

        /// <summary>
        /// Application section name.
        /// </summary>
        public string Section { get; set; } 
    }
}
