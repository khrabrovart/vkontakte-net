using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsBanInfo
    {
        /// <summary>
        /// Administrator ID.
        /// </summary>
        public int? AdminId { get; set; } 

        /// <summary>
        /// Comment for a ban.
        /// </summary>
        public string Comment { get; set; } 

        /// <summary>
        /// Show comment for user.
        /// </summary>
        public bool? CommentVisible { get; set; } 

        public bool? IsClosed { get; set; } 

        /// <summary>
        /// Date when user has been added to blacklist in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Date when user will be removed from blacklist in Unixtime.
        /// </summary>
        public int? EndDate { get; set; } 

        public int? Reason { get; set; } 
    }
}
