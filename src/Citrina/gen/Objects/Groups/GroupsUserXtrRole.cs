using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsUserXtrRole
    {
        /// <summary>
        /// Returns if a profile is deleted or blocked.
        /// </summary>
        public string Deactivated { get; set; } 

        /// <summary>
        /// User first name.
        /// </summary>
        public string FirstName { get; set; } 

        /// <summary>
        /// Returns if a profile is hidden.
        /// </summary>
        public int? Hidden { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// User last name.
        /// </summary>
        public string LastName { get; set; } 

        public bool? CanAccessClosed { get; set; } 

        public bool? IsClosed { get; set; } 

        /// <summary>
        /// User sex.
        /// </summary>
        public int? Sex { get; set; } 

        /// <summary>
        /// Domain name of the user's page.
        /// </summary>
        public string ScreenName { get; set; } 

        /// <summary>
        /// URL of square photo of the user with 50 pixels in width.
        /// </summary>
        public string Photo50 { get; set; } 

        /// <summary>
        /// URL of square photo of the user with 100 pixels in width.
        /// </summary>
        public string Photo100 { get; set; } 

        /// <summary>
        /// Information whether the user is online.
        /// </summary>
        public bool? Online { get; set; } 

        /// <summary>
        /// Information whether the user is online in mobile site or application.
        /// </summary>
        public bool? OnlineMobile { get; set; } 

        /// <summary>
        /// Application ID.
        /// </summary>
        public int? OnlineApp { get; set; } 

        /// <summary>
        /// Information whether the user is verified.
        /// </summary>
        public bool? Verified { get; set; } 

        /// <summary>
        /// Information whether the user has a "fire" pictogram.
        /// </summary>
        public bool? Trending { get; set; } 

        public int? FriendStatus { get; set; } 

        public FriendsRequestsMutual Mutual { get; set; } 

        /// <summary>
        /// User nickname.
        /// </summary>
        public string Nickname { get; set; } 

        /// <summary>
        /// User maiden name.
        /// </summary>
        public string MaidenName { get; set; } 

        /// <summary>
        /// Domain name of the user's page.
        /// </summary>
        public string Domain { get; set; } 

        /// <summary>
        /// User's date of birth.
        /// </summary>
        public string Bdate { get; set; } 

        public BaseObject City { get; set; } 

        public BaseCountry Country { get; set; } 

        /// <summary>
        /// User's timezone.
        /// </summary>
        public int? Timezone { get; set; } 

        /// <summary>
        /// URL of square photo of the user with 200 pixels in width.
        /// </summary>
        public string Photo200 { get; set; } 

        /// <summary>
        /// URL of square photo of the user with maximum width.
        /// </summary>
        public string PhotoMax { get; set; } 

        /// <summary>
        /// URL of user's photo with 200 pixels in width.
        /// </summary>
        public string Photo200Orig { get; set; } 

        /// <summary>
        /// URL of user's photo with 400 pixels in width.
        /// </summary>
        public string Photo400Orig { get; set; } 

        /// <summary>
        /// URL of user's photo of maximum size.
        /// </summary>
        public string PhotoMaxOrig { get; set; } 

        /// <summary>
        /// ID of the user's main photo.
        /// </summary>
        public string PhotoId { get; set; } 

        /// <summary>
        /// Information whether the user has main photo.
        /// </summary>
        public bool? HasPhoto { get; set; } 

        /// <summary>
        /// Information whether the user specified his phone number.
        /// </summary>
        public bool? HasMobile { get; set; } 

        /// <summary>
        /// Information whether the user is a friend of current user.
        /// </summary>
        public bool? IsFriend { get; set; } 

        /// <summary>
        /// Information whether current user can comment wall posts.
        /// </summary>
        public bool? WallComments { get; set; } 

        /// <summary>
        /// Information whether current user can post on the user's wall.
        /// </summary>
        public bool? CanPost { get; set; } 

        /// <summary>
        /// Information whether current user can see other users' audio on the wall.
        /// </summary>
        public bool? CanSeeAllPosts { get; set; } 

        /// <summary>
        /// Information whether current user can see the user's audio.
        /// </summary>
        public bool? CanSeeAudio { get; set; } 

        /// <summary>
        /// Information whether current user can write private message.
        /// </summary>
        public bool? CanWritePrivateMessage { get; set; } 

        /// <summary>
        /// Information whether current user can send a friend request.
        /// </summary>
        public bool? CanSendFriendRequest { get; set; } 

        /// <summary>
        /// Information whether current user can see.
        /// </summary>
        public string MobilePhone { get; set; } 

        /// <summary>
        /// User's mobile phone number.
        /// </summary>
        public string HomePhone { get; set; } 

        /// <summary>
        /// User's website.
        /// </summary>
        public string Site { get; set; } 

        public AudioAudio StatusAudio { get; set; } 

        /// <summary>
        /// User's status.
        /// </summary>
        public string Status { get; set; } 

        /// <summary>
        /// User's status.
        /// </summary>
        public string Activity { get; set; } 

        public UsersLastSeen LastSeen { get; set; } 

        public UsersExports Exports { get; set; } 

        public UsersCropPhoto CropPhoto { get; set; } 

        /// <summary>
        /// Number of user's followers.
        /// </summary>
        public int? FollowersCount { get; set; } 

        /// <summary>
        /// Information whether current user is in the requested user's blacklist.
        /// </summary>
        public bool? Blacklisted { get; set; } 

        /// <summary>
        /// Information whether the requested user is in current user's blacklist.
        /// </summary>
        public bool? BlacklistedByMe { get; set; } 

        /// <summary>
        /// Information whether the requested user is in faves of current user.
        /// </summary>
        public bool? IsFavorite { get; set; } 

        /// <summary>
        /// Information whether the requested user is hidden from current user's newsfeed.
        /// </summary>
        public bool? IsHiddenFromFeed { get; set; } 

        /// <summary>
        /// Number of common friends with current user.
        /// </summary>
        public int? CommonCount { get; set; } 

        public UsersOccupation Occupation { get; set; } 

        public IEnumerable<UsersCareer> Career { get; set; } 

        public IEnumerable<UsersMilitary> Military { get; set; } 

        /// <summary>
        /// University ID.
        /// </summary>
        public int? University { get; set; } 

        /// <summary>
        /// University name.
        /// </summary>
        public string UniversityName { get; set; } 

        /// <summary>
        /// Faculty ID.
        /// </summary>
        public int? Faculty { get; set; } 

        /// <summary>
        /// Faculty name.
        /// </summary>
        public string FacultyName { get; set; } 

        /// <summary>
        /// Graduation year.
        /// </summary>
        public int? Graduation { get; set; } 

        /// <summary>
        /// Education form.
        /// </summary>
        public string EducationForm { get; set; } 

        /// <summary>
        /// User's education status.
        /// </summary>
        public string EducationStatus { get; set; } 

        /// <summary>
        /// User hometown.
        /// </summary>
        public string HomeTown { get; set; } 

        /// <summary>
        /// User relationship status.
        /// </summary>
        public int? Relation { get; set; } 

        public UsersUserMin RelationPartner { get; set; } 

        public UsersPersonal Personal { get; set; } 

        public IEnumerable<UsersUniversity> Universities { get; set; } 

        public IEnumerable<UsersSchool> Schools { get; set; } 

        public IEnumerable<UsersRelative> Relatives { get; set; } 

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

        public string Role { get; set; } 
    }
}
