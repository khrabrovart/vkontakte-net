
namespace VKontakte.Net.Models
{
    public class LeadsChecked
    {
        public string Reason { get; set; } 

        public LeadsCheckedResult Result { get; set; } 

        public string Sid { get; set; } 

        public string StartLink { get; set; } 
    }

    public class LeadsCheckedResult
    {
    }

    public class LeadsComplete
    {
        public int? Cost { get; set; } 

        public int? Limit { get; set; } 

        public int? Spent { get; set; } 

        public bool? Success { get; set; } 

        public bool? TestMode { get; set; } 
    }

    public class LeadsEntry
    {
        public int? Aid { get; set; } 

        public string Comment { get; set; } 

        public int? Date { get; set; } 

        public string Sid { get; set; } 

        public int? StartDate { get; set; } 

        public int? Status { get; set; } 

        public bool? TestMode { get; set; } 

        public int? Uid { get; set; } 
    }

    public class LeadsLead
    {
        public int? Completed { get; set; } 

        public int? Cost { get; set; } 

        public LeadsLeadDays Days { get; set; } 

        public int? Impressions { get; set; } 

        public int? Limit { get; set; } 

        public int? Spent { get; set; } 

        public int? Started { get; set; } 
    }

    public class LeadsLeadDays
    {
        public int? Completed { get; set; } 

        public int? Impressions { get; set; } 

        public int? Spent { get; set; } 

        public int? Started { get; set; } 
    }

    public class LeadsStart
    {
        public bool? TestMode { get; set; } 

        public string VkSid { get; set; } 
    }
}
