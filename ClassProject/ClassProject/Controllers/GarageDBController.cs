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

        [HttpPost]
        public void UpdateLot(MCUReturn update)
        {          
            GarageDBEntities1 context = new GarageDBEntities1();
            var lot = context.Lots
                       .Where(b => b.LotID == update.ID)
                       .FirstOrDefault();
            lot.NumOfOccupants += update.Change;
            context.SaveChanges();
                
                //find update.ID in lot and operate update.Change on occupancy

        }
    }
}