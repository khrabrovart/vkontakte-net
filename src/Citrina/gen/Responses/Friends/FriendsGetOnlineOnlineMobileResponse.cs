using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class FriendsGetOnlineOnlineMobileResponse
    {
        public IEnumerable<int> Online { get; set; } 

        public IEnumerable<int> OnlineMobile { get; set; } 
    }
}
