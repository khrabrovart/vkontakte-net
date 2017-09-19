using System.Collections.Generic;
using System.Net.Http;

namespace Citrina.CallbackApi
{
    public interface ICallbackEventHandler
    {
        CallbackEventType GetEventType(CallbackEvent e);
        T GetEventObject<T>(CallbackEvent e) where T : ICallbackModel;
        HttpResponseMessage GetEventResponse(string confirmationCode, CallbackEvent e);
        HttpResponseMessage GetEventResponse(Dictionary<int, string> communityToCodesMap, CallbackEvent e);
    }
}
