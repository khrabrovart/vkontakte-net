using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountChangePasswordResponse
    {
        /// <summary>
        /// New token.
        /// </summary>
        public string Token { get; set; } 

        /// <summary>
        /// New secret.
        /// </summary>
        public string Secret { get; set; } 
    }
}
