using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_chat.Models;
using ASP_chat.ChatService;

namespace ASP_chat.Hubs
{
    public class MyHub1 : Hub
    {
        ChatServiceClient ChatServiceClient = new ChatServiceClient();
        public static List<User> Users = new List<User>();
        // Отправка сообщений
        public void SendMessage(string toConnectionID,string message,string username)
        {
            Clients.Client(toConnectionID).addMessage(message,username);
        }

        // Подключение нового пользователя
        public void Connect(string userName)
        {
            string connectionId = Context.ConnectionId;
            users user = ChatServiceClient.ClientConnected(userName, connectionId);
            Clients.All.onConnected(user);
            //var id = Context.ConnectionId;


            //if (!Users.Any(x => x.Connection_Id == id))
            //{
            //    Users.Add(new User { Connection_Id = id, UserName = userName });

            //    // Посылаем сообщение текущему пользователю
            //    Clients.Caller.onConnected(id, userName, Users);

            //    // Посылаем сообщение всем пользователям, кроме текущего
            //    Clients.AllExcept(id).onNewUserConnected(id, userName);
            //}
        }

        // Отключение пользователя
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            var item = Users.FirstOrDefault(x => x.Connection_Id == Context.ConnectionId);
            if (item != null)
            {
                Users.Remove(item);
                var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.UserName);
            }

            return base.OnDisconnected(stopCalled);
        }
    }
}