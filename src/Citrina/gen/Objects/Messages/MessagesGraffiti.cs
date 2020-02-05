using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesGraffiti
    {
        /// <summary>
        /// Access key for graffiti.
        /// </summary>
        public string AccessKey { get; set; } 

        /// <summary>
        /// Graffiti height.
        /// </summary>
        public int? Height { get; set; } 

        /// <summary>
        /// Graffiti ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Graffiti owner ID.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Graffiti URL.
        /// </summary>
        public string Url { get; set; } 

        /// <summary>
        /// Graffiti width.
        /// </summary>
        public int? Width { get; set; } 
    }
}
