using SamplePorj1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SamplePorj1.Controllers
{
    public class jobController : Controller
    {
        // GET: job
        public ActionResult Search()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Search(string searching, string searching1)
        {
            JobportalEntities db1 = new JobportalEntities();
            var Jobpost = db1.Jobs.Where(x => x.JobPosition.Contains(searching) || searching == null);
            return View(Jobpost.ToList());
        }
    }
}