using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class SecureSmsNotification
    {
        /// <summary>
        /// Application ID.
        /// </summary>
        public string AppId { get; set; } 

        /// <summary>
        /// Date when message has been sent in Unixtime.
        /// </summary>
        public string Date { get; set; } 

        /// <summary>
        /// Notification ID.
        /// </summary>
        public string Id { get; set; } 

        /// <summary>
        /// Messsage text.
        /// </summary>
        public string Message { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public string UserId { get; set; } 
    }
}
