using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NotificationsReply
    {
        /// <summary>
        /// Date when the reply has been created in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Reply ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Reply text.
        /// </summary>
        public int? Text { get; set; } 
    }
}
