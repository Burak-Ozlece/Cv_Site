using MvcCv.Models.entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim
        GenericRepository<TblEğitimlerim> repo = new GenericRepository<TblEğitimlerim>();
        public ActionResult Index()
        {
            return View(repo.List());
        }

        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(TblEğitimlerim p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult EgitimSil(int id)
        {
            var egitim = repo.Find(x=>x.Id == id);
            repo.Tdel(egitim);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EgitimDuzenle(int id)
        {
            var egitim = repo.Find(x=>x.Id==id);
            return View(egitim);
        }
        [HttpPost]
        public ActionResult EgitimDuzenle(TblEğitimlerim e)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var egitim = repo.Find(x => x.Id == e.Id);
            egitim.Baslik = e.Baslik;
            egitim.AltBaslik= e.AltBaslik;
            egitim.AltBaslik2= e.AltBaslik2;
            egitim.GNO = e.GNO;
            egitim.Tarih = e.Tarih;
            repo.TUpdate(egitim);
            return RedirectToAction("Index");
        }
    }
}