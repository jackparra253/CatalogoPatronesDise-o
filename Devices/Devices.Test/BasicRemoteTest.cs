using Devices.Domain;
using System.ComponentModel;
using Xunit;

namespace Devices.Test
{
    public class BasicRemoteTest
    {
        [Fact, Description("should Power IsEnbled in true for device.")]
        public void BasicRemote_Case_Power()
        {
            IDevice device = new TV(102,2);
            var basicRemote = new BasicRemote(device);
            
            basicRemote.Power();

            Assert.True(device.IsEnabled());
        }     
        
        [Fact, Description("should VolumeUp plus 10")]
        public void BasicRemote_Case_VolumeUp()
        {
            IDevice device = new TV(95, 11);
            var basicRemote = new BasicRemote(device);

            basicRemote.VolumeUp();

            Assert.Equal(100, device.GetVolume());
        }

        [Fact, Description("should VolumeDown subtract 10")]
        public void BasicRemote_Case_VolumeDown()
        {
            IDevice device = new TV(20, 11);
            var basicRemote = new BasicRemote(device);

            basicRemote.VolumeDown();

            Assert.Equal(10, device.GetVolume());
        }
    }
}
