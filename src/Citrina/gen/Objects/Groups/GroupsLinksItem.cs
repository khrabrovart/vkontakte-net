using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsLinksItem
    {
        /// <summary>
        /// Link description.
        /// </summary>
        public string Desc { get; set; } 

        /// <summary>
        /// Information whether the link title can be edited.
        /// </summary>
        public bool? EditTitle { get; set; } 

        /// <summary>
        /// Link ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Link title.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// URL of square image of the link with 100 pixels in width.
        /// </summary>
        public string Photo100 { get; set; } 

        /// <summary>
        /// URL of square image of the link with 50 pixels in width.
        /// </summary>
        public string Photo50 { get; set; } 

        /// <summary>
        /// Link URL.
        /// </summary>
        public string Url { get; set; } 
    }
}
