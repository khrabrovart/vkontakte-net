using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersUserMin
    {
        /// <summary>
        /// Returns if a profile is deleted or blocked.
        /// </summary>
        public string Deactivated { get; set; } 

        /// <summary>
        /// User first name.
        /// </summary>
        public string FirstName { get; set; } 

        /// <summary>
        /// Returns if a profile is hidden.
        /// </summary>
        public int? Hidden { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// User last name.
        /// </summary>
        public string LastName { get; set; } 

        public bool? CanAccessClosed { get; set; } 

        public bool? IsClosed { get; set; } 
    }
}
