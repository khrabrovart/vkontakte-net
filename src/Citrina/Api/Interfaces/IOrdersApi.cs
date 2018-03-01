using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    public interface IOrdersApi
    {
        /// <summary>
        /// Returns a list of orders.
        /// </summary>
        Task<ApiRequest<IEnumerable<OrdersOrder>>> Get(UserAccessToken accessToken, int? count = null, bool? testMode = null);
        /// <summary>
        /// Returns information about orders by their IDs.
        /// </summary>
        Task<ApiRequest<IEnumerable<OrdersOrder>>> GetById(UserAccessToken accessToken, int? orderId = null, IEnumerable<int?> orderIds = null, bool? testMode = null);
        /// <summary>
        /// Changes order status.
        /// </summary>
        Task<ApiRequest<string>> ChangeState(UserAccessToken accessToken, int? orderId = null, string action = null, int? appOrderId = null, bool? testMode = null);
        Task<ApiRequest<OrdersAmount>> GetAmount(int? userId = null, IEnumerable<string> votes = null);
    }
}
