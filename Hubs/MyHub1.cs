using Microsoft.AspNet.SignalR;
using ASP_chat.ChatService;
using ASP_chat.GroupsService;
using System.ServiceModel;

namespace ASP_chat.Hubs
{
    public class MyHub1 : Hub
    {
        ChatServiceClient ChatServiceClient = new ChatServiceClient();
        GroupsClient GroupsClient = new GroupsClient();
        // Отправка сообщений
        public void SendMessage(int toUser_ID,string message,int From_User_ID,string toConnection_ID,string fromUserName)
        {
            ChatService.messages newMessage = ChatServiceClient.SendMessage(toUser_ID, message, From_User_ID);
            Clients.Caller.writeNewMessage(newMessage);
            Clients.Client(toConnection_ID).newMessageFromUser(newMessage, From_User_ID, fromUserName);
        }

        // Подключение нового пользователя
        public void Connect(string userName)
        {
            string connectionId = Context.ConnectionId;
            ChatService.users user = ChatServiceClient.ClientConnected(userName, connectionId);
            Clients.Others.onConnected(user);
        }

        // Отключение пользователя
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            string connectionId = Context.ConnectionId;
            ChatService.users user = ChatServiceClient.ClientDisconnected(connectionId);
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
            GroupsService.messages newMessage = GroupsClient.SendMessage(groupId, fromUserID, message);
            Clients.Group(groupName).sendGroupMessage(newMessage,groupId,groupName,fromUserID);
        }
        
        public void AddNewMemberToGroup(string groupName,int groupId,GroupsService.users newUser)
        {
            Groups.Add(newUser.Connection_Id, groupName);
            Clients.Client(newUser.Connection_Id).addedToNewGroup(new { Group_ID = groupId , Group_Name = groupName });
            Clients.Group(groupName, newUser.Connection_Id, Context.ConnectionId).addedNewMember(newUser, groupId,groupName);
        }
    }
}