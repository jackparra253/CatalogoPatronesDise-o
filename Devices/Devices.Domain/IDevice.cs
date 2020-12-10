namespace Devices.Domain
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        void SetVolume(int volume);
        void SetChannel(int channel);
        int GetVolume();
        int GetChannel();
    }
}
