using Microsoft.AspNet.SignalR;
using ASP_chat.ChatService;

namespace ASP_chat.Hubs
{
    public class MyHub1 : Hub
    {
        ChatServiceClient ChatServiceClient = new ChatServiceClient();
        // Отправка сообщений
        public void SendMessage(int toUser_ID,string message,int From_User_ID,string toConnection_ID,string fromUserName)
        {
            messages newMessage = ChatServiceClient.SendMessage(toUser_ID, message, From_User_ID);
            Clients.Caller.writeNewMessage(newMessage);
            Clients.Client(toConnection_ID).newMessageFromUser(newMessage, From_User_ID, fromUserName);
        }

        // Подключение нового пользователя
        public void Connect(string userName)
        {
            string connectionId = Context.ConnectionId;
            users user = ChatServiceClient.ClientConnected(userName, connectionId);
            Clients.Others.onConnected(user);
        }

        // Отключение пользователя
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            string connectionId = Context.ConnectionId;
            users user = ChatServiceClient.ClientDisconnected(connectionId);
            Clients.All.onUserDisconnected(user);
            return base.OnDisconnected(stopCalled);
        }
    }
}