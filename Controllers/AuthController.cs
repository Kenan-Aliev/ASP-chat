using System;
using System.ServiceModel;
using System.Web.Mvc;
using ASP_chat.WcfService;

namespace ASP_chat.Controllers
{
    public class AuthController : Controller
    {
         AuthClient authClient = new AuthClient();
        // GET: Auth
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(User userData)
        {
            try
            {
                authClient.Registration(userData);
                ViewBag.Message = "Вы успешно зарегистрировались";
                return View("Registration");
            }
            catch (FaultException<ServiceError> ex)
            {
                ViewBag.Message = ex.Detail.Message;
                return View("Registration");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            try
            {
                User us = authClient.Login(user);
                ViewBag.Message = "Вы успешно вошли в свой аккаунт";
                return RedirectToAction("Index","Chat",us);
            }
            catch (FaultException<ServiceError> ex)
            {
                ViewBag.Message = ex.Detail.Message;
                return View("Login"); 
            }

        }
    }
}