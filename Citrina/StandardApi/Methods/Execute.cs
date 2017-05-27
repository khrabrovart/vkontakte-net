using System.Threading.Tasks;
using Citrina.StandardApi.Core;
using Citrina.StandardApi.Models;

namespace Citrina.StandardApi
{
    public interface IExecuteApi
    {
        Task<ApiCall<ExecuteRequest, TResponse>> Call<TResponse>(string method, ExecuteRequest request);
    }

    internal class ExecuteApi : IExecuteApi
    {
        public async Task<ApiCall<ExecuteRequest, TResponse>> Call<TResponse>(string method, ExecuteRequest request)
        {
            return await RequestManager.CreateRequestAsync<ExecuteRequest, TResponse>(method, request, true).ConfigureAwait(false);
        }
    }
}