using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_StokTakipOtomasyonu.Models.Entity;

namespace MVC_StokTakipOtomasyonu.Controllers
{
    public class KategorilerController : Controller
    {
        MVC_StokTakipEntities db = new MVC_StokTakipEntities();
        // GET: Kategoriler
        public ActionResult Index()
        {
            return View(db.Kategoriler.ToList());
        }

        public ActionResult Ekle()
        {
            return View();
        }

        public ActionResult Ekle2(Kategoriler p)
        {
            if (!ModelState.IsValid)
            {
                return View("Ekle");
            }
            db.Kategoriler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Kategoriler");

        }

        public ActionResult GuncelleBilgiGetir(int id)
        {
            var modelbilgiler = db.Kategoriler.Find(id); // veya var model2 = db.Kategoriler.Where(x => x.ID == p.ID);
            if (modelbilgiler == null)
            {
                return HttpNotFound();
            }
            return View(modelbilgiler);
        }

        public ActionResult Guncelle(Kategoriler p)
        {
            if (!ModelState.IsValid)
            {
                return View("GuncelleBilgiGetir");
            }
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Kategoriler");

        }

        public ActionResult SilBilgiGetir(Kategoriler p)
        {
            var modelbilgiler = db.Kategoriler.Find(p.ID); // veya var model2 = db.Kategoriler.Where(x => x.ID == p.ID);
            if (modelbilgiler == null)
            {
                return HttpNotFound();
            }
            return View(modelbilgiler);
        }

        public ActionResult Sil(Kategoriler p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Kategoriler");

        }
    }
}