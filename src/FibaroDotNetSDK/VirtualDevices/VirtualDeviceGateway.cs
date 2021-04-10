using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibaroDotNetSDK.VirtualDevices.Model;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.VirtualDevices
{
    public class VirtualDeviceGateway : IVirtualDeviceGateway
    {
        private readonly IFibaroClient _client;

        public VirtualDeviceGateway(IFibaroClient client)
        {
            _client = client;
        }

        public Task<ICollection<VirtualDevice>> GetVirtualDevices()
        {
            var request = new GetVirtualDevicesRequest();
            return _client.SendRequest<ICollection<VirtualDevice>>(request);
        }

        public Task<VirtualDevice> GetVirtualDeviceById(int deviceId)
        {
            var request = new GetVirtualDeviceByIdRequest(deviceId);
            return _client.SendRequest<VirtualDevice>(request);
        }

        public Task Call(long id, VirtualDeviceAction action)
        {
            var request = new CallVirtualDeviceActionRequest(id, action);
            return _client.SendRequest(request);
        }
    }
}