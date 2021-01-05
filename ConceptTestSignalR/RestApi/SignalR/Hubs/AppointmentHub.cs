using Microsoft.AspNet.SignalR;

namespace RestApi.SignalR.Hubs
{
    public class AppointmentHub : Hub
    {
        public void Announce(string message)
        {
            Clients.All.Announce(message);
        }
    }
}