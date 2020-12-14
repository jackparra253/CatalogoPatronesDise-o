namespace Devices.Domain
{
    public class TV: IDevice
    {
        private int _volume;

        public TV(int volume, int channel)
        {
            On = false;
            Volume = volume;
            Channel = channel;
        }

        public bool On { get; private set; }

        public int Volume
        {
            get
            {
                return _volume;
            }

            private set
            {
                _volume = ValidateLevelVolume(value);
            }
        }

        private int ValidateLevelVolume(int volume)
        {
            if (volume <= 0)
                return 0;

            if (volume >= 100)
                return 100;

            return volume;
        }

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

        public void SetVolume(int volume)
        {
            if (volume == 0)
            {
                Volume = 0;
                return;
            }

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