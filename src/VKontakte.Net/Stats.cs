using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class StatsActivity
    {
        public int? Comments { get; set; } 

        public int? Copies { get; set; } 

        public int? Hidden { get; set; } 

        public int? Likes { get; set; } 

        public int? Subscribed { get; set; } 

        public int? Unsubscribed { get; set; } 
    }

    public class StatsCity
    {
        public int? Count { get; set; } 

        public string Name { get; set; } 

        public int? Value { get; set; } 
    }

    public class StatsCountry
    {
        public string Code { get; set; } 

        public int? Count { get; set; } 

        public string Name { get; set; } 

        public int? Value { get; set; } 
    }

    public class StatsPeriod
    {
        public StatsActivity Activity { get; set; } 

        public int? PeriodFrom { get; set; } 

        public int? PeriodTo { get; set; } 

        public StatsReach Reach { get; set; } 

        public StatsViews Visitors { get; set; } 
    }

    public class StatsReach
    {
        public IEnumerable<object> Age { get; set; } 

        public IEnumerable<object> Cities { get; set; } 

        public IEnumerable<object> Countries { get; set; } 

        public int? MobileReach { get; set; } 

        public int? Reach { get; set; } 

        public int? ReachSubscribers { get; set; } 

        public IEnumerable<object> Sex { get; set; } 

        public IEnumerable<object> SexAge { get; set; } 
    }

    public class StatsSexAge
    {
        public int? Count { get; set; } 

        public string Value { get; set; } 
    }

    public class StatsViews
    {
        public IEnumerable<object> Age { get; set; } 

        public IEnumerable<object> Cities { get; set; } 

        public IEnumerable<object> Countries { get; set; } 

        public int? MobileViews { get; set; } 

        public IEnumerable<object> Sex { get; set; } 

        public IEnumerable<object> SexAge { get; set; } 

        public int? Views { get; set; } 

        public int? Visitors { get; set; } 
    }

    public class StatsWallpostStat
    {
        public int? Hide { get; set; } 

        public int? JoinGroup { get; set; } 

        public int? Links { get; set; } 

        public int? ReachSubscribers { get; set; } 

        public int? ReachTotal { get; set; } 

        public int? Report { get; set; } 

        public int? ToGroup { get; set; } 

        public int? Unsubscribe { get; set; } 
    }
}
