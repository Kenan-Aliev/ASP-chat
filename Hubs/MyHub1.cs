using Microsoft.AspNet.SignalR;
using System.ServiceModel;
using System.Configuration;
using WcfService1;
using WcfService1.ChatUOW.Entities;

namespace ASP_chat.Hubs
{
    public class MyHub1 : Hub
    {
        
        static BasicHttpBinding binding = new BasicHttpBinding();

        // chat channel
        static string chatUrl = ConfigurationManager.AppSettings["ChatService"];
        static EndpointAddress chatAddress = new EndpointAddress(chatUrl);
        static ChannelFactory<IChatService> chatFactory = new ChannelFactory<IChatService>(binding, chatAddress);
        IChatService chatChannel = chatFactory.CreateChannel();

        // groups channel
        static string groupUrl = ConfigurationManager.AppSettings["GroupsService"];
        static EndpointAddress groupsAddress = new EndpointAddress(groupUrl);
        static ChannelFactory<IGroups> groupsFactory = new ChannelFactory<IGroups>(binding, groupsAddress);
        IGroups groupsChannel = groupsFactory.CreateChannel();

        //ChatServiceClient ChatServiceClient = new ChatServiceClient();
        //GroupsClient GroupsClient = new GroupsClient();
        // Отправка сообщений
        public void SendMessage(int toUser_ID,string message,int From_User_ID,string toConnection_ID,string fromUserName)
        {
            Messages newMessage = chatChannel.SendMessage(toUser_ID, message, From_User_ID);
            Clients.Caller.writeNewMessage(newMessage);
            Clients.Client(toConnection_ID).newMessageFromUser(newMessage, From_User_ID, fromUserName);
        }

        // Подключение нового пользователя
        public void Connect(string userName)
        {
            string connectionId = Context.ConnectionId;
            User user = chatChannel.ClientConnected(userName, connectionId);
            Clients.Others.onConnected(user);
        }

        // Отключение пользователя
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            string connectionId = Context.ConnectionId;
            User user = chatChannel.ClientDisconnected(connectionId);
            Clients.All.onUserDisconnected(user);
            return base.OnDisconnected(stopCalled);
        }

        public void ConnectToGroup(string groupName) 
        {
            string connectionID = Context.ConnectionId;
            Groups.Add(connectionID, groupName);
        }

        public void SendGroupMessage(string message, string groupName,int groupId,int fromUserID) 
        {
            Messages newMessage = groupsChannel.SendMessage(groupId, fromUserID, message);
            Clients.Group(groupName).sendGroupMessage(newMessage,groupId,groupName);
        }
        
        public void AddNewMemberToGroup(string groupName,int groupId,User newUser)
        {
            Groups.Add(newUser.Connection_Id, groupName);
            Clients.Client(newUser.Connection_Id).addedToNewGroup(new { Group_ID = groupId , Group_Name = groupName });
            Clients.Group(groupName, newUser.Connection_Id, Context.ConnectionId).addedNewMember(newUser, groupId,groupName);
        }
    }
}