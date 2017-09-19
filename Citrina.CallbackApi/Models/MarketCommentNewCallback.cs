using System;

namespace Citrina.CallbackApi
{
    public class MarketCommentNewCallback : ICallbackModel
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public int MarketOwnerId { get; set; }
        public int ItemId { get; set; }
    }
}
