using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class UtilsDomainResolved
    {
        public int? ObjectId { get; set; } 

        public UtilsDomainResolvedType Type { get; set; } 
    }

    public class UtilsDomainResolvedType
    {
    }

    public class UtilsLastShortenedLink
    {
        public string AccessKey { get; set; } 

        public string Key { get; set; } 

        public string ShortUrl { get; set; } 

        public int? Timestamp { get; set; } 

        public string Url { get; set; } 

        public int? Views { get; set; } 
    }

    public class UtilsLinkChecked
    {
        public string Link { get; set; } 

        public UtilsLinkCheckedStatus Status { get; set; } 
    }

    public class UtilsLinkCheckedStatus
    {
    }

    public class UtilsLinkStats
    {
        public string Key { get; set; } 

        public IEnumerable<object> Stats { get; set; } 
    }

    public class UtilsLinkStatsExtended
    {
        public string Key { get; set; } 

        public IEnumerable<object> Stats { get; set; } 
    }

    public class UtilsShortLink
    {
        public string AccessKey { get; set; } 

        public string Key { get; set; } 

        public string ShortUrl { get; set; } 

        public string Url { get; set; } 
    }

    public class UtilsStats
    {
        public int? Timestamp { get; set; } 

        public int? Views { get; set; } 
    }

    public class UtilsStatsCity
    {
        public int? CityId { get; set; } 

        public int? Views { get; set; } 
    }

    public class UtilsStatsCountry
    {
        public int? CountryId { get; set; } 

        public int? Views { get; set; } 
    }

    public class UtilsStatsExtended
    {
        public IEnumerable<object> Cities { get; set; } 

        public IEnumerable<object> Countries { get; set; } 

        public IEnumerable<object> SexAge { get; set; } 

        public int? Timestamp { get; set; } 

        public int? Views { get; set; } 
    }

    public class UtilsStatsSexAge
    {
        public string AgeRange { get; set; } 

        public int? Female { get; set; } 

        public int? Male { get; set; } 
    }
}
