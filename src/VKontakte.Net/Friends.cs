using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class FriendsFriendsList
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 
    }

    public class FriendsFriendStatus
    {
        public FriendsFriendStatusStatus FriendStatus { get; set; } 

        public bool? ReadState { get; set; } 

        public string RequestMessage { get; set; } 

        public string Sign { get; set; } 

        public int? UserId { get; set; } 
    }

    public class FriendsFriendStatusStatus
    {
    }

    public class FriendsMutualFriend
    {
        public int? CommonCount { get; set; } 

        public IEnumerable<object> CommonFriends { get; set; } 

        public int? Id { get; set; } 
    }

    public class FriendsRequests
    {
        public string From { get; set; } 

        public FriendsRequestsMutual Mutual { get; set; } 

        public int? UserId { get; set; } 
    }

    public class FriendsRequestsMutual
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Users { get; set; } 
    }

    public class FriendsRequestsXtrMessage
    {
        public string From { get; set; } 

        public string Message { get; set; } 

        public FriendsRequestsMutual Mutual { get; set; } 

        public int? UserId { get; set; } 
    }

    public class FriendsUserXtrLists
    {
    }

    public class FriendsUserXtrPhone
    {
    }
}
