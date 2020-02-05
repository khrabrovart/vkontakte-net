using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesStoryStats
    {
        public StoriesStoryStatsStat Answer { get; set; } 

        public StoriesStoryStatsStat Bans { get; set; } 

        public StoriesStoryStatsStat OpenLink { get; set; } 

        public StoriesStoryStatsStat Replies { get; set; } 

        public StoriesStoryStatsStat Shares { get; set; } 

        public StoriesStoryStatsStat Subscribers { get; set; } 

        public StoriesStoryStatsStat Views { get; set; } 
    }
}
