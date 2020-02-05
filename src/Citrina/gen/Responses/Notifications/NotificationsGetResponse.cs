using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class NotificationsGetResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 

        public IEnumerable<UsersUser> Profiles { get; set; } 

        public IEnumerable<GroupsGroup> Groups { get; set; } 

        /// <summary>
        /// Time when user has been checked notifications last time.
        /// </summary>
        public int? LastViewed { get; set; } 

        public IEnumerable<PhotosPhoto> Photos { get; set; } 

        public IEnumerable<VideoVideo> Videos { get; set; } 

        public IEnumerable<AppsApp> Apps { get; set; } 

        public string NextFrom { get; set; } 

        public int? Ttl { get; set; } 
    }
}
