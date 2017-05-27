using System;

namespace Citrina
{
    [Flags]
    public enum UserPermissions
    {
        Notify = 1,
        Friends = 2,
        Photos = 4,
        Audio = 8,
        Video = 16,
        Offers = 32,
        Questions = 64,
        Pages = 128,
        Status = 1024,
        Notes = 2048,
        Messages = 4096, 
        Wall = 8192,
        Ads = 32768,
        Offline = 65536,
        Groups = 262144,        
        Docs = 131072,
        Email = 4194304,
        Notifications = 524288,
        Stats = 1048576,
        Market = 134217728
    }
}