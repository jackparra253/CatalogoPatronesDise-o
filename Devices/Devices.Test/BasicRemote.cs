using Devices.Domain;
using System;

namespace Devices.Test
{
    public class BasicRemote
    {
        private IDevice _device;

        public BasicRemote(IDevice device)
        {
            _device = device;
        }

        public void Power()
        {
            _device.Enable();
        }

        public void VolumeDown()
        {
            _device.SetVolume(-10);
        }

        public void VolumeUp()
        {
            _device.SetVolume(10);
        }

        public void ChannelUp()
        {
            _device.SetChannel(1);
        }

        public void ChannelDown()
        {
            _device.SetChannel(-1);
        }
    }
}