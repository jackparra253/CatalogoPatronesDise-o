using System.ComponentModel;
using Xunit;

namespace Devices.Test
{
    public class RadioTest
    {
        [Fact, Description("shoul Radio new Radio with volume channel and on false")]
        public void Radio_Case_NewRadio()
        {
            int volume = 30;
            int channel = 1;

            var radio = new Radio(volume, channel);

            Assert.Equal(volume, radio.Volume);
            Assert.Equal(channel, radio.Channel);
            Assert.False(radio.On);
        }
    }
}
