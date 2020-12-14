namespace Devices.Domain
{
    public class Radio: IDevice
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

        public void SetVolume(int volume)
        {
            Volume += volume;
            ValidateLevelVolume();
        }

        private void ValidateLevelVolume()
        {
            if (Volume <= 0)
                Volume = 0;

            if (Volume >= 100)
                Volume = 100;
        }

        public void SetChannel(int channel)
        {
            if (Channel == 100)
                return;

            if (Channel == 1 && channel == -1)
                return;

            Channel += channel;
        }

        public int GetVolume()
        {
            return Volume;
        }

        public int GetChannel()
        {
            return Channel;
        }
    }
}