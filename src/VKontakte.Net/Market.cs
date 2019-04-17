
namespace VKontakte.Net.Models
{
    public class MarketCurrency
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 
    }

    public class MarketMarketAlbum
    {
        public int? Count { get; set; } 

        public int? Id { get; set; } 

        public int? OwnerId { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public string Title { get; set; } 

        public int? UpdatedTime { get; set; } 
    }

    public class MarketMarketCategory
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public MarketSection Section { get; set; } 
    }

    public class MarketMarketItem
    {
        public string AccessKey { get; set; } 

        public MarketMarketItemAvailability Availability { get; set; } 

        public string ButtonTitle { get; set; } 

        public MarketMarketCategory Category { get; set; } 

        public int? Date { get; set; } 

        public string Description { get; set; } 

        public int? Id { get; set; } 

        public bool? IsFavorite { get; set; } 

        public int? OwnerId { get; set; } 

        public MarketPrice Price { get; set; } 

        public string ThumbPhoto { get; set; } 

        public string Title { get; set; } 

        public string Url { get; set; } 
    }

    public class MarketMarketItemAvailability
    {
    }

    public class MarketMarketItemFull
    {
    }

    public class MarketPrice
    {
        public string Amount { get; set; } 

        public MarketCurrency Currency { get; set; } 

        public string Text { get; set; } 
    }

    public class MarketSection
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 
    }
}
