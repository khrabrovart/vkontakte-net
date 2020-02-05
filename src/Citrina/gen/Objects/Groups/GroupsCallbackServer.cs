using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsCallbackServer
    {
        public enum Status
        {
            [EnumMember(Value = "unconfigured")]
            Unconfigured,
            [EnumMember(Value = "failed")]
            Failed,
            [EnumMember(Value = "wait")]
            Wait,
            [EnumMember(Value = "ok")]
            Ok,
        }
        public int? Id { get; set; } 

        public string Title { get; set; } 

        public int? CreatorId { get; set; } 

        public string Url { get; set; } 

        public string SecretKey { get; set; } 
    }
}
