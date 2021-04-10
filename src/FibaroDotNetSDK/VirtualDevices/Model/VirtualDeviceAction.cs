using System.Linq;
using Newtonsoft.Json;

namespace FibaroDotNetSDK.VirtualDevices.Model
{
    public struct VirtualDeviceAction
    {
        public VirtualDeviceAction(string name, params object[] args)
        {
            Name = name;
            Args = args.Select(s => s.ToString()).ToArray();
        }

        public string Name { get; }

        public string[] Args { get; }
    }
}