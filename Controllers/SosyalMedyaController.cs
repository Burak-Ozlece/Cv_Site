using MvcCv.Models.entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya
        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
        public ActionResult Index()
        {
            return View(repo.List());
        }
        [HttpPost]
        public ActionResult Ekle(TblSosyalMedya p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SosyalMedyaDüzenle(int id)
        {
            var sosyalMedya = repo.Find(x=>x.Id == id);
            return View(sosyalMedya);
        }
        [HttpPost]
        public ActionResult SosyalMedyaDüzenle(TblSosyalMedya p)
        {
            var sosyalMedya = repo.Find(x => x.Id == p.Id);
            sosyalMedya.Link = p.Link;
            sosyalMedya.Ad = p.Ad;
            sosyalMedya.Ikon = p.Ikon;
            sosyalMedya.Durum = true;
            repo.TUpdate(sosyalMedya);
            return RedirectToAction("Index");

        }
        public ActionResult SosyalMedyaSil(int id)
        {
            var sosyalMedya = repo.Find(x=>x.Id==id);
            sosyalMedya.Durum = false;
            repo.TUpdate(sosyalMedya);
            return RedirectToAction("Index");
        }
    }
}