using System.Collections.Generic;

namespace Citrina.StandardApi.Models
{
    public class ExecuteRequest : RequestModelBase
    {
        public ExecuteRequest(IAccessToken token, Dictionary<string, object> parameters)
        {
            AccessToken = token;
            Parameters = PrepareParameters(parameters);
        }

        public Dictionary<string, string> Parameters { get; }

        private Dictionary<string, string> PrepareParameters(Dictionary<string, object> parameters)
        {
            var stringDictionary = new Dictionary<string, string>
            {
                ["access_token"] = AccessToken.Value,
            };

            foreach (var parameter in parameters)
            {
                switch (parameter.Key)
                {
                    case "access_token":
                        stringDictionary["access_token"] = parameter.Value.ToString();
                        break;
                    default:
                        stringDictionary.Add(parameter.Key, parameter.Value.ToString());
                        break;
                }
            }

            return stringDictionary;
        }
    }
}