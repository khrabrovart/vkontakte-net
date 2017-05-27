namespace Citrina.CallbackApi
{
    public class MessageAllowCallback : ICallbackModel
    {
        public int UserId { get; set; }
        public string Key { get; set; }
    }
}
