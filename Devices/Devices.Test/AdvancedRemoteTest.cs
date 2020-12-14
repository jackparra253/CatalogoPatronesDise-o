using Devices.Domain;
using System.ComponentModel;
using Xunit;

namespace Devices.Test
{
    public class AdvancedRemoteTest
    {
        [Fact, Description("should Mute set Volume in 0")]
        public void AdvancedRemote_Case_Mute()
        {
            IDevice device = new Radio(21, 12);
            var advancedRemoteRadio = new AdvancedRemote(device);

            advancedRemoteRadio.Mute();

            Assert.Equal(0, device.GetVolume());
        }
    }
}
