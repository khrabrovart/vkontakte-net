using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseLink
    {
        public BaseLinkApplication Application { get; set; } 

        public BaseLinkButton Button { get; set; } 

        /// <summary>
        /// Link caption.
        /// </summary>
        public string Caption { get; set; } 

        /// <summary>
        /// Link description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Link ID.
        /// </summary>
        public string Id { get; set; } 

        public bool? IsFavorite { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        /// <summary>
        /// String ID of the page with article preview.
        /// </summary>
        public string PreviewPage { get; set; } 

        /// <summary>
        /// URL of the page with article preview.
        /// </summary>
        public string PreviewUrl { get; set; } 

        public BaseLinkProduct Product { get; set; } 

        public BaseLinkRating Rating { get; set; } 

        /// <summary>
        /// Link title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Link URL.
        /// </summary>
        public string Url { get; set; } 
    }
}
