using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMVCEntity.Models;

namespace EmployeeMVCEntity.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext ec = new EmployeeContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Index1()
        {
            return View(ec.EmployeeTable.ToList());
        }
    }
}