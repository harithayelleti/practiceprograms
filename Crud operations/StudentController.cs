using MVCcrud.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCcrud.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudendbEntities db = new StudendbEntities();
               
        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(StudentTable model)
        {
            if (ModelState.IsValid)
            {
                StudentTable obj = new StudentTable();
                obj.Name = model.Name;
                obj.Email = model.Email;
                obj.City = model.City;

                db.StudentTables.Add(obj);
                db.SaveChanges();

            }
            ModelState.Clear();

            return View("Student");
        }
        public ActionResult StudentList()
        {
            var res = db.StudentTables.ToList();
            return View(res);
        }

        public ActionResult Delete( int id)
        {
            var res = db.StudentTables.Where(x => x.Id == id).First();
            db.StudentTables.Remove(res);
            db.SaveChanges();

            var list = db.StudentTables.ToList();

            return View("StudentList");
        }
    }
}