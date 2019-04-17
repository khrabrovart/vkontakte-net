using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class OrdersAmount
    {
        public IEnumerable<object> Amounts { get; set; } 

        public string Currency { get; set; } 
    }

    public class OrdersAmountItem
    {
        public int? Amount { get; set; } 

        public string Description { get; set; } 

        public string Votes { get; set; } 
    }

    public class OrdersOrder
    {
        public int? Amount { get; set; } 

        public int? AppOrderId { get; set; } 

        public int? CancelTransactionId { get; set; } 

        public int? Date { get; set; } 

        public int? Id { get; set; } 

        public string Item { get; set; } 

        public int? ReceiverId { get; set; } 

        public string Status { get; set; } 

        public int? TransactionId { get; set; } 

        public int? UserId { get; set; } 
    }

    public class OrdersSubscription
    {
        public string CancelReason { get; set; } 

        public int? CreateTime { get; set; } 

        public int? Id { get; set; } 

        public string ItemId { get; set; } 

        public int? NextBillTime { get; set; } 

        public bool? PendingCancel { get; set; } 

        public int? Period { get; set; } 

        public int? PeriodStartTime { get; set; } 

        public int? Price { get; set; } 

        public string Status { get; set; } 

        public bool? TestMode { get; set; } 

        public int? TrialExpireTime { get; set; } 

        public int? UpdateTime { get; set; } 
    }
}
