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
        //// GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Search(string Origin, string Destination, string Name)
        {
            string[] temp = Name.Split('\'');
            Name = temp[1];
            Directions directions = new Directions(Origin, Destination, Name);
            return View(directions);
        }


        // GET: Search
        public ActionResult Index()
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