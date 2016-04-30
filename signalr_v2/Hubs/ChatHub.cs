using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace signalr_v2
{
    public class ChatHub : Hub
    {
        public void Hello(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
        public void RoleDie(string name, string message)
        {
            Clients.All.broadcastMessage(name, "Du slog 1555");
        }
        public void RoleDie2(string name, string message)
        {
            Clients.All.broadcastMessage(name, "Du slog 1555");
        }

        public override Task OnConnected()
        {            
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {            
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {            
            return base.OnReconnected();
        }
    }
}