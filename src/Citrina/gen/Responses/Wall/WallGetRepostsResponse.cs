using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class WallGetRepostsResponse
    {
        public IEnumerable<WallWallpostFull> Items { get; set; } 

        public IEnumerable<UsersUser> Profiles { get; set; } 

        public IEnumerable<GroupsGroup> Groups { get; set; } 
    }
}
