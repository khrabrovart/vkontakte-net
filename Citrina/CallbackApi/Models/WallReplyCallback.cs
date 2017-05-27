namespace Citrina.CallbackApi
{
    public class WallReplyCallback : WallWallComment, ICallbackModel
    {
        public int PostId { get; set; }
    }
}
