namespace Citrina.CallbackApi
{
    public class BoardPostDeleteCallback : ICallbackModel
    {
        public int TopicId { get; set; }
        public int Id { get; set; }
    }
}
