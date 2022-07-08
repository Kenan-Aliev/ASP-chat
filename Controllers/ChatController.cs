using System.Web.Mvc;
using ASP_chat.UsersService;
using ASP_chat.ChatService;
using ASP_chat.GroupsService;
using System.ServiceModel;

namespace ASP_chat.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        UsersClient usersClient = new UsersClient();
        ChatServiceClient chatService = new ChatServiceClient();
        GroupsClient groupsClient = new GroupsClient(); 
        public ActionResult Index(WcfService.users user)
        {
            return View("Index",user);
        }

        [HttpPost]
        public JsonResult GetUsers(int mainUserID)
        {
            UsersService.users[] users = usersClient.GetAllUsers(mainUserID);
            return Json(users,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetMessages(int user1_id,int user2_id)
        {
            var messages = chatService.GetAllMessagesWithUser(user1_id, user2_id);
            return Json(messages, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult GetUserGroups(int mainUserID)
        {
            GroupsService.groups[] userGroups = groupsClient.GetUserGroups(mainUserID);
            return Json(userGroups, JsonRequestBehavior.AllowGet);
        }

        [HttpPost] 
        public JsonResult CreateNewGroup(int userId,string groupName)
        {
            try
            {
                GroupsService.groups newGroup = groupsClient.CreateNewGroup(userId,groupName);
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
            GroupsService.messages[] messages = groupsClient.GetGroupMessages(groupID);
            return Json(messages, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetGroupMembers(int groupID)
        {
            GroupsService.users[] members = groupsClient.GetGroupMembers(groupID);
            return Json(members, JsonRequestBehavior.AllowGet);
        }


    }
}