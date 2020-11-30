namespace Devices.Domain
{
    public class Radio: Device
    {
        public Radio(int volume, int channel)
        {
            Volume = volume;
            Channel = channel;
            On = false;
        }

        public int Volume { get; private set; }
        public int Channel { get; private set; }
        public bool On { get; private set; }

        public void Disable()
        {
            On = false;
        }

        public void Enable()
        {
            On = true;
        }

        public bool IsEnabled()
        {
            return On;
        }
    }
}