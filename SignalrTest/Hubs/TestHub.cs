using Microsoft.AspNetCore.SignalR;

namespace SignalrTest.Hubs
{
    public class TestHub : Hub
    {
        public async Task OnNotificationsUpdate()
        {
            await Clients.All.SendAsync("OnNotificationsUpdate");
        }
    }
}
