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

        [Fact, Description("Should IsEnabled return On value when tv is enable")]
        public void TV_Case_IsEnabled()
        {
            var tv = new TV(10, 15);
            tv.Enable();

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

        [Fact, Description("Should volume if value is minor than or equal to zero return 0")]
        public void Radio_Case_VolumeMinorEqualZero()
        {
            var tv = new TV(-1, 2);

            Assert.Equal(0, tv.Volume);
        }

        [Fact, Description("Should volume if value is  greater than or equal or equal to 100 return 100")]
        public void Radio_Case_Volume()
        {
            var tv = new TV(101, 2);

            Assert.Equal(100, tv.Volume);
        }



    }
}
