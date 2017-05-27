using System;

namespace Citrina.CallbackApi
{
    public class PhotoCommentNewCallback : ICallbackModel
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public int PhotoOwnerId { get; set; }
        public int PhotoId { get; set; }
    }
}
