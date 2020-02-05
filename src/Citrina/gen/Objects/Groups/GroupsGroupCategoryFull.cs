using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGroupCategoryFull
    {
        /// <summary>
        /// Category ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Category name.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// Pages number.
        /// </summary>
        public int? PageCount { get; set; } 

        public IEnumerable<GroupsGroup> PagePreviews { get; set; } 

        public IEnumerable<GroupsGroupCategory> Subcategories { get; set; } 
    }
}
