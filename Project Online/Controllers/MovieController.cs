using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectCustomer.Models;

namespace ProjectCustomer.Controllers
{
    public class MovieController : Controller
    {
        MovieEntities me = new MovieEntities();
        
        // GET: Movie
        public ActionResult Movie()
        {
            return View(me.tbl_Movie.ToList());
        }
    }
}