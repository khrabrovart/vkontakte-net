using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGroupLink
    {
        /// <summary>
        /// Link label.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// Link description.
        /// </summary>
        public string Desc { get; set; } 

        /// <summary>
        /// Information whether the title can be edited.
        /// </summary>
        public bool? EditTitle { get; set; } 

        /// <summary>
        /// Link ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Information whether the image on processing.
        /// </summary>
        public bool? ImageProcessing { get; set; } 

        /// <summary>
        /// Link URL.
        /// </summary>
        public string Url { get; set; } 
    }
}
