using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsSubjectItem
    {
        /// <summary>
        /// Subject ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Subject title.
        /// </summary>
        public string Name { get; set; } 
    }
}
