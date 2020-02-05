using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsLongPollServer
    {
        /// <summary>
        /// Long Poll key.
        /// </summary>
        public string Key { get; set; } 

        /// <summary>
        /// Long Poll server address.
        /// </summary>
        public string Server { get; set; } 

        /// <summary>
        /// Number of the last event.
        /// </summary>
        public string Ts { get; set; } 
    }
}
