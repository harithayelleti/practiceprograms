using SamplePorj1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SamplePorj1.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize(Roles = "admin")]

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User model, string returnUrl)
        {
            JobportalEntities jobportal = new JobportalEntities();
            var dataItem = jobportal.Users.Where(x => x.Username == model.Username && x.password == model.password).First();
            if (dataItem != null)
            {
                FormsAuthentication.SetAuthCookie(dataItem.Username, false);
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    //return RedirectToAction("Index");
                    return RedirectToAction("DashBoard", "DashBoard");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid shortid/password");
                return View();
            }

        }
        [Authorize]



        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Home");
        }
    }
}