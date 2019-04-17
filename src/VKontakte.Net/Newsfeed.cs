using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class NewsfeedCommentsFilters
    {
    }

    public class NewsfeedEventActivity
    {
        public string Address { get; set; } 

        public string ButtonText { get; set; } 

        public IEnumerable<object> Friends { get; set; } 

        public GroupsGroupFullMemberStatus MemberStatus { get; set; } 

        public string Text { get; set; } 

        public int? Time { get; set; } 
    }

    public class NewsfeedFilters
    {
    }

    public class NewsfeedIgnoreItemType
    {
    }

    public class NewsfeedItemAudio
    {
        public NewsfeedItemAudioAudio Audio { get; set; } 

        public int? PostId { get; set; } 
    }

    public class NewsfeedItemAudioAudio
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class NewsfeedItemDigest
    {
        public string ButtonText { get; set; } 

        public string FeedId { get; set; } 

        public IEnumerable<object> Items { get; set; } 

        public IEnumerable<object> MainPostIds { get; set; } 

        public string Template { get; set; } 

        public string Title { get; set; } 

        public string TrackCode { get; set; } 

        public string Type { get; set; } 
    }

    public class NewsfeedItemFriend
    {
        public NewsfeedItemFriendFriends Friends { get; set; } 
    }

    public class NewsfeedItemFriendFriends
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class NewsfeedItemNote
    {
        public NewsfeedItemNoteNotes Notes { get; set; } 
    }

    public class NewsfeedItemNoteNotes
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class NewsfeedItemPhoto
    {
        public NewsfeedItemPhotoPhotos Photos { get; set; } 

        public int? PostId { get; set; } 
    }

    public class NewsfeedItemPhotoPhotos
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class NewsfeedItemPhotoTag
    {
        public NewsfeedItemPhotoTagPhotoTags PhotoTags { get; set; } 

        public int? PostId { get; set; } 
    }

    public class NewsfeedItemPhotoTagPhotoTags
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class NewsfeedItemTopic
    {
        public BaseCommentsInfo Comments { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        public int? PostId { get; set; } 

        public string Text { get; set; } 
    }

    public class NewsfeedItemVideo
    {
        public NewsfeedItemVideoVideo Video { get; set; } 
    }

    public class NewsfeedItemVideoVideo
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class NewsfeedItemWallpost
    {
        public NewsfeedEventActivity Activity { get; set; } 

        public IEnumerable<object> Attachments { get; set; } 

        public BaseCommentsInfo Comments { get; set; } 

        public IEnumerable<object> CopyHistory { get; set; } 

        public BaseGeo Geo { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        public int? PostId { get; set; } 

        public WallPostSource PostSource { get; set; } 

        public NewsfeedItemWallpostType PostType { get; set; } 

        public BaseRepostsInfo Reposts { get; set; } 

        public string Text { get; set; } 
    }

    public class NewsfeedItemWallpostType
    {
    }

    public class NewsfeedList
    {
        public int? Id { get; set; } 

        public string Title { get; set; } 
    }

    public class NewsfeedListFull
    {
    }

    public class NewsfeedNewsfeedItem
    {
    }

    public class NewsfeedNewsfeedItemType
    {
    }

    public class NewsfeedNewsfeedNote
    {
        public int? Comments { get; set; } 

        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public string Title { get; set; } 
    }

    public class NewsfeedNewsfeedPhoto
    {
    }
}
