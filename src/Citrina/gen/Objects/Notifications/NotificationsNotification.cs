using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NotificationsNotification
    {
        /// <summary>
        /// Date when the event has been occurred.
        /// </summary>
        public int? Date { get; set; } 

        public NotificationsFeedback Feedback { get; set; } 

        public NotificationsNotificationParent Parent { get; set; } 

        public NotificationsReply Reply { get; set; } 

        /// <summary>
        /// Notification type.
        /// </summary>
        public string Type { get; set; } 
    }
}
