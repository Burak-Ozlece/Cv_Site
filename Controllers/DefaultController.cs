using MvcCv.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkında.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyim = db.TblDeneyimlerim.ToList();
            return PartialView(deneyim);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalMedya = db.TblSosyalMedya.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyalMedya);
        }
        public PartialViewResult Eğitimlerim()
        {
            var eğitimler = db.TblEğitimlerim.ToList();
            return PartialView(eğitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TblYeteneklerim.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobilerim()
        {
            var hobiler = db.TblHobilerim.ToList();
            return PartialView(hobiler);
        }
        public PartialViewResult Seltifikalarım()
        {
            var seltifikalar = db.TblSeltifikalarım.ToList();
            return PartialView(seltifikalar);
        }
        [HttpGet]
        public PartialViewResult İletişim()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult İletişim(Tblİletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tblİletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}