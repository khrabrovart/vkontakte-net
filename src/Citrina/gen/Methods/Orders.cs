using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class Orders : IOrders
    {
        public Task<ApiRequest<bool?>> CancelSubscriptionApi(int? userId = null, int? subscriptionId = null, bool? pendingCancel = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["subscription_id"] = subscriptionId?.ToString(),
                ["pending_cancel"] = RequestHelpers.ParseBoolean(pendingCancel),
            };

            return RequestManager.CreateRequestAsync<bool?>("orders.cancelSubscription", null, request);
        }

        /// <summary>
        /// Changes order status.
        /// </summary>
        public Task<ApiRequest<string>> ChangeStateApi(int? orderId = null, string action = null, int? appOrderId = null, bool? testMode = null)
        {
            var request = new Dictionary<string, string>
            {
                ["order_id"] = orderId?.ToString(),
                ["action"] = action,
                ["app_order_id"] = appOrderId?.ToString(),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
            };

            return RequestManager.CreateRequestAsync<string>("orders.changeState", null, request);
        }

        /// <summary>
        /// Returns a list of orders.
        /// </summary>
        public Task<ApiRequest<IEnumerable<OrdersOrder>>> GetApi(int? offset = null, int? count = null, bool? testMode = null)
        {
            var request = new Dictionary<string, string>
            {
                ["offset"] = offset?.ToString(),
                ["count"] = count?.ToString(),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<OrdersOrder>>("orders.get", null, request);
        }

        public Task<ApiRequest<OrdersAmount>> GetAmountApi(int? userId = null, IEnumerable<string> votes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["votes"] = RequestHelpers.ParseEnumerable(votes),
            };

            return RequestManager.CreateRequestAsync<OrdersAmount>("orders.getAmount", null, request);
        }

        /// <summary>
        /// Returns information about orders by their IDs.
        /// </summary>
        public Task<ApiRequest<IEnumerable<OrdersOrder>>> GetByIdApi(int? orderId = null, IEnumerable<int> orderIds = null, bool? testMode = null)
        {
            var request = new Dictionary<string, string>
            {
                ["order_id"] = orderId?.ToString(),
                ["order_ids"] = RequestHelpers.ParseEnumerable(orderIds),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<OrdersOrder>>("orders.getById", null, request);
        }

        public Task<ApiRequest<OrdersSubscription>> GetUserSubscriptionByIdApi(int? userId = null, int? subscriptionId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["subscription_id"] = subscriptionId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<OrdersSubscription>("orders.getUserSubscriptionById", null, request);
        }

        public Task<ApiRequest<OrdersGetUserSubscriptionsResponse>> GetUserSubscriptionsApi(int? userId = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
            };

            return RequestManager.CreateRequestAsync<OrdersGetUserSubscriptionsResponse>("orders.getUserSubscriptions", null, request);
        }

        public Task<ApiRequest<bool?>> UpdateSubscriptionApi(int? userId = null, int? subscriptionId = null, int? price = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["subscription_id"] = subscriptionId?.ToString(),
                ["price"] = price?.ToString(),
            };

            return RequestManager.CreateRequestAsync<bool?>("orders.updateSubscription", null, request);
        }
    }
}
