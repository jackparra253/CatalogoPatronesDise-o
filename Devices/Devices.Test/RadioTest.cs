using Devices.Domain;
using System.ComponentModel;
using Xunit;

namespace Devices.Test
{
    public class RadioTest
    {
        [Fact, Description("Should radio new Radio with volume channel and on false")]
        public void Radio_Case_NewRadio()
        {
            int volume = 30;
            int channel = 1;

            var radio = new Radio(volume, channel);

            Assert.Equal(volume, radio.Volume);
            Assert.Equal(channel, radio.Channel);
            Assert.False(radio.On);
        }

        [Fact, Description("Should IsEnabled return On value when radio is enable")]
        public void Radio_Case_On()
        {
            var radio = new Radio(30, 12);

            radio.IsEnabled();

            Assert.False(radio.On);
        }

        [Fact, Description("Should Enable set value on with true")]
        public void Radio_Case_Enable()
        {
            var radio = new Radio(30, 15);

            radio.Enable();

            Assert.True(radio.On);
        }

        [Fact, Description("Should Disable set value On with false")]
        public void Radio_Case_Disable()
        {
            var radio = new Radio(45, 32);
            radio.Enable();

            radio.Disable();

            Assert.False(radio.On);
        }

        [Fact, Description("Should volume if value is minor than or equal to zero return 0")]        
        public void Radio_Case_VolumeMinorEqualZero()
        {
            var radio = new Radio(-3, 32);

            Assert.Equal(0, radio.Volume);
        }

        [Fact, Description("Should volume if value is  greater than or equal or equal to 100 return 100")]
        public void Radio_Case_Volume()
        {
            var tv = new Radio(101, 2);

            Assert.Equal(100, tv.Volume);
        }
    }
}
