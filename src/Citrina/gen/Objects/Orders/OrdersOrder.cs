using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class OrdersOrder
    {
        /// <summary>
        /// Amount.
        /// </summary>
        public int? Amount { get; set; } 

        /// <summary>
        /// App order ID.
        /// </summary>
        public int? AppOrderId { get; set; } 

        /// <summary>
        /// Cancel transaction ID.
        /// </summary>
        public int? CancelTransactionId { get; set; } 

        /// <summary>
        /// Date of creation in Unixtime.
        /// </summary>
        public int? Date { get; set; } 

        /// <summary>
        /// Order ID.
        /// </summary>
        public int? Id { get; set; } 

        /// <summary>
        /// Order item.
        /// </summary>
        public string Item { get; set; } 

        /// <summary>
        /// Receiver ID.
        /// </summary>
        public int? ReceiverId { get; set; } 

        /// <summary>
        /// Order status.
        /// </summary>
        public string Status { get; set; } 

        /// <summary>
        /// Transaction ID.
        /// </summary>
        public int? TransactionId { get; set; } 

        /// <summary>
        /// User ID.
        /// </summary>
        public int? UserId { get; set; } 
    }
}
