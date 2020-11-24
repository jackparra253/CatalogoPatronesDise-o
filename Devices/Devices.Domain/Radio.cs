namespace Devices.Test
{
    public class Radio
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
    }
}