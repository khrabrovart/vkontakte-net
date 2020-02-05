using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class PhotosPhotoTag
    {
        /// <summary>
        /// Date when tag has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Tag ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// ID of the tag creator.
        /// </summary>
        public int? PlacerId { get; set; } 

        /// <summary>
        /// Tag description.
        /// </summary>
        public string TaggedName { get; set; } 

        /// <summary>
        /// Tagged user ID.
        /// </summary>
        public int? UserId { get; set; } 

        /// <summary>
        /// Information whether the tag is reviewed.
        /// </summary>
        public bool? Viewed { get; set; } 

        /// <summary>
        /// Coordinate X of the left upper corner.
        /// </summary>
        public double? X { get; set; } 

        /// <summary>
        /// Coordinate X of the right lower corner.
        /// </summary>
        public double? X2 { get; set; } 

        /// <summary>
        /// Coordinate Y of the left upper corner.
        /// </summary>
        public double? Y { get; set; } 

        /// <summary>
        /// Coordinate Y of the right lower corner.
        /// </summary>
        public double? Y2 { get; set; } 
    }
}
