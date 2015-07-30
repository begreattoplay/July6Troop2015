using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace JSDay3SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            //Context.User.Identity
            //var id = Context.ConnectionId;
            //Clients.All.PeanutButter(message);
            Clients.All.SendMessage(message);
        }

        public void Hello()
        {
            Clients.All.hello();
        }
    }
}