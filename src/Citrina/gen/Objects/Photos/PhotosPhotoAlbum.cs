using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosPhotoAlbum
    {
        /// <summary>
        /// Date when the album has been created in Unixtime.
        /// </summary>
        public int? Created { get; set; } 

        /// <summary>
        /// Photo album description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Photo album ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Album owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Photos number.
        /// </summary>
        public int? Size { get; set; } 

        public PhotosPhoto Thumb { get; set; } 

        /// <summary>
        /// Photo album title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Date when the album has been updated last time in Unixtime.
        /// </summary>
        public int? Updated { get; set; } 
    }
}
