using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class MessagesKeyboardButton
    {
        /// <summary>
        /// Button color.
        /// </summary>
        public enum Color
        {
            [EnumMember(Value = "default")]
            Default,
            [EnumMember(Value = "positive")]
            Positive,
            [EnumMember(Value = "negative")]
            Negative,
            [EnumMember(Value = "primary")]
            Primary,
        }
        public MessagesKeyboardButtonAction Action { get; set; } 
    }
}
