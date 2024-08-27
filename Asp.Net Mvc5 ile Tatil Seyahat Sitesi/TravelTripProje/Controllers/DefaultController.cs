using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context db = new Context();
        public ActionResult Index()
        {
            var slaider = db.Blogs.ToList();
            return View(slaider);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult AnaSayfaPartial1()
        {
            var partial1 = db.Blogs.Take(3).OrderByDescending(x => x.BlogId).ToList();////burada normalde ana sayfada son 3 blog var ancak take(3 ) yapınca temadan dolayı 3. alta kayıyor. Başka bir çözüm bulunacak.Çözüm bulundu for döngüsü kullanıldı
            return PartialView(partial1);
        }

        public PartialViewResult AnaSayfaPartial2()
        {
            var partial2 = db.Blogs.Take(10).OrderByDescending(x => x.BlogId).ToList();
            return PartialView(partial2);
        }

        public PartialViewResult AnaSayfaPartial3()
        {
            var partial3 = db.Blogs.Take(6).OrderByDescending(x => x.BlogId).ToList();
            return PartialView(partial3);
        }

    }
}