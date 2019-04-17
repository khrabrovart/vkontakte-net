
namespace VKontakte.Net.Models
{
    public class GiftsGift
    {
        public int? Date { get; set; } 

        public int? FromId { get; set; } 

        public GiftsLayout Gift { get; set; } 

        public string GiftHash { get; set; } 

        public int? Id { get; set; } 

        public string Message { get; set; } 

        public GiftsGiftPrivacy Privacy { get; set; } 
    }

    public class GiftsGiftPrivacy
    {
    }

    public class GiftsLayout
    {
        public int? Id { get; set; } 

        public string Thumb256 { get; set; } 

        public string Thumb48 { get; set; } 

        public string Thumb96 { get; set; } 
    }
}
