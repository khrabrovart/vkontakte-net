namespace Citrina.CallbackApi
{
    public class GroupLeaveCallback : ICallbackModel
    {
        public int UserId { get; set; }
        public bool Self { get; set; }
    }
}
