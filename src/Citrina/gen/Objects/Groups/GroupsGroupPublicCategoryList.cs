using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGroupPublicCategoryList
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public IEnumerable<GroupsGroupCategoryType> SubtypesList { get; set; } 
    }
}
