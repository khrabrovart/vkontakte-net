using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsAddress
    {
        /// <summary>
        /// Additional address to the place (6 floor, left door).
        /// </summary>
        public string AdditionalAddress { get; set; } 

        /// <summary>
        /// String address to the place (Nevsky, 28).
        /// </summary>
        public string Address { get; set; } 

        /// <summary>
        /// City id of address.
        /// </summary>
        public int? CityId { get; set; } 

        /// <summary>
        /// Country id of address.
        /// </summary>
        public int? CountryId { get; set; } 

        /// <summary>
        /// Distance from the point.
        /// </summary>
        public int? Distance { get; set; } 

        /// <summary>
        /// Address id.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Address latitude.
        /// </summary>
        public double? Latitude { get; set; } 

        /// <summary>
        /// Address longitude.
        /// </summary>
        public double? Longitude { get; set; } 

        /// <summary>
        /// Metro id of address.
        /// </summary>
        public int? MetroStationId { get; set; } 

        /// <summary>
        /// Address phone.
        /// </summary>
        public string Phone { get; set; } 

        /// <summary>
        /// Time offset int minutes from utc time.
        /// </summary>
        public int? TimeOffset { get; set; } 

        /// <summary>
        /// Week timetable for the address.
        /// </summary>
        public GroupsAddressTimetable Timetable { get; set; } 

        /// <summary>
        /// Title of the place (Zinger, etc).
        /// </summary>
        public string Title { get; set; } 

        /// <summary>
        /// Status of information about timetable.
        /// </summary>
        public string WorkInfoStatus { get; set; } 
    }
}
