using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountSaveProfileInfoResponse
    {
        /// <summary>
        /// 1 if changes has been processed.
        /// </summary>
        public bool? Changed { get; set; } 

        public AccountNameRequest NameRequest { get; set; } 
    }
}
