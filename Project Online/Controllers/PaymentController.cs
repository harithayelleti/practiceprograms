using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectCustomer.Models;

namespace ProjectCustomer.Controllers
{
    public class PaymentController : Controller
    {
        private BookingTicketEntities db = new BookingTicketEntities();

        // GET: Payment
        public ActionResult List()
        {
            return View(db.tbl_Booking.ToList());
        }
        public ActionResult TicketDetails()
        {
            return View();
        }

        // GET: Payment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Booking tbl_Booking = db.tbl_Booking.Find(id);
            if (tbl_Booking == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Booking);
        }

        // GET: Payment/Create
        public ActionResult BookTicket()
        {
            return View();
        }

        // POST: Payment/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookTicket([Bind(Include = "Theater_Id,Movie,Show,Ticket_Type,Persons,Cost,Payment__Type")] tbl_Booking tbl_Booking)
        {
            TempData["SucessMesssage"] = "<script>alert('Sucessfully Booked your Ticket')</script>";
            if (ModelState.IsValid)
            {
                db.tbl_Booking.Add(tbl_Booking);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(tbl_Booking);
        }

        // GET: Payment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Booking tbl_Booking = db.tbl_Booking.Find(id);
            if (tbl_Booking == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Booking);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Theater_Id,Movie,Show,Ticket_Type,Persons,Cost,Payment__Type")] tbl_Booking tbl_Booking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Booking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(tbl_Booking);
        }

        // GET: Payment/Delete/5
        public ActionResult CancelTicket(int? id)
        {
            TempData["DangerMesssage"] = "<script>alert('Cancelled your Ticket')</script>";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Booking tbl_Booking = db.tbl_Booking.Find(id);
            if (tbl_Booking == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Continue","Customer");
        }

        // POST: Payment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Booking tbl_Booking = db.tbl_Booking.Find(id);
            db.tbl_Booking.Remove(tbl_Booking);
            db.SaveChanges();
            return RedirectToAction("List");
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
