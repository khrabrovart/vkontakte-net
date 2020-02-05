using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class OrdersSubscription
    {
        /// <summary>
        /// Cancel reason.
        /// </summary>
        public string CancelReason { get; set; } 

        /// <summary>
        /// Date of creation in Unixtime.
        /// </summary>
        public int? CreateTime { get; set; } 

        /// <summary>
        /// Subscription ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Subscription order item.
        /// </summary>
        public string ItemId { get; set; } 

        /// <summary>
        /// Date of next bill in Unixtime.
        /// </summary>
        public int? NextBillTime { get; set; } 

        /// <summary>
        /// Pending cancel state.
        /// </summary>
        public bool? PendingCancel { get; set; } 

        /// <summary>
        /// Subscription period.
        /// </summary>
        public int? Period { get; set; } 

        /// <summary>
        /// Date of last period start in Unixtime.
        /// </summary>
        public int? PeriodStartTime { get; set; } 

        /// <summary>
        /// Subscription price.
        /// </summary>
        public int? Price { get; set; } 

        /// <summary>
        /// Subscription status.
        /// </summary>
        public string Status { get; set; } 

        /// <summary>
        /// Is test subscription.
        /// </summary>
        public bool? TestMode { get; set; } 

        /// <summary>
        /// Date of trial expire in Unixtime.
        /// </summary>
        public int? TrialExpireTime { get; set; } 

        /// <summary>
        /// Date of last change in Unixtime.
        /// </summary>
        public int? UpdateTime { get; set; } 
    }
}
