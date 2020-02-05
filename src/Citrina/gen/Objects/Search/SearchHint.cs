using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class SearchHint
    {
        public AppsApp App { get; set; } 

        /// <summary>
        /// Object description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Information whether the object has been found globally.
        /// </summary>
        public bool? Global { get; set; } 

        public GroupsGroup Group { get; set; } 

        public UsersUserMin Profile { get; set; } 

        public string Section { get; set; } 

        public string Type { get; set; } 
    }
}
