using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedItemPhoto
    {
        public string Type { get; set; } 

        /// <summary>
        /// Item source ID.
        /// </summary>
        public int? SourceId { get; set; } 

        /// <summary>
        /// Date when item has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        public NewsfeedItemPhotoPhotos Photos { get; set; } 

        /// <summary>
        /// Post ID.
        /// </summary>
        public int? PostId { get; set; } 
    }
}
