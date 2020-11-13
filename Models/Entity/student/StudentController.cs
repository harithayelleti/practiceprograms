using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentMVCentity.Models;

namespace StudentMVCentity.Controllers
{
    public class StudentController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Index1()
        {
            return View(db.StudentTable.ToList());
        }
    }
}