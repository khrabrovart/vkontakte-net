using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class NotificationsFeedback
    {
        public IEnumerable<object> Attachments { get; set; } 

        public int? FromId { get; set; } 

        public BaseGeo Geo { get; set; } 

        public int? Id { get; set; } 

        public BaseLikesInfo Likes { get; set; } 

        public string Text { get; set; } 

        public int? ToId { get; set; } 
    }

    public class NotificationsNotification
    {
        public int? Date { get; set; } 

        public NotificationsFeedback Feedback { get; set; } 

        public NotificationsNotificationParent Parent { get; set; } 

        public NotificationsReply Reply { get; set; } 

        public string Type { get; set; } 
    }

    public class NotificationsNotificationParent
    {
    }

    public class NotificationsNotificationsComment
    {
        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public WallWallpost Post { get; set; } 

        public string Text { get; set; } 

        public BoardTopic Topic { get; set; } 

        public VideoVideo Video { get; set; } 
    }

    public class NotificationsReply
    {
        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public int? Text { get; set; } 
    }
}
