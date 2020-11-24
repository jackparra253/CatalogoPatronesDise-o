namespace Devices.Domain
{
    public interface Device
    {
        bool IsEnabled();
        void Enable();

        void Disable();
    }
}
