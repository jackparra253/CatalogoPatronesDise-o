using System.ComponentModel;
using Devices.Domain;
using Xunit;

namespace Devices.Test
{
    public class TVTest
    {
        [Fact, Description("Should TV return new instance")]
        public void TV_Case_NewTV()
        {
            int volume = 5;
            int channel = 10;

            var tv = new TV(volume, channel);

            Assert.False(tv.On);
            Assert.Equal(volume, tv.Volume);
            Assert.Equal(channel, tv.Channel);
        }

        [Fact, Description("Should IsEnabled return On value")]
        public void TV_Case_IsEnabled()
        {
            var tv = new TV(10, 15);

            bool isEnabled = tv.IsEnabled();

            Assert.True(isEnabled);
        }

        [Fact,Description("Should Enable set value on with true")]
        public void TV_Case_Enable()
        {
            var tv = new TV(15, 10);

            tv.Enable();

            Assert.True(tv.On);
        }

        [Fact, Description("Should Disable set value On with false")]
        public void TV_Case_Disable()
        {
            var tv = new TV(45, 25);
            tv.Enable();

            tv.Disable();

            Assert.False(tv.On);
        }

    }
}
