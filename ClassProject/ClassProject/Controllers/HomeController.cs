using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassProject.Models;

namespace ClassProject.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Search(string Origin, string Destination, string Name)
        {

            Directions directions = new Directions(Origin, Destination, Name);
            return View(directions);
        }
        
        [HttpPost]
        [ValidateInput(false)]
        public PartialViewResult SearchPost(Directions directions)
        {
          //takes json at user click, model binds to directions obj, calls to mapping api in view
            return PartialView(directions);
        }



        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayLocation(Location location) //latlong of user location modifies dbcontext, lazy workaround for viewmodel
        {
            GarageDBEntities1 context = new GarageDBEntities1();
            context.userLocation = location.Coords;
            return PartialView(context);
            
        }

        
    }
}