namespace Devices.Domain
{
    public class Radio: Device
    {
        private int _volume;

        public Radio(int volume, int channel)
        {
            Volume = volume;
            Channel = channel;
            On = false;
        }

        public int Volume
        {
            get
            {
                return _volume;
            }
            private set
            {
                _volume = ValidateVolume(value);
            }
        }

        private int ValidateVolume(int volume)
        {
            if (volume <= 0)
                return 0;            

            if (volume > 100)
                return 100;            

            return volume;
        }

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