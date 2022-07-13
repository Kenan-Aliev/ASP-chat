using System.Web.Mvc;
using System.ServiceModel;
using System.Configuration;
using WcfService1;
using WcfService1.ChatUOW.Entities;
using System.Collections.Generic;

namespace ASP_chat.Controllers
{
    public class ChatController : Controller
    {
        // users channel
        static string usersUrl = ConfigurationManager.AppSettings["UsersService"];
        static BasicHttpBinding binding = new BasicHttpBinding();
        static EndpointAddress usersAddress = new EndpointAddress(usersUrl);
        static ChannelFactory<IUsers> userFactory = new ChannelFactory<IUsers>(binding, usersAddress);
        IUsers usersChannel = userFactory.CreateChannel();

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

        public ActionResult Index(User user)
        {
            return View("Index",user);
        }

        [HttpPost]
        public JsonResult GetUsers(int mainUserID)
        {
            List<User> users = usersChannel.GetAllUsers(mainUserID);
            return Json(users,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetMessages(int user1_id,int user2_id)
        {
            var messages = chatChannel.GetAllMessagesWithUser(user1_id, user2_id);
            return Json(messages, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult GetUserGroups(int mainUserID)
        {
            List<Group> userGroups = groupsChannel.GetUserGroups(mainUserID);
            return Json(userGroups, JsonRequestBehavior.AllowGet);
        }

        [HttpPost] 
        public JsonResult CreateNewGroup(int userId,string groupName)
        {
            try
            {
                Group newGroup = groupsChannel.CreateNewGroup(userId,groupName);
                return Json(newGroup, JsonRequestBehavior.AllowGet);
            }
            catch(FaultException<ServiceError> ex)
            {
                return Json(new { hasError = true, message = ex.Detail.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult GetGroupMessages(int groupID)
        {
            List<Messages> messages = groupsChannel.GetGroupMessages(groupID);
            return Json(messages, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetGroupMembers(int groupID)
        {
            List<User> members = groupsChannel.GetGroupMembers(groupID);
            return Json(members, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddNewUserToGroup(int groupId, int userId) 
        {
            try {
                User newUser = groupsChannel.AddUserToGroup(userId, groupId);
                return Json(newUser, JsonRequestBehavior.AllowGet);
            }
            catch (FaultException<ServiceError> ex)
            {
                return Json(new { hasError = true, message = ex.Detail.Message }, JsonRequestBehavior.AllowGet);
            }
        }


    }
}