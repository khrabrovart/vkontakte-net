using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class UsersCropPhotoCrop
    {
        /// <summary>
        /// Coordinate X of the left upper corner.
        /// </summary>
        public double? X { get; set; } 

        /// <summary>
        /// Coordinate X of the right lower corner.
        /// </summary>
        public double? X2 { get; set; } 

        /// <summary>
        /// Coordinate Y of the left upper corner.
        /// </summary>
        public double? Y { get; set; } 

        /// <summary>
        /// Coordinate Y of the right lower corner.
        /// </summary>
        public double? Y2 { get; set; } 
    }
}
