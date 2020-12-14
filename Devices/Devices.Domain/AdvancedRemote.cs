using System;

namespace Devices.Domain
{
    public class AdvancedRemote
    {
        private IDevice _device;

        public AdvancedRemote(IDevice device)
        {
            _device = device;
        }

        public void Mute()
        {
            _device.SetVolume(0);
        }
    }
}