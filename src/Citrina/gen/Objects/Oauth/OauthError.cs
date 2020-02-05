using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class OauthError
    {
        /// <summary>
        /// Error type.
        /// </summary>
        public string Error { get; set; } 

        /// <summary>
        /// Error description.
        /// </summary>
        public string ErrorDescription { get; set; } 

        /// <summary>
        /// URI for validation.
        /// </summary>
        public string RedirectUri { get; set; } 
    }
}
