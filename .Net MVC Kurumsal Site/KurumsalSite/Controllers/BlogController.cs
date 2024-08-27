using KurumsalSite.Models.DataContext;
using KurumsalSite.Models.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace KurumsalSite.Controllers
{
    public class BlogController : Controller
    {
        KurumsalDBContext db = new KurumsalDBContext();
        // GET: Blog
        
        public ActionResult Index()
        {
            return View(db.Blog.ToList().OrderByDescending(x=>x.BlogId));
        }

        public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "KategoriAd");
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Blog blog, HttpPostedFileBase ResimURL )
        {
            if (ResimURL != null)
            {
                
                WebImage img = new WebImage(ResimURL.InputStream);
                FileInfo imginfo = new FileInfo(ResimURL.FileName);

                string logoname = imginfo.Name;  /*burada FullName kullanılırsa dosya yolu ile birlikte alır.*/
                img.Resize(600, 400);
                img.Save("~/Uploads/Blog/" + logoname);
                blog.ResimUrl = "/Uploads/Blog/" + logoname;
            }
            db.Blog.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit (int id)
        {
            if (id == null)
            {
                HttpNotFound();
            }
            var b = db.Blog.Where(x => x.BlogId == id).SingleOrDefault();
             if (b == null)
            {
                HttpNotFound();
            }
            ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "KategoriAd", b.KategoriId);
            return View(b);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Blog blog,HttpPostedFileBase ResimURL)
        {
            if (ModelState.IsValid)
            {
                var b = db.Blog.Where(x => x.BlogId == id).SingleOrDefault();
                if (ResimURL != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(b.ResimUrl)))
                    {
                        System.IO.File.Delete(Server.MapPath(b.ResimUrl));
                    }
                    WebImage img = new WebImage(ResimURL.InputStream);
                    FileInfo imginfo = new FileInfo(ResimURL.FileName);

                    string logoname = imginfo.Name;  /*burada FullName kullanılırsa dosya yolu ile birlikte alır.*/
                    img.Resize(600, 400);
                    img.Save("~/Uploads/Blog/" + logoname);
                    b.ResimUrl = "/Uploads/Blog/" + logoname;
                }
                b.Baslik = blog.Baslik;
                b.Icerik = blog.Icerik;
                b.KategoriId = blog.KategoriId;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        public ActionResult Delete(int id)
        {
            var b = db.Blog.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            if (System.IO.File.Exists(Server.MapPath(b.ResimUrl)))
            {
                System.IO.File.Delete(Server.MapPath(b.ResimUrl));
            }
            db.Blog.Remove(b);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}