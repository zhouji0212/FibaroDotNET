using Newtonsoft.Json;

namespace FibaroDotNetSDK.VirtualDevices
{
    public struct ArgsParam
    {
        [JsonProperty("args")]
        public string[] Args { get; }

        public ArgsParam(string[] args)
        {
            Args = args;
        }
    }
}