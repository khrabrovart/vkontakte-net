using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citrina
{
    internal class ExecuteApi : IExecuteApi
    {
        public Task<ApiRequest<TResponse>> Call<TResponse>(string method, IAccessToken accessToken, Dictionary<string, string> parameters)
        {
            return RequestManager.CreateExecuteRequestAsync<TResponse>(method, accessToken, parameters);
        }
    }
}