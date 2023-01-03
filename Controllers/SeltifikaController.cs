using MvcCv.Models.entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SeltifikaController : Controller
    {
        // GET: Seltifika
        GenericRepository<TblSeltifikalarım> repo = new GenericRepository<TblSeltifikalarım>();
        public ActionResult Index()
        {
            return View(repo.List());
        }
        [HttpGet]
        public ActionResult SeltifikaGetir(int id)
        {
            var seltifika = repo.Find(x => x.Id == id);
            return View(seltifika);
        }
        [HttpPost]
        public ActionResult SeltifikaGetir(TblSeltifikalarım p)
        {
            var seltifika = repo.Find(x => x.Id == p.Id);
            seltifika.Aciklama = p.Aciklama;
            seltifika.Tarih = p.Tarih;
            repo.TUpdate(seltifika);
            return RedirectToAction("Index");
        }
        public ActionResult SeltifikaSil(int id)
        {
            var seltifika = repo.Find(x => x.Id == id);
            repo.Tdel(seltifika);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniSeltifika()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSeltifika(TblSeltifikalarım seltifika)
        {
            repo.Tadd(seltifika);
            return RedirectToAction("Index");
        }
    }
}