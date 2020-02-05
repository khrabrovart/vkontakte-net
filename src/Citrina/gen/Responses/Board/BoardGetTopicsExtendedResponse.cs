using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BoardGetTopicsExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<BoardTopic> Items { get; set; } 

        public int? DefaultOrder { get; set; } 

        /// <summary>
        /// Information whether current user can add topic.
        /// </summary>
        public bool? CanAddTopics { get; set; } 

        public IEnumerable<UsersUserMin> Profiles { get; set; } 
    }
}
