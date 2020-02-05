using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsFriendStatus
    {
        public int? FriendStatus { get; set; } 

        /// <summary>
        /// Information whether request is unviewed.
        /// </summary>
        public bool? ReadState { get; set; } 

        /// <summary>
        /// Message sent with request.
        /// </summary>
        public string RequestMessage { get; set; } 

        /// <summary>
        /// MD5 hash for the result validation.
        /// </summary>
        public string Sign { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 
    }
}
