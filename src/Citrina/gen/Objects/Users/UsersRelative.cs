using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersRelative
    {
        /// <summary>
        /// Relative type.
        /// </summary>
        public enum Type
        {
            [EnumMember(Value = "parent")]
            Parent,
            [EnumMember(Value = "child")]
            Child,
            [EnumMember(Value = "grandparent")]
            Grandparent,
            [EnumMember(Value = "grandchild")]
            Grandchild,
            [EnumMember(Value = "sibling")]
            Sibling,
        }
        /// <summary>
        /// Date of child birthday (format dd.mm.yyyy).
        /// </summary>
        public string BirthDate { get; set; } 

        /// <summary>
        /// Relative ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Name of relative.
        /// </summary>
        public string Name { get; set; } 
    }
}
