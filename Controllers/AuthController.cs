using System;
using System.Configuration;
using System.ServiceModel;
using System.Web.Mvc;
using WcfService1;
using WcfService1.ChatUOW.Entities;

namespace ASP_chat.Controllers
{
    public class AuthController : Controller
    {
        // auth channel
        static string url = ConfigurationManager.AppSettings["AuthService"];
        static BasicHttpBinding binding = new BasicHttpBinding();
        static EndpointAddress address = new EndpointAddress(url);
        static ChannelFactory<IAuth> factory = new ChannelFactory<IAuth>(binding, address);
        IAuth channel = factory.CreateChannel();


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
                channel.Registration(userData);
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
                User us = channel.Login(user);
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