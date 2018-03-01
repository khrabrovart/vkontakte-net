using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina.Methods.Categories
{
    internal class OrdersApi : IOrdersApi
    {
        public Task<ApiRequest<IEnumerable<OrdersOrder>>> Get(UserAccessToken accessToken, int? count = null, bool? testMode = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["count"] = count?.ToString(),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<OrdersOrder>>("orders.get", accessToken, request);
        }

        public Task<ApiRequest<IEnumerable<OrdersOrder>>> GetById(UserAccessToken accessToken, int? orderId = null, IEnumerable<int?> orderIds = null, bool? testMode = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["order_id"] = orderId?.ToString(),
                ["order_ids"] = RequestHelpers.ParseEnumerable(orderIds),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
            };

            return RequestManager.CreateRequestAsync<IEnumerable<OrdersOrder>>("orders.getById", accessToken, request);
        }

        public Task<ApiRequest<string>> ChangeState(UserAccessToken accessToken, int? orderId = null, string action = null, int? appOrderId = null, bool? testMode = null)
        {
            var request = new Dictionary<string, string>
            {
                ["access_token"] = accessToken?.Value,
                ["order_id"] = orderId?.ToString(),
                ["action"] = action,
                ["app_order_id"] = appOrderId?.ToString(),
                ["test_mode"] = RequestHelpers.ParseBoolean(testMode),
            };

            return RequestManager.CreateRequestAsync<string>("orders.changeState", accessToken, request);
        }

        public Task<ApiRequest<OrdersAmount>> GetAmount(int? userId = null, IEnumerable<string> votes = null)
        {
            var request = new Dictionary<string, string>
            {
                ["user_id"] = userId?.ToString(),
                ["votes"] = RequestHelpers.ParseEnumerable(votes),
            };

            return RequestManager.CreateRequestAsync<OrdersAmount>("orders.getAmount", null, request);
        }

    }
}
