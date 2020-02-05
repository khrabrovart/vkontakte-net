using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Description of the action, that should be performed on button click.
    /// </summary>
    public class MessagesKeyboardButtonAction
    {
        /// <summary>
        /// Button type.
        /// </summary>
        public enum Type
        {
            [EnumMember(Value = "text")]
            Text,
            [EnumMember(Value = "start")]
            Start,
            [EnumMember(Value = "location")]
            Location,
            [EnumMember(Value = "vkpay")]
            Vkpay,
            [EnumMember(Value = "open_app")]
            OpenApp,
        }
        /// <summary>
        /// Fragment value in app link like vk.com/app{app_id}_-654321#hash.
        /// </summary>
        public int? AppId { get; set; } 

        /// <summary>
        /// Fragment value in app link like vk.com/app123456_-654321#{hash}.
        /// </summary>
        public string Hash { get; set; } 

        /// <summary>
        /// Label for button.
        /// </summary>
        public string Label { get; set; } 

        /// <summary>
        /// Fragment value in app link like vk.com/app123456_{owner_id}#hash.
        /// </summary>
        public int? OwnerId { get; set; } 

        /// <summary>
        /// Additional data sent along with message for developer convenience.
        /// </summary>
        public string Payload { get; set; } 
    }
}
