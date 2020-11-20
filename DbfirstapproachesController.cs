using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_MVC1;

namespace CRUD_MVC1.Controllers
{
    public class DbfirstapproachesController : Controller
    {
        private MVCEntities db = new MVCEntities();

        // GET: Dbfirstapproaches
        public ActionResult Index()
        {
            return View(db.Dbfirstapproach.ToList());
        }

        // GET: Dbfirstapproaches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dbfirstapproach dbfirstapproach = db.Dbfirstapproach.Find(id);
            if (dbfirstapproach == null)
            {
                return HttpNotFound();
            }
            return View(dbfirstapproach);
        }

        // GET: Dbfirstapproaches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dbfirstapproaches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,City,Age")] Dbfirstapproach dbfirstapproach)
        {
            if (ModelState.IsValid)
            {
                db.Dbfirstapproach.Add(dbfirstapproach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbfirstapproach);
        }

        // GET: Dbfirstapproaches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dbfirstapproach dbfirstapproach = db.Dbfirstapproach.Find(id);
            if (dbfirstapproach == null)
            {
                return HttpNotFound();
            }
            return View(dbfirstapproach);
        }

        // POST: Dbfirstapproaches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,City,Age")] Dbfirstapproach dbfirstapproach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbfirstapproach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbfirstapproach);
        }

        // GET: Dbfirstapproaches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dbfirstapproach dbfirstapproach = db.Dbfirstapproach.Find(id);
            if (dbfirstapproach == null)
            {
                return HttpNotFound();
            }
            return View(dbfirstapproach);
        }

        // POST: Dbfirstapproaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dbfirstapproach dbfirstapproach = db.Dbfirstapproach.Find(id);
            db.Dbfirstapproach.Remove(dbfirstapproach);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
