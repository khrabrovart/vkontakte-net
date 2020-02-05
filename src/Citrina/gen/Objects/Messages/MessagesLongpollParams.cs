using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesLongpollParams
    {
        /// <summary>
        /// Key.
        /// </summary>
        public string Key { get; set; } 

        /// <summary>
        /// Persistent timestamp.
        /// </summary>
        public int? Pts { get; set; } 

        /// <summary>
        /// Server URL.
        /// </summary>
        public string Server { get; set; } 

        /// <summary>
        /// Timestamp.
        /// </summary>
        public int? Ts { get; set; } 
    }
}
