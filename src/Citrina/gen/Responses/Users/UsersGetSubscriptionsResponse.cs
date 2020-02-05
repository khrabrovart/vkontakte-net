using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersGetSubscriptionsResponse
    {
        public UsersUsersArray Users { get; set; } 

        public GroupsGroupsArray Groups { get; set; } 
    }
}
