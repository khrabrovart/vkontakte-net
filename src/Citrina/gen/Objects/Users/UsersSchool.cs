using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersSchool
    {
        /// <summary>
        /// City ID.
        /// </summary>
        public int? City { get; set; } 

        /// <summary>
        /// School class letter.
        /// </summary>
        public string Class { get; set; } 

        /// <summary>
        /// Country ID.
        /// </summary>
        public int? Country { get; set; } 

        /// <summary>
        /// School ID.
        /// </summary>
        public string Id { get; set; } 

        /// <summary>
        /// School name.
        /// </summary>
        public string Name { get; set; } 

        /// <summary>
        /// School type ID.
        /// </summary>
        public int? Type { get; set; } 

        /// <summary>
        /// School type name.
        /// </summary>
        public string TypeStr { get; set; } 

        /// <summary>
        /// Year the user started to study.
        /// </summary>
        public int? YearFrom { get; set; } 

        /// <summary>
        /// Graduation year.
        /// </summary>
        public int? YearGraduated { get; set; } 

        /// <summary>
        /// Year the user finished to study.
        /// </summary>
        public int? YearTo { get; set; } 
    }
}
