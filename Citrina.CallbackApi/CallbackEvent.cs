using Newtonsoft.Json;

namespace Citrina.CallbackApi
{
    public class CallbackEvent
    {
        public string Type { get; set; }
        public object Object { get; set; }
        public string Secret { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }
    }
}
