using System.Net.Http;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.VirtualDevices
{
    public class GetVirtualDeviceByIdRequest : RequestBase
    {
        public GetVirtualDeviceByIdRequest(int deviceId)
            : base(HttpMethod.Get, $"/virtualDevices/{deviceId}", null)
        {
        }
    }
}
