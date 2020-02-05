using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public interface IAppWidgetsApi
    {
        /// <summary>
        /// Allows to update community app widget.
        /// </summary>
        Task<ApiRequest<bool?>> UpdateApi(string code = null, string type = null);
    }
}
