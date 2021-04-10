using System.Net;
using System.Net.Http;
using FibaroDotNetSDK.VirtualDevices.Model;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.VirtualDevices
{
    public class CallVirtualDeviceActionRequest : RequestBase
    {
        public CallVirtualDeviceActionRequest(long id, VirtualDeviceAction action)
            : base(HttpMethod.Post, $"/virtualDevices/{id}/action/{action.Name}", new ArgsParam(action.Args), HttpStatusCode.Accepted)
        {
        }
    }
}