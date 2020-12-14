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
            IDevice device = new TV(102, 2);
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

        [Fact, Description("should channelUp plus 1")]
        public void BasicRemote_Case_ChannelUp()
        {
            IDevice device = new TV(20, 1);
            var basicRemote = new BasicRemote(device);

            basicRemote.ChannelUp();

            Assert.Equal(2, device.GetChannel());
        }

        [Fact, Description("should channelUp return 100 when channel is 100")]
        public void BasicRemote_Case_ChannelUpChannel100()
        {
            IDevice device = new TV(20, 100);
            var basicRemote = new BasicRemote(device);

            basicRemote.ChannelUp();

            Assert.Equal(100, device.GetChannel());
        }

        [Fact, Description("should ChannelDown subtract 1")]
        public void BasicRemote_Case_ChannelDown()
        {
            IDevice tv = new TV(20, 70);
            var basicRemote = new BasicRemote(tv);

            basicRemote.ChannelDown();

            Assert.Equal(69, tv.GetChannel());
        }

        [Fact, Description("should ChannelDown return 1 when channel is 1")]
        public void BasicRemote_Case_ChannelDownChannel1()
        {
            IDevice tv = new TV(10, 1);
            var basicRemoteTv = new BasicRemote(tv);

            basicRemoteTv.ChannelDown();

            Assert.Equal(1, tv.GetChannel());
        }

    }
}
