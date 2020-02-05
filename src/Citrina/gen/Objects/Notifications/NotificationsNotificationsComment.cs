using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NotificationsNotificationsComment
    {
        /// <summary>
        /// Date when the comment has been added in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Comment ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Author ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public WallWallpost Post { get; set; } 

        /// <summary>
        /// Comment text.
        /// </summary>
        public string Text { get; set; } 

        public BoardTopic Topic { get; set; } 

        public VideoVideo Video { get; set; } 
    }
}
