using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class BoardGetCommentsExtendedResponse
    {
        /// <summary>
        /// Total number.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<BoardTopicComment> Items { get; set; } 

        public BoardTopicPoll Poll { get; set; } 

        public IEnumerable<UsersUser> Profiles { get; set; } 

        public IEnumerable<GroupsGroup> Groups { get; set; } 
    }
}
