using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountInfo
    {
        /// <summary>
        /// Two factor authentication is enabled.
        /// </summary>
        [JsonProperty("2fa_required")]
        public bool? _2faRequired { get; set; } 

        /// <summary>
        /// Country code.
        /// </summary>
        public string Country { get; set; } 

        /// <summary>
        /// Information whether HTTPS-only is enabled.
        /// </summary>
        public bool? HttpsRequired { get; set; } 

        /// <summary>
        /// Information whether user has been processed intro.
        /// </summary>
        public bool? Intro { get; set; } 

        /// <summary>
        /// Language ID.
        /// </summary>
        public int? Lang { get; set; } 

        /// <summary>
        /// Information whether wall comments should be hidden.
        /// </summary>
        public bool? NoWallReplies { get; set; } 

        /// <summary>
        /// Information whether only owners posts should be shown.
        /// </summary>
        public bool? OwnPostsDefault { get; set; } 
    }
}
