using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class CallbackGroupSettingsChanges
    {
        public string Title { get; set; } 

        public string Description { get; set; } 

        public int? Access { get; set; } 

        public string ScreenName { get; set; } 

        public int? PublicCategory { get; set; } 

        public int? PublicSubcategory { get; set; } 

        public int? AgeLimits { get; set; } 

        public string Website { get; set; } 

        public int? EnableStatusDefault { get; set; } 

        public int? EnableAudio { get; set; } 

        public int? EnableVideo { get; set; } 

        public int? EnablePhoto { get; set; } 

        public int? EnableMarket { get; set; } 
    }
}
