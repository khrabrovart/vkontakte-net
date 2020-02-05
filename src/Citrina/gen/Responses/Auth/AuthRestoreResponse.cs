using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AuthRestoreResponse
    {
        /// <summary>
        /// 1 if success.
        /// </summary>
        public enum Success
        {
            Ok,
        }
        /// <summary>
        /// Parameter needed to grant access by code.
        /// </summary>
        public string Sid { get; set; } 
    }
}
