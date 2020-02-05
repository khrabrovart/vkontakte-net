using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersUserConnections
    {
        /// <summary>
        /// User's Skype nickname.
        /// </summary>
        public string Skype { get; set; } 

        /// <summary>
        /// User's Facebook account.
        /// </summary>
        public string Facebook { get; set; } 

        /// <summary>
        /// User's Facebook name.
        /// </summary>
        public string FacebookName { get; set; } 

        /// <summary>
        /// User's Twitter account.
        /// </summary>
        public string Twitter { get; set; } 

        /// <summary>
        /// User's Livejournal account.
        /// </summary>
        public string Livejournal { get; set; } 

        /// <summary>
        /// User's Instagram account.
        /// </summary>
        public string Instagram { get; set; } 
    }
}
