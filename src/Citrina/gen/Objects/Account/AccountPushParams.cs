using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountPushParams
    {
        public IEnumerable<AccountPushParamsMode> Msg { get; set; } 

        public IEnumerable<AccountPushParamsMode> Chat { get; set; } 

        public IEnumerable<AccountPushParamsSettings> Like { get; set; } 

        public IEnumerable<AccountPushParamsSettings> Repost { get; set; } 

        public IEnumerable<AccountPushParamsSettings> Comment { get; set; } 

        public IEnumerable<AccountPushParamsSettings> Mention { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> Reply { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> NewPost { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> WallPost { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> WallPublish { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> Friend { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> FriendFound { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> FriendAccepted { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> GroupInvite { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> GroupAccepted { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> Birthday { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> EventSoon { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> AppRequest { get; set; } 

        public IEnumerable<AccountPushParamsOnoff> SdkOpen { get; set; } 
    }
}
