using ClassProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassProject.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult FindLocation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayLocation(Location location)
        {
            GarageDBEntities1 context = new GarageDBEntities1();
            context.userLocation = location.Coords;
            return PartialView(context);

        }


    }
}