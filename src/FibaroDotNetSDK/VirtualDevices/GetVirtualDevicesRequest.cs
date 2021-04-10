using System.Net.Http;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.VirtualDevices
{
    public class GetVirtualDevicesRequest : RequestBase
    {
        public GetVirtualDevicesRequest() 
            : base(HttpMethod.Get, "/virtualDevices", null)
        {
        }
    }
}