using System.Web.Mvc;
using ASP_chat.UsersService;
using ASP_chat.ChatService;

namespace ASP_chat.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        UsersClient usersClient = new UsersClient();
        ChatServiceClient chatService = new ChatServiceClient();
        public ActionResult Index(WcfService.users user)
        {
            return View(user);
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

    }
}