using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NotificationsSendMessageError
    {
        /// <summary>
        /// Error code.
        /// </summary>
        public enum Code
        {
            NotificationsDisabled,
            FloodControlPerHour,
            FloodControlPerDay,
            AppIsNotInstalled,
        }
        /// <summary>
        /// Error description.
        /// </summary>
        public string Description { get; set; } 
    }
}
