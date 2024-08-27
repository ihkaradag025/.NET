using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    
    public class AboutController : Controller
    {
        Context db = new Context();
        // GET: About
        public ActionResult Index()
        {
            var degerler = db.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}