using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGroupSettings
    {
        /// <summary>
        /// Community access settings.
        /// </summary>
        public int? Access { get; set; } 

        /// <summary>
        /// Community's page domain.
        /// </summary>
        public string Address { get; set; } 

        /// <summary>
        /// Audio settings.
        /// </summary>
        public int? Audio { get; set; } 

        /// <summary>
        /// Community description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Docs settings.
        /// </summary>
        public int? Docs { get; set; } 

        /// <summary>
        /// Information whether the obscene filter is enabled.
        /// </summary>
        public bool? ObsceneFilter { get; set; } 

        /// <summary>
        /// Information whether the stopwords filter is enabled.
        /// </summary>
        public bool? ObsceneStopwords { get; set; } 

        /// <summary>
        /// The list of stop words.
        /// </summary>
        public string ObsceneWords { get; set; } 

        /// <summary>
        /// Photos settings.
        /// </summary>
        public int? Photos { get; set; } 

        /// <summary>
        /// Information about the group category.
        /// </summary>
        public int? PublicCategory { get; set; } 

        public IEnumerable<GroupsGroupPublicCategoryList> PublicCategoryList { get; set; } 

        /// <summary>
        /// Information about the group subcategory.
        /// </summary>
        public int? PublicSubcategory { get; set; } 

        /// <summary>
        /// URL of the RSS feed.
        /// </summary>
        public string Rss { get; set; } 

        /// <summary>
        /// Community subject ID.
        /// </summary>
        public int? Subject { get; set; } 

        public IEnumerable<GroupsSubjectItem> SubjectList { get; set; } 

        /// <summary>
        /// Community title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Topics settings.
        /// </summary>
        public int? Topics { get; set; } 

        /// <summary>
        /// Video settings.
        /// </summary>
        public int? Video { get; set; } 

        /// <summary>
        /// Wall settings.
        /// </summary>
        public int? Wall { get; set; } 

        /// <summary>
        /// Community website.
        /// </summary>
        public string Website { get; set; } 

        /// <summary>
        /// Wiki settings.
        /// </summary>
        public int? Wiki { get; set; } 
    }
}
