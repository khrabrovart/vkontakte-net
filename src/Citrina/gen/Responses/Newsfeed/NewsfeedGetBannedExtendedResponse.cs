using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NewsfeedGetBannedExtendedResponse
    {
        public IEnumerable<UsersUserFull> Groups { get; set; } 

        public IEnumerable<GroupsGroupFull> Profiles { get; set; } 
    }
}
