using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCdbfirstapproach.Controllers;

namespace MVCdbfirstapproach.Controllers
{
    public class HomeController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Index1()
        {
            return View(db.StudentTables);
        }
    }
}