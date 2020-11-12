using System;

namespace Devices.Domain
{
    public class TV
    {
        private int _volume;

        public TV(int volume, int channel)
        {
            On = false;
            Volume = volume;
            Channel = channel;
        }

        private int ValidateLevelVolume(int volume)
        {
            if (volume <= 0)
                return 0;

            if (volume >= 100)
                return 100;

            return volume;
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