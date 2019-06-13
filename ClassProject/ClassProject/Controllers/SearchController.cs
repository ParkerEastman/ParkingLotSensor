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
        //public ViewResult GetLocation(Location myLocation)
        //return View($"{myLocation.Lat}, {myLocation.Long}");
        public ActionResult DisplayLocation(string location)
        {
            return View(location);
        }
    }
}