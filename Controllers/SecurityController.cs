using MvcCv.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        // GET: Security
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin tbl)
        {
            DbCvEntities db = new DbCvEntities();
            var bilgi = db.TblAdmin.FirstOrDefault(x => x.KullaniciAdi == tbl.KullaniciAdi && tbl.Parola == x.Parola);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(tbl.KullaniciAdi, false);
                Session["KullaniciAdi"] = bilgi.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Hakkimda");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Security");
        }
    }
}