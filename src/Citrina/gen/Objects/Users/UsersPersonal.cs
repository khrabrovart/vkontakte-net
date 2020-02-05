using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersPersonal
    {
        /// <summary>
        /// User's views on alcohol.
        /// </summary>
        public int? Alcohol { get; set; } 

        /// <summary>
        /// User's inspired by.
        /// </summary>
        public string InspiredBy { get; set; } 

        public IEnumerable<string> Langs { get; set; } 

        /// <summary>
        /// User's personal priority in life.
        /// </summary>
        public int? LifeMain { get; set; } 

        /// <summary>
        /// User's personal priority in people.
        /// </summary>
        public int? PeopleMain { get; set; } 

        /// <summary>
        /// User's political views.
        /// </summary>
        public int? Political { get; set; } 

        /// <summary>
        /// User's religion.
        /// </summary>
        public string Religion { get; set; } 

        /// <summary>
        /// User's religion id.
        /// </summary>
        public int? ReligionId { get; set; } 

        /// <summary>
        /// User's views on smoking.
        /// </summary>
        public int? Smoking { get; set; } 
    }
}
