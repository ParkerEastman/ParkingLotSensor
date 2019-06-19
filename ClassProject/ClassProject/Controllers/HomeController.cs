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

        public ActionResult Index(string Origin, string Destination)
        {
            Directions directions = new Directions(Origin, Destination);
            return View(directions);
        }
    }
}