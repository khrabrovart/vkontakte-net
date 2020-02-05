using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallAttachedNote
    {
        /// <summary>
        /// Comments number.
        /// </summary>
        public int? Comments { get; set; } 

        /// <summary>
        /// Date when the note has been created in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Note ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Note owner's ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Read comments number.
        /// </summary>
        public int? ReadComments { get; set; } 

        /// <summary>
        /// Note title.
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// URL of the page with note preview.
        /// </summary>
        public string ViewUrl { get; set; } 
    }
}
