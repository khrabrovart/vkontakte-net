
namespace VKontakte.Net.Models
{
    public class SecureLevel
    {
        public int? Level { get; set; } 

        public int? Uid { get; set; } 
    }

    public class SecureSmsNotification
    {
        public int? AppId { get; set; } 

        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public string Message { get; set; } 

        public int? UserId { get; set; } 
    }

    public class SecureTokenChecked
    {
        public int? Date { get; set; } 

        public int? Expire { get; set; } 

        public bool? Success { get; set; } 

        public int? UserId { get; set; } 
    }

    public class SecureTransaction
    {
        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public int? UidFrom { get; set; } 

        public int? UidTo { get; set; } 

        public int? Votes { get; set; } 
    }
}
