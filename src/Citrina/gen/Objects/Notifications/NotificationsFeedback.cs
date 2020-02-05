using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NotificationsFeedback
    {
        public IEnumerable<WallWallpostAttachment> Attachments { get; set; } 

        /// <summary>
        /// Reply author's ID.
        /// </summary>
        public int? FromId { get; set; } 

        public BaseGeo Geo { get; set; } 

        /// <summary>
        /// Item ID.
        /// </summary>
        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        /// <summary>
        /// Reply text.
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// Wall owner's ID.
        /// </summary>
        public int? ToId { get; set; } 
    }
}
