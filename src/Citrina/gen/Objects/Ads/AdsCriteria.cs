using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AdsCriteria
    {
        /// <summary>
        /// Age from.
        /// </summary>
        public int? AgeFrom { get; set; } 

        /// <summary>
        /// Age to.
        /// </summary>
        public int? AgeTo { get; set; } 

        /// <summary>
        /// Apps IDs.
        /// </summary>
        public string Apps { get; set; } 

        /// <summary>
        /// Apps IDs to except.
        /// </summary>
        public string AppsNot { get; set; } 

        /// <summary>
        /// Days to birthday.
        /// </summary>
        public int? Birthday { get; set; } 

        /// <summary>
        /// Cities IDs.
        /// </summary>
        public string Cities { get; set; } 

        /// <summary>
        /// Cities IDs to except.
        /// </summary>
        public string CitiesNot { get; set; } 

        /// <summary>
        /// Country ID.
        /// </summary>
        public int? Country { get; set; } 

        /// <summary>
        /// Districts IDs.
        /// </summary>
        public string Districts { get; set; } 

        /// <summary>
        /// Communities IDs.
        /// </summary>
        public string Groups { get; set; } 

        /// <summary>
        /// Interests categories IDs.
        /// </summary>
        public string InterestCategories { get; set; } 

        /// <summary>
        /// Interests.
        /// </summary>
        public string Interests { get; set; } 

        /// <summary>
        /// Information whether the user has proceeded VK payments before.
        /// </summary>
        public bool? Paying { get; set; } 

        /// <summary>
        /// Positions IDs.
        /// </summary>
        public string Positions { get; set; } 

        /// <summary>
        /// Religions IDs.
        /// </summary>
        public string Religions { get; set; } 

        /// <summary>
        /// Retargeting groups IDs.
        /// </summary>
        public string RetargetingGroups { get; set; } 

        /// <summary>
        /// Retargeting groups IDs to except.
        /// </summary>
        public string RetargetingGroupsNot { get; set; } 

        /// <summary>
        /// School graduation year from.
        /// </summary>
        public int? SchoolFrom { get; set; } 

        /// <summary>
        /// School graduation year to.
        /// </summary>
        public int? SchoolTo { get; set; } 

        /// <summary>
        /// Schools IDs.
        /// </summary>
        public string Schools { get; set; } 

        public int? Sex { get; set; } 

        /// <summary>
        /// Stations IDs.
        /// </summary>
        public string Stations { get; set; } 

        /// <summary>
        /// Relationship statuses.
        /// </summary>
        public string Statuses { get; set; } 

        /// <summary>
        /// Streets IDs.
        /// </summary>
        public string Streets { get; set; } 

        /// <summary>
        /// Travellers only.
        /// </summary>
        public int? Travellers { get; set; } 

        /// <summary>
        /// University graduation year from.
        /// </summary>
        public int? UniFrom { get; set; } 

        /// <summary>
        /// University graduation year to.
        /// </summary>
        public int? UniTo { get; set; } 

        /// <summary>
        /// Browsers.
        /// </summary>
        public string UserBrowsers { get; set; } 

        /// <summary>
        /// Devices.
        /// </summary>
        public string UserDevices { get; set; } 

        /// <summary>
        /// Operating systems.
        /// </summary>
        public string UserOs { get; set; } 
    }
}
