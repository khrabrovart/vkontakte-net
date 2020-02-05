using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BaseRepostsInfo
    {
        /// <summary>
        /// Reposts number.
        /// </summary>
        public int? Count { get; set; } 

        /// <summary>
        /// Information whether current user has reposted the post.
        /// </summary>
        public int? UserReposted { get; set; } 
    }
}
