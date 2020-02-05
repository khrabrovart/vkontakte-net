using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AppWidgets : IAppWidgets
    {
        /// <summary>
        /// Allows to update community app widget.
        /// </summary>
        public Task<ApiRequest<bool?>> UpdateApi(string code = null, string type = null)
        {
            var request = new Dictionary<string, string>
            {
                ["code"] = code,
                ["type"] = type,
            };

            return RequestManager.CreateRequestAsync<bool?>("appWidgets.update", null, request);
        }
    }
}
