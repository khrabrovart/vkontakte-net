namespace Citrina.CallbackApi
{
    public class GroupJoinCallback : ICallbackModel
    {
        public int UserId { get; set; }
        public string JoinType { get; set; }
    }
}
