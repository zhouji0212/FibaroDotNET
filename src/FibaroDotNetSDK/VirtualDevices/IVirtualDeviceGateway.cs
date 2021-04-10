using System.Collections.Generic;
using System.Threading.Tasks;
using FibaroDotNetSDK.VirtualDevices.Model;
using System.Linq;

namespace FibaroDotNetSDK.VirtualDevices
{
    public interface IVirtualDeviceGateway
    {
        Task<ICollection<VirtualDevice>> GetVirtualDevices();
        Task<VirtualDevice> GetVirtualDeviceById(int deviceId);

        Task Call(long id, VirtualDeviceAction action);
    }
}
