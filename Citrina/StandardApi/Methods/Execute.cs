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
        public Task<ApiCall<ExecuteRequest, TResponse>> Call<TResponse>(string method, ExecuteRequest request)
        {
            return RequestManager.CreateRequestAsync<ExecuteRequest, TResponse>(method, request, true);
        }
    }
}