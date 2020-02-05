using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsGroupFull
    {
        public int? AdminLevel { get; set; } 

        /// <summary>
        /// Information whether community is banned.
        /// </summary>
        public string Deactivated { get; set; } 

        /// <summary>
        /// Finish date in Unixtime format.
        /// </summary>
        public int? FinishDate { get; set; } 

        /// <summary>
        /// Community ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Information whether current user is administrator.
        /// </summary>
        public bool? IsAdmin { get; set; } 

        /// <summary>
        /// Information whether current user is advertiser.
        /// </summary>
        public bool? IsAdvertiser { get; set; } 

        public int? IsClosed { get; set; } 

        /// <summary>
        /// Information whether current user is member.
        /// </summary>
        public bool? IsMember { get; set; } 

        /// <summary>
        /// Community name.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// URL of square photo of the community with 100 pixels in width.
        /// </summary>
        public string Photo100 { get; set; } 

        /// <summary>
        /// URL of square photo of the community with 200 pixels in width.
        /// </summary>
        public string Photo200 { get; set; } 

        /// <summary>
        /// URL of square photo of the community with 50 pixels in width.
        /// </summary>
        public string Photo50 { get; set; } 

        /// <summary>
        /// Domain of the community page.
        /// </summary>
        public string ScreenName { get; set; } 

        /// <summary>
        /// Start date in Unixtime format.
        /// </summary>
        public int? StartDate { get; set; } 

        public string Type { get; set; } 

        public GroupsMarketInfo Market { get; set; } 

        /// <summary>
        /// Current user's member status.
        /// </summary>
        public int? MemberStatus { get; set; } 

        /// <summary>
        /// Information whether community is in faves.
        /// </summary>
        public bool? IsFavorite { get; set; } 

        /// <summary>
        /// Information whether current user is subscribed.
        /// </summary>
        public bool? IsSubscribed { get; set; } 

        public BaseObject City { get; set; } 

        public BaseCountry Country { get; set; } 

        /// <summary>
        /// Information whether community is verified.
        /// </summary>
        public bool? Verified { get; set; } 

        /// <summary>
        /// Community description.
        /// </summary>
        public string Description { get; set; } 

        /// <summary>
        /// Community's main wiki page title.
        /// </summary>
        public string WikiPage { get; set; } 

        /// <summary>
        /// Community members number.
        /// </summary>
        public int? MembersCount { get; set; } 

        public GroupsCountersGroup Counters { get; set; } 

        public GroupsCover Cover { get; set; } 

        /// <summary>
        /// Information whether current user can post on community's wall.
        /// </summary>
        public bool? CanPost { get; set; } 

        /// <summary>
        /// Information whether current user can see all posts on community's wall.
        /// </summary>
        public bool? CanSeeAllPosts { get; set; } 

        /// <summary>
        /// Type of group, start date of event or category of public page.
        /// </summary>
        public string Activity { get; set; } 

        /// <summary>
        /// Fixed post ID.
        /// </summary>
        public int? FixedPost { get; set; } 

        /// <summary>
        /// Information whether current user can create topic.
        /// </summary>
        public bool? CanCreateTopic { get; set; } 

        /// <summary>
        /// Information whether current user can upload video.
        /// </summary>
        public bool? CanUploadVideo { get; set; } 

        /// <summary>
        /// Information whether community has photo.
        /// </summary>
        public bool? HasPhoto { get; set; } 

        /// <summary>
        /// Community status.
        /// </summary>
        public string Status { get; set; } 

        /// <summary>
        /// Community's main photo album ID.
        /// </summary>
        public int? MainAlbumId { get; set; } 

        public IEnumerable<GroupsLinksItem> Links { get; set; } 

        public IEnumerable<GroupsContactsItem> Contacts { get; set; } 

        /// <summary>
        /// Community's website.
        /// </summary>
        public string Site { get; set; } 

        public int? MainSection { get; set; } 

        /// <summary>
        /// Information whether the community has a "fire" pictogram.
        /// </summary>
        public bool? Trending { get; set; } 

        /// <summary>
        /// Information whether current user can send a message to community.
        /// </summary>
        public bool? CanMessage { get; set; } 

        /// <summary>
        /// Information whether community can send a message to current user.
        /// </summary>
        public bool? IsMessagesBlocked { get; set; } 

        /// <summary>
        /// Information whether community can send notifications by phone number to current user.
        /// </summary>
        public bool? CanSendNotify { get; set; } 

        /// <summary>
        /// Status of replies in community messages.
        /// </summary>
        public GroupsOnlineStatus OnlineStatus { get; set; } 

        /// <summary>
        /// Information whether age limit.
        /// </summary>
        public int? AgeLimits { get; set; } 

        /// <summary>
        /// User ban info.
        /// </summary>
        public GroupsGroupBanInfo BanInfo { get; set; } 

        /// <summary>
        /// Info about addresses in groups.
        /// </summary>
        public GroupsAddressesInfo Addresses { get; set; } 

        /// <summary>
        /// Information whether current user is subscribed to podcasts.
        /// </summary>
        public bool? IsSubscribedPodcasts { get; set; } 

        /// <summary>
        /// Owner in whitelist or not.
        /// </summary>
        public bool? CanSubscribePodcasts { get; set; } 

        /// <summary>
        /// Can subscribe to wall.
        /// </summary>
        public bool? CanSubscribePosts { get; set; } 
    }
}
