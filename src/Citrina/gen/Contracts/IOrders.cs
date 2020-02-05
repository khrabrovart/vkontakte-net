using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IOrdersApi
    {
        Task<ApiRequest<bool?>> CancelSubscriptionApi(int? userId = null, int? subscriptionId = null, bool? pendingCancel = null);

        /// <summary>
        /// Changes order status.
        /// </summary>
        Task<ApiRequest<string>> ChangeStateApi(int? orderId = null, string action = null, int? appOrderId = null, bool? testMode = null);

        /// <summary>
        /// Returns a list of orders.
        /// </summary>
        Task<ApiRequest<IEnumerable<OrdersOrder>>> GetApi(int? offset = null, int? count = null, bool? testMode = null);

        Task<ApiRequest<OrdersAmount>> GetAmountApi(int? userId = null, IEnumerable<string> votes = null);

        /// <summary>
        /// Returns information about orders by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<OrdersOrder>>> GetByIdApi(int? orderId = null, IEnumerable<int> orderIds = null, bool? testMode = null);

        Task<ApiRequest<OrdersSubscription>> GetUserSubscriptionByIdApi(int? userId = null, int? subscriptionId = null);

        Task<ApiRequest<OrdersGetUserSubscriptionsResponse>> GetUserSubscriptionsApi(int? userId = null);

        Task<ApiRequest<bool?>> UpdateSubscriptionApi(int? userId = null, int? subscriptionId = null, int? price = null);
    }
}
