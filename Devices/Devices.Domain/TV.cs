namespace Devices.Domain
{
    public class TV
    {
        public TV(int volume, int channel)
        {
            On = false;
            Volume = volume;
            Channel = channel;
        }

        public bool On { get; private set; }
        public int Volume { get; private set; }
        public int Channel { get; private set; }

        public bool IsEnabled()
        {
            return On;
        }

        public void Enable()
        {
            On = true;
        }

        public void Disable()
        {
            On = false;
        }
    }
}