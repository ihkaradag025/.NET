using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_StokTakipOtomasyonu.Models.Entity;
namespace MVC_StokTakipOtomasyonu.Controllers
{
    public class UrunlerController : Controller
    {
        MVC_StokTakipEntities db = new MVC_StokTakipEntities();
        // GET: Urunler
        public ActionResult Index()
        {
            var bilgiler = db.Urunler.ToList();
            return View(bilgiler);
        }
    }
}