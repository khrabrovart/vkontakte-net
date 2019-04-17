using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class StoriesReplies
    {
        public int? Count { get; set; } 

        public int? New { get; set; } 
    }

    public class StoriesStory
    {
        public string AccessKey { get; set; } 

        public bool? CanComment { get; set; } 

        public bool? CanReply { get; set; } 

        public bool? CanSee { get; set; } 

        public bool? CanShare { get; set; } 

        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public bool? IsDeleted { get; set; } 

        public bool? IsExpired { get; set; } 

        public StoriesStoryLink Link { get; set; } 

        public int? OwnerId { get; set; } 

        public StoriesStory ParentStory { get; set; } 

        public string ParentStoryAccessKey { get; set; } 

        public int? ParentStoryId { get; set; } 

        public int? ParentStoryOwnerId { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public IEnumerable<object> Replies { get; set; } 

        public bool? Seen { get; set; } 

        public StoriesStoryType Type { get; set; } 

        public StoriesStoryVideo Video { get; set; } 

        public int? Views { get; set; } 
    }

    public class StoriesStoryLink
    {
        public string Text { get; set; } 

        public string Url { get; set; } 
    }

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

    public class StoriesStoryStatsStat
    {
        public int? Count { get; set; } 

        public StoriesStoryStatsState State { get; set; } 
    }

    public class StoriesStoryStatsState
    {
    }

    public class StoriesStoryType
    {
    }

    public class StoriesStoryVideo
    {
    }

    public class StoriesUploadLinkText
    {
    }
}
