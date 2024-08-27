using KurumsalSite.Models;
using KurumsalSite.Models.DataContext;
using KurumsalSite.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Net.Mail;
using System.Web.Mvc;
using System.Text;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace KurumsalSite.Controllers
{

    public class AdminController : Controller
    {
        KurumsalDBContext db = new KurumsalDBContext();  // Models içindeki Context dosyası hangisi ise ondan nesne üretilecek
        // GET: Admin
        [Route("yonetimpaneli")]
        public ActionResult Index()
        {
            ViewBag.BlogSay = db.Blog.Count();
            ViewBag.KategoriSay = db.Kategori.Count();
            ViewBag.HizmetSay = db.Hizmet.Count();
            ViewBag.YorumSay = db.Yorum.Count();
            ViewBag.YorumOnay = db.Yorum.Where(x => x.Onay == false).Count();
            var sorgu = db.Kategori.ToList();
            return View(sorgu);
        }

        [Route("yonetimpaneli/giris")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin, string sifre)
        {
            var md5pass = Crypto.Hash(sifre, "MD5");
            var login = db.Admin.Where(x => x.Eposta == admin.Eposta).SingleOrDefault();

            if (login.Eposta == admin.Eposta && login.Sifre ==sifre)
            {
                Session["adminid"] = login.AdminId;
                Session["eposta"] = login.Eposta;
                return RedirectToAction("Index", "Admin");

            }
            ViewBag.Uyari = "Kulanıcı E-posta veya Şifre Yanlış";

            return View(admin);
        }

        public ActionResult Logout()
        {
            Session["adminid"] = null;
            Session["eposta"] = null;
            Session.Abandon();
            return RedirectToAction("Login", "Admin");
        }

        public ActionResult SifremiUnuttum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SifremiUnuttum(string eposta)
        {
            var mail = db.Admin.Where(x => x.Eposta == eposta).SingleOrDefault();
            if ( mail != null)
            {
                Random rnd = new Random();
                int yenisifre = rnd.Next();

                Admin admin = new Admin();
                mail.Sifre = Crypto.Hash(Convert.ToString(yenisifre), "MD5");
                db.SaveChanges();


                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 25);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("ihkaradag025@gmail.com", "ihK_062538");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;

                MailMessage email = new MailMessage();

                email.From = new MailAddress("ihkaradag025@gmail.com", "User");
                email.To.Add(new MailAddress(mail.Eposta));
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtpClient.Send(email);



                ViewBag.Uyari = "mesajınız başarı ile gönderilmiştir";
            }
            else
            {
                ViewBag.Uyari = "hata oluştu";
            }
            return View();

        }

        public ActionResult Adminler()
        {
            return View(db.Admin.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Admin admin, string sifre, string eposta, string yetki)
        {
            if (ModelState.IsValid)
            {
                admin.Sifre = Crypto.Hash(sifre, "MD5");
                db.Admin.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Adminler");
            }
            return View(admin);
        }

        public ActionResult Edit(int id)
        {
            var a = db.Admin.Where(x => x.AdminId == id).SingleOrDefault();
            return View(a);
        }

        [HttpPost]
        public ActionResult Edit(int id,Admin admin, string sifre, string eposta,string yetki)
        {
            
            if (ModelState.IsValid)
            {
                var a = db.Admin.Where(x => x.AdminId == id).SingleOrDefault();
                a.Sifre = Crypto.Hash(sifre, "MD5");
                a.Eposta = admin.Eposta;
                a.Yetki = admin.Yetki;
                db.SaveChanges();
                return RedirectToAction("Adminler");
            }                        
            return View(admin);
        }

        public ActionResult Delete(int id)
        {
            var a = db.Admin.Where(x => x.AdminId == id).SingleOrDefault();
            if (a != null)
            {
                db.Admin.Remove(a);
                db.SaveChanges();
               return RedirectToAction("Adminler");
            }
            return View();
         }
    }
}