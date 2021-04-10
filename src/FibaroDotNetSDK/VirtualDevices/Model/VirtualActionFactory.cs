namespace FibaroDotNetSDK.VirtualDevices.Model
{
    public static class VirtualActionFactory
    {
        public static VirtualDeviceAction PressButton(int id) => new VirtualDeviceAction("pressButton", id);
        public static VirtualDeviceAction SetSlider(int id,int value) => new VirtualDeviceAction("setSlider",id,value);
        public static VirtualDeviceAction SetProperty(int id,string value) => new VirtualDeviceAction("setProperty",id,value);
    }
}