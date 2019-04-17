using System.Collections.Generic;
using Newtonsoft.Json;

namespace VKontakte.Net.Models
{
    public class AccountAccountCounters
    {
        public int? AppRequests { get; set; } 

        public int? Events { get; set; } 

        public int? Friends { get; set; } 

        public int? FriendsSuggestions { get; set; } 

        public int? Gifts { get; set; } 

        public int? Groups { get; set; } 

        public int? Messages { get; set; } 

        public int? Notifications { get; set; } 

        public int? Photos { get; set; } 

        public int? Videos { get; set; } 
    }

    public class AccountInfo
    {
        [JsonProperty("2fa_required")]
        public bool? _2faRequired { get; set; } 

        public string Country { get; set; } 

        public bool? HttpsRequired { get; set; } 

        public bool? Intro { get; set; } 

        public int? Lang { get; set; } 

        public bool? NoWallReplies { get; set; } 

        public bool? OwnPostsDefault { get; set; } 
    }

    public class AccountNameRequest
    {
        public string FirstName { get; set; } 

        public int? Id { get; set; } 

        public string LastName { get; set; } 

        public AccountNameRequestStatus Status { get; set; } 
    }

    public class AccountNameRequestStatus
    {
    }

    public class AccountOffer
    {
        public string Description { get; set; } 

        public int? Id { get; set; } 

        public string Img { get; set; } 

        public string Instruction { get; set; } 

        public string InstructionHtml { get; set; } 

        public int? Price { get; set; } 

        public string ShortDescription { get; set; } 

        public string Tag { get; set; } 

        public string Title { get; set; } 
    }

    public class AccountOnoffOptions
    {
    }

    public class AccountPushConversations
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class AccountPushConversationsItem
    {
        public int? DisabledUntil { get; set; } 

        public int? PeerId { get; set; } 

        public bool? Sound { get; set; } 
    }

    public class AccountPushParams
    {
        public IEnumerable<object> AppRequest { get; set; } 

        public IEnumerable<object> Birthday { get; set; } 

        public IEnumerable<object> Chat { get; set; } 

        public IEnumerable<object> Comment { get; set; } 

        public IEnumerable<object> EventSoon { get; set; } 

        public IEnumerable<object> Friend { get; set; } 

        public IEnumerable<object> FriendAccepted { get; set; } 

        public IEnumerable<object> FriendFound { get; set; } 

        public IEnumerable<object> GroupAccepted { get; set; } 

        public IEnumerable<object> GroupInvite { get; set; } 

        public IEnumerable<object> Like { get; set; } 

        public IEnumerable<object> Mention { get; set; } 

        public IEnumerable<object> Msg { get; set; } 

        public IEnumerable<object> NewPost { get; set; } 

        public IEnumerable<object> PhotosTag { get; set; } 

        public IEnumerable<object> Reply { get; set; } 

        public IEnumerable<object> Repost { get; set; } 

        public IEnumerable<object> SdkOpen { get; set; } 

        public IEnumerable<object> WallPost { get; set; } 

        public IEnumerable<object> WallPublish { get; set; } 
    }

    public class AccountPushParamsMode
    {
    }

    public class AccountPushParamsSettings
    {
    }

    public class AccountPushSettings
    {
        public AccountPushConversations Conversations { get; set; } 

        public bool? Disabled { get; set; } 

        public int? DisabledUntil { get; set; } 

        public AccountPushParams Settings { get; set; } 
    }

    public class AccountUserSettings
    {
        public string Bdate { get; set; } 

        public int? BdateVisibility { get; set; } 

        public BaseObject City { get; set; } 

        public BaseCountry Country { get; set; } 

        public string FirstName { get; set; } 

        public string HomeTown { get; set; } 

        public string LastName { get; set; } 

        public string MaidenName { get; set; } 

        public AccountNameRequest NameRequest { get; set; } 

        public string Phone { get; set; } 

        public int? Relation { get; set; } 

        public UsersUserMin RelationPartner { get; set; } 

        public int? RelationPending { get; set; } 

        public IEnumerable<object> RelationRequests { get; set; } 

        public string ScreenName { get; set; } 

        public BaseSex Sex { get; set; } 

        public string Status { get; set; } 
    }
}
