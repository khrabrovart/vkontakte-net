using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseCommentsInfo
    {
        /// <summary>
        /// Information whether current user can comment the post.
        /// </summary>
        public bool? CanPost { get; set; } 

        /// <summary>
        /// Comments number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Information whether groups can comment the post.
        /// </summary>
        public bool? GroupsCanPost { get; set; } 
    }
}
