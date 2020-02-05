using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersUniversity
    {
        /// <summary>
        /// Chair ID.
        /// </summary>
        public int? Chair { get; set; } 

        /// <summary>
        /// Chair name.
        /// </summary>
        public string ChairName { get; set; } 

        /// <summary>
        /// City ID.
        /// </summary>
        public int? City { get; set; } 

        /// <summary>
        /// Country ID.
        /// </summary>
        public int? Country { get; set; } 

        /// <summary>
        /// Education form.
        /// </summary>
        public string EducationForm { get; set; } 

        /// <summary>
        /// Education status.
        /// </summary>
        public string EducationStatus { get; set; } 

        /// <summary>
        /// Faculty ID.
        /// </summary>
        public int? Faculty { get; set; } 

        /// <summary>
        /// Faculty name.
        /// </summary>
        public string FacultyName { get; set; } 

        /// <summary>
        /// Graduation year.
        /// </summary>
        public int? Graduation { get; set; } 

        /// <summary>
        /// University ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// University name.
        /// </summary>
        public string Name { get; set; } 
    }
}
