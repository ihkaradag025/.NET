﻿using KurumsalSite.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using KurumsalSite.Models.Model;

namespace KurumsalSite.Controllers
{

    public class HomeController : Controller
    {
        KurumsalDBContext db = new KurumsalDBContext();
        // GET: Home
        [Route("")]
        [Route("Anasayfa")]
        public ActionResult Index()
        {
            ViewBag.Kimlik = db.Kimlik.SingleOrDefault();
            ViewBag.Hizmetler = db.Hizmet.ToList().OrderByDescending(x => x.HizmetId);


            return View();
        }

        public ActionResult SliderPartial()
        {
            return View(db.Slider.ToList().OrderByDescending(x => x.SliderId));
        }

        public ActionResult HizmetPartial()
        {
            return View(db.Hizmet.ToList().OrderByDescending(x => x.HizmetId));
        }

        [Route("Hakkimizda")]
        public ActionResult Hakkimizda()
        {
            ViewBag.Kimlik = db.Kimlik.SingleOrDefault();
            return View(db.Hakkimizda.SingleOrDefault());

        }

        [Route("Hizmetlerimiz")]
        public ActionResult Hizmetlerimiz()
        {
            ViewBag.Kimlik = db.Kimlik.SingleOrDefault();
            return View(db.Hizmet.ToList().OrderByDescending(x => x.HizmetId));
        }

        [Route("iletisim")]
        public ActionResult Iletisim()
        {
            ViewBag.Kimlik = db.Kimlik.SingleOrDefault();
            return View(db.Iletisim.SingleOrDefault());
        }

        [HttpPost]
        public ActionResult Iletisim(string adsoyad = null, string email = null, string konu = null, string mesaj = null)
        {
            if (adsoyad != null && email != null)
            {
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.EnableSsl = true;
                WebMail.UserName = "ihkaradag2024@gmail.com";
                WebMail.Password = "ihK_250638";
                WebMail.SmtpPort = 587;

                WebMail.Send("ihkaradag2024@gmail.com", konu, email + "-" + mesaj);
                ViewBag.Uyari = "mesajınız başarı ile gönderilmiştir";
            }
            else
            {
                ViewBag.Uyari = "hata oluştu";
            }
            return View();
        }


        [Route("BlogPost")]
        public ActionResult Blog(int Sayfa = 1)
        {
            ViewBag.Kimlik = db.Kimlik.SingleOrDefault();
            return View(db.Blog.Include("Kategori").OrderByDescending(x => x.BlogId).ToPagedList(Sayfa, 2));
        }

        [Route("BlogPost/{kategoriad}/{id:int}")]
        public ActionResult KategoriBlog(int id, int Sayfa = 1)
        {
            ViewBag.Kimlik = db.Kimlik.SingleOrDefault();

            var b = db.Blog.Include("Kategori").OrderByDescending(x => x.BlogId).Where(x => x.Kategori.KategoriId == id).ToPagedList(Sayfa, 5);
            return View(b);
        }

        [Route("BlogPost/{baslik}-{id:int}")]
        public ActionResult BlogDetay(int id)
        {
            ViewBag.Kimlik = db.Kimlik.SingleOrDefault();
            var b = db.Blog.Include("Kategori").Include("Yorums").Where(x => x.BlogId == id).SingleOrDefault();
            return View(b);
        }

        public JsonResult YorumYap(string adsoyad, string eposta, string icerik, int blogid)
        {
            if (icerik == null)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            
            db.Yorum.Add(new Yorum { AdSoyad = adsoyad, Eposta = eposta, Icerik = icerik, BlogId = blogid, Onay=false});
            
            db.SaveChanges();           
            return Json(false, JsonRequestBehavior.AllowGet);  /*Json verilerinin alıp gönderilmesine izin ver(JsonRequestBehavior.AllowGet)*/
        }

        public ActionResult KategoriPartial()
        {
            return PartialView(db.Kategori.ToList().OrderByDescending(x => x.KategoriAd));
        }

        public ActionResult BlogKayitPartial()
        {
            return PartialView(db.Blog.ToList().OrderByDescending(x => x.BlogId));
        }
        public ActionResult FooterPartial()
        {
            ViewBag.Hizmetler = db.Hizmet.ToList().OrderByDescending(x => x.HizmetId);
            ViewBag.Iletisim = db.Iletisim.SingleOrDefault();
            ViewBag.Blog = db.Blog.ToList().OrderByDescending(x => x.BlogId);

            return PartialView();
        }
    }
}