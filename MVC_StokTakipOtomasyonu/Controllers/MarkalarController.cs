using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_StokTakipOtomasyonu.Models.Entity;

namespace MVC_StokTakipOtomasyonu.Controllers
{
    public class MarkalarController : Controller
    {
        MVC_StokTakipEntities db = new MVC_StokTakipEntities();
        // GET: Markalar
        public ActionResult Index()
        {
            var modelbilgiler = db.Markalar.ToList();
            return View(modelbilgiler);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            SelecteBilgiGetir();

            return View();
        }

        private void SelecteBilgiGetir()
        {
            var model = new Markalar();
            // ViewBag.KategoriID = new SelectList(db.Kategoriler, "ID", "Kategori", model.KategoriID); //dropdownlis i doldurma
            //veya
            List<SelectListItem> liste = new List<SelectListItem>(from x in db.Kategoriler
                                                                  select new SelectListItem
                                                                  {
                                                                      Value = x.ID.ToString(),
                                                                      Text = x.Kategori
                                                                  }
                                                                  ).ToList();
            ViewBag.l = liste;
        }

        [HttpPost]
        public ActionResult Ekle(Markalar m)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.KategoriID = new SelectList(db.Kategoriler, "ID", "Kategori", m.KategoriID); //dropdownlis i doldurma
                return View("Ekle");
            }
            db.Entry(m).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index","Markalar");
        }

        public ActionResult GuncelleBilgiGetir(int id)
        {
            
            var bilgiler = db.Markalar.Find(id);
            SelecteBilgiGetir();
            if (bilgiler == null)
            {
                return HttpNotFound();
            }
            return View(bilgiler);
        }

        public ActionResult Guncelle(Markalar p)
        {
            if (!ModelState.IsValid)
            {
                SelecteBilgiGetir();
                return View("GuncelleBilgiGetir");
            }
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Markalar");

        }

        public ActionResult SilBilgiGetir(Kategoriler p)
        {
            var modelbilgiler = db.Markalar.Find(p.ID); // veya var model2 = db.Markalar.Where(x => x.ID == p.ID);
            if (modelbilgiler == null)
            {
                return HttpNotFound();
            }
            return View(modelbilgiler);
        }

        public ActionResult Sil(Markalar p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index", "Markalar");

        }
    }

   
}