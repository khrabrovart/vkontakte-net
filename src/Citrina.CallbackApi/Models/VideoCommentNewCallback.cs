using System;

namespace Citrina.CallbackApi
{
    public class VideoCommentNewCallback : ICallbackModel
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public int VideoOwnerId { get; set; }
        public int VideoId { get; set; }
    }
}
