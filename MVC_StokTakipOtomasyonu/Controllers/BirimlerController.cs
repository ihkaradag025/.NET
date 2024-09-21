using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_StokTakipOtomasyonu.Models.Entity;

namespace MVC_StokTakipOtomasyonu.Controllers
{

    public class BirimlerController : Controller
    {
        MVC_StokTakipEntities db = new MVC_StokTakipEntities();
        // GET: Birimler
        public ActionResult Index()
        {
            return View(db.Birimler.ToList());
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Birimler p)
        {
            if (!ModelState.IsValid)
            {
                return View("Ekle");
            }
            db.Birimler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Birimler");
        }

        public ActionResult GuncelleBilgiGetir(int id)
        {
            var modelbilgiler = db.Birimler.Find(id); // veya var model2 = db.Birimler.Where(x => x.ID == p.ID);
            if (modelbilgiler == null)
            {
                return HttpNotFound();
            }
            return View(modelbilgiler);
        }

        public ActionResult Guncelle(Birimler p)
        {
            if (!ModelState.IsValid)
            {
                return View("GuncelleBilgiGetir");
            }
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Birimler");

        }

        public ActionResult SilBilgiGetir(Birimler p)
        {
            var modelbilgiler = db.Birimler.Find(p.ID); // veya var model2 = db.Birimler.Where(x => x.ID == p.ID);
            if (modelbilgiler == null)
            {
                return HttpNotFound();
            }
            return View(modelbilgiler);
        }

        public ActionResult Sil(Birimler p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Birimler");

        }
    }
}