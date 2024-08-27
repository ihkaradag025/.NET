using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        Context db = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var bloglistele = db.Blogs.ToList();
            return View(bloglistele);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }

        public ActionResult Blogsil(int id)
        {
            var blogsil = db.Blogs.Where(x => x.BlogId == id).SingleOrDefault();
            db.Blogs.Remove(blogsil);
            db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        public ActionResult BlogGetir(int id)
        {
            var bloggetir = db.Blogs.Where(x => x.BlogId == id).SingleOrDefault();
            
            return View("BlogGetir", bloggetir);
        }

        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult BlogGuncelle(Blog blog, HttpPostedFileBase BlogImage)
        {
            var blogguncelle = db.Blogs.Where(x => x.BlogId == blog.BlogId).SingleOrDefault();


            if (blogguncelle.BlogImage != null)
            {
                if (System.IO.File.Exists(Server.MapPath(blogguncelle.BlogImage)))
                {
                    System.IO.File.Delete(Server.MapPath(blogguncelle.BlogImage));
                }
                WebImage img = new WebImage(BlogImage.InputStream);
                FileInfo imginfo = new FileInfo(BlogImage.FileName);

                string blogresimname = imginfo.Name;  /*burada FullName kullanılırsa dosya yolu ile birlikte alır.*/
                img.Resize(1024, 360);
                img.Save("~/images/" + blogresimname);
                blogguncelle.BlogImage = "/images/" + blogresimname;
            }
            
            
            blogguncelle.Baslik = blog.Baslik;
            blogguncelle.Tarih = blog.Tarih;
            blogguncelle.Aciklama = blog.Aciklama;
           
            db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }


        public ActionResult YorumListesi()
        {
            var yorumliste = db.Yorumlars.ToList();
            return View(yorumliste);
        }

        public ActionResult YorumSil(int id)
        {
            var yorumsil = db.Yorumlars.Where(x => x.YorumId == id).SingleOrDefault();
            db.Yorumlars.Remove(yorumsil);
            db.SaveChanges();
            TempData["Message"] = "Yorumunuz başarıyla silindi!";
            return RedirectToAction("YorumListesi", "Admin");
        }


        public ActionResult YorumGetir(int id)
        {
            var yorumgetir = db.Yorumlars.Where(x => x.YorumId == id).SingleOrDefault();

            return View("YorumGetir", yorumgetir);
        }

        //[ValidateAntiForgeryToken]
        //[ValidateInput(false)]
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = db.Yorumlars.Find(y.YorumId);/*Where(x => x.YorumId == yorum.YorumId).SingleOrDefault();*/

            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            yrm.OnayDurum = y.OnayDurum;

            db.SaveChanges();
            return RedirectToAction("YorumListesi", "Admin");
        }
    }
}