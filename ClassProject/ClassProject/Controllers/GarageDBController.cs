using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassProject.Models;

namespace ClassProject.Controllers
{
    public class GarageDBController : Controller
    {
        // GET: GarageDB
        public ActionResult Index()
        {  
            GarageDBEntities1 context = new GarageDBEntities1();
            
            return View(context.Lots);
        }
    }
}