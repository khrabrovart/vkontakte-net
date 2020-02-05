using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NotificationsSendMessageItem
    {
        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 

        /// <summary>
        /// Notification status.
        /// </summary>
        public bool? Status { get; set; } 

        public NotificationsSendMessageError Error { get; set; } 
    }
}
