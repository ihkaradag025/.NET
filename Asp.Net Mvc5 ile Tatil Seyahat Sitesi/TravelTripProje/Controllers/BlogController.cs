using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context db = new Context();
        BlogYorum by = new BlogYorum();
        // GET: Blog

        public ActionResult Index()
        {
            //var bloglar = db.Blogs.ToList();
            by.Deger1 = db.Blogs.ToList();
            by.Deger3 = db.Blogs.Take(4).OrderByDescending(x => x.BlogId).ToList();
            by.Deger4 = db.Yorumlars.Take(4).OrderByDescending(x => x.YorumId).ToList();
            
            return View(by);
        }

        
        public ActionResult BlogDetay(int id)
        {
            //var blogdetay = db.Blogs.Where(x=>x.BlogId==id).SingleOrDefault();
            by.Deger1 = db.Blogs.Where(x => x.BlogId == id).ToList();
            by.Deger2 = db.Yorumlars.Where(x => x.Blogid == id).ToList();
            by.Deger3 = db.Blogs.Take(4).OrderByDescending(x => x.BlogId).ToList();
            by.Deger4 = db.Yorumlars.Take(4).OrderByDescending(x => x.YorumId).ToList();
           
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.blogiddegeri = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            
            db.Yorumlars.Add(y);
            db.SaveChanges();
            return PartialView();
            

        }


    }
}